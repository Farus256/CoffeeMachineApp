using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace CoffeeMachineApp.Model
{
    public class CoffeeCompany
    {
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string EDRPOUCode { get; set; }
        public List<CoffeeMachine> Machines { get; set; }
        public List<LogEntry> Logs { get; set; }
        public ResourceStorage Storage { get; set; }

        [JsonIgnore]
        public double TotalMoney
        {
            get
            {
                return Machines.Sum(m => (double)m.CashBalance);
            }
        }

        public CoffeeCompany(string companyName, string companyAddress, string edrpouCode, ResourceStorage storage)
        {
            CompanyName = companyName;
            CompanyAddress = companyAddress;
            EDRPOUCode = edrpouCode;
            Storage = storage;
            Machines = new List<CoffeeMachine>();
            Logs = new List<LogEntry>();
        }

        public void AddMachine(CoffeeMachine machine)
        {
            Machines.Add(machine);
            machine.Company = this;

            // Підписка на події кавового автомату
            machine.DrinkOrdered += HandleDrinkOrdered;
            machine.ResourceDepleted += HandleResourceDepleted;
        }

        public void RemoveMachine(string address)
        {
            var machine = Machines.Find(m => m.Address.Equals(address, StringComparison.OrdinalIgnoreCase));
            if (machine != null)
            {
                // Відписка від подій
                machine.DrinkOrdered -= HandleDrinkOrdered;
                machine.ResourceDepleted -= HandleResourceDepleted;
                Machines.Remove(machine);
            }
        }

        private void HandleDrinkOrdered(object sender, DrinkOrderedEventArgs e)
        {
            LogEntry entry = new LogEntry(e.MachineAddress, e.DrinkName, e.AmountPaid, e.Result);
            Logs.Add(entry);
            SaveLog(entry);
        }

        private void HandleResourceDepleted(object sender, ResourceDepletedEventArgs e)
        {
            LogEntry entry = new LogEntry(e.MachineAddress, e.ResourceName, 0, e.Message);
            Logs.Add(entry);
            SaveLog(entry);

            // Автоматичне відправлення кур'єра
            SendCourier(e.MachineAddress, e.ResourceName);
        }

        private void SendCourier(string machineAddress, string resourceName)
        {
            // Визначення необхідних ресурсів
            ResourceStorage neededResources = new ResourceStorage(0, 0, 0, 0, 0, 0, 0);
            switch (resourceName)
            {
                case "Паперові стакани":
                    neededResources.PaperCups = 100;
                    break;
                case "Палички для цукру":
                    neededResources.Stirrers = 100;
                    break;
                case "Трубочки":
                    neededResources.Straws = 100;
                    break;
                case "Кава":
                    neededResources.Coffee = 100;
                    break;
                case "Вода":
                    neededResources.Water = 500;
                    break;
                case "Молоко":
                    neededResources.Milk = 200;
                    break;
                case "Цукор":
                    neededResources.Sugar = 100;
                    break;
                default:
                    break;
            }

            bool success = SendCourier(machineAddress, neededResources);
            if (success)
            {
                LogEntry courierLog = new LogEntry(machineAddress, "Кур'єр відправлений", 0, $"Кур'єр відправлений для поповнення {resourceName}.");
                Logs.Add(courierLog);
                SaveLog(courierLog);
            }
            else
            {
                LogEntry courierFailLog = new LogEntry(machineAddress, "Кур'єр не відправлений", 0, $"Недостатньо ресурсів у компанії для поповнення {resourceName}.");
                Logs.Add(courierFailLog);
                SaveLog(courierFailLog);
            }
        }

        public bool SendCourier(string machineAddress, ResourceStorage resources)
        {
            var machine = Machines.Find(m => m.Address.Equals(machineAddress, StringComparison.OrdinalIgnoreCase));
            if (machine == null)
                return false;

            // Перевірка наявності ресурсів у компанії
            if (Storage.Coffee < resources.Coffee || Storage.Sugar < resources.Sugar ||
                Storage.Water < resources.Water || Storage.Milk < resources.Milk ||
                Storage.PaperCups < resources.PaperCups || Storage.Stirrers < resources.Stirrers ||
                Storage.Straws < resources.Straws)
                return false;

            // Віднімаємо ресурси з компанії
            bool deducted = Storage.DeductResources(
                paperCups: resources.PaperCups,
                stirrers: resources.Stirrers,
                straws: resources.Straws,
                coffee: resources.Coffee,
                sugar: resources.Sugar,
                water: resources.Water,
                milk: resources.Milk
            );

            if (!deducted)
                return false;

            // Поповнюємо ресурси автомату
            machine.RefillResources(resources);

            return true;
        }

        public void LogOperation(LogEntry entry)
        {
            Logs.Add(entry);
            SaveLog(entry);
        }

        private void SaveLog(LogEntry entry)
        {
            string logFileName = $"Log_{entry.MachineAddress.Replace(" ", "_")}.txt";
            using (StreamWriter sw = new StreamWriter(logFileName, true))
            {
                sw.WriteLine(entry.ToString());
            }
        }

        public void SaveCompanyData(string filePath)
        {
            var jsonData = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        public static CoffeeCompany LoadCompanyData(string filePath)
        {
            var jsonData = File.ReadAllText(filePath);
            CoffeeCompany company = JsonConvert.DeserializeObject<CoffeeCompany>(jsonData);

            // Відновлення посилань на компанію та підписка на події
            foreach (var machine in company.Machines)
            {
                machine.Company = company;
                machine.DrinkOrdered += company.HandleDrinkOrdered;
                machine.ResourceDepleted += company.HandleResourceDepleted;
            }

            return company;
        }
    }

    // Клас логування операцій
    public class LogEntry
    {
        public string MachineAddress { get; set; }
        public string Operation { get; set; }
        public decimal AmountPaid { get; set; }
        public string Result { get; set; }

        public LogEntry(string machineAddress, string operation, decimal amountPaid, string result)
        {
            MachineAddress = machineAddress;
            Operation = operation;
            AmountPaid = amountPaid;
            Result = result;
        }

        public override string ToString()
        {
            return $"{DateTime.Now} | {MachineAddress} | {Operation} | {AmountPaid} грн | {Result}";
        }
    }
}
