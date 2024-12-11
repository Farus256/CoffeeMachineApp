using System;
using Newtonsoft.Json;

namespace CoffeeMachineApp.Model
{
    public class CoffeeMachine
    {
        // Властивості кавового автомату
        public int PaperCups { get; private set; }
        public int Stirrers { get; private set; }
        public int Straws { get; private set; }
        public int CoffeePortions { get; private set; }
        public int WaterPortions { get; private set; }
        public int MilkPortions { get; private set; }
        public int SugarPortions { get; private set; }
        public bool AcceptsCard { get; private set; }
        public bool ReturnsChange { get; private set; }
        public string Address { get; private set; }
        public decimal CashBalance { get; private set; }

        // Події
        public event EventHandler<DrinkOrderedEventArgs> DrinkOrdered;
        public event EventHandler<ResourceDepletedEventArgs> ResourceDepleted;

        // Посилання на компанію для логування
        [JsonIgnore]
        public CoffeeCompany Company { get; set; }

        public CoffeeMachine(int paperCups, int stirrers, int straws, int coffeePortions, int waterPortions,
            int milkPortions, int sugarPortions, bool acceptsCard, bool returnsChange, string address)
        {
            PaperCups = paperCups;
            Stirrers = stirrers;
            Straws = straws;
            CoffeePortions = coffeePortions;
            WaterPortions = waterPortions;
            MilkPortions = milkPortions;
            SugarPortions = sugarPortions;
            AcceptsCard = acceptsCard;
            ReturnsChange = returnsChange;
            Address = address;
            CashBalance = 0;
        }

        public string PrepareDrink(IDrink drink, PaymentType paymentType, decimal amountPaid)
        {
            // Перевірка ресурсів
            if (PaperCups < drink.PaperCups ||
                Stirrers < drink.Stirrers ||
                Straws < drink.Straws ||
                CoffeePortions < drink.CoffeePortions ||
                WaterPortions < drink.WaterPortions ||
                MilkPortions < drink.MilkPortions ||
                SugarPortions < drink.SugarPortions)
            {
                // Недостатньо ресурсів
                string message = $"Неможливо приготувати {drink.Name}. Недостатньо ресурсів. Гроші повертаються.";
                OnResourceDepleted(new ResourceDepletedEventArgs(Address, drink.Name, message));
                return message;
            }

            // Перевірка оплати
            if (paymentType == PaymentType.Card)
            {
                if (!AcceptsCard)
                {
                    string message = "Цей автомат не приймає оплату карткою. Гроші повертаються.";
                    OnDrinkOrdered(new DrinkOrderedEventArgs(Address, drink.Name, drink.Price, message));
                    return message;
                }
                // Припускаємо, що оплата карткою завжди успішна
            }
            else if (paymentType == PaymentType.Cash)
            {
                if (amountPaid < drink.Price)
                {
                    string message = $"Недостатньо грошей для {drink.Name}. Гроші повертаються.";
                    OnDrinkOrdered(new DrinkOrderedEventArgs(Address, drink.Name, amountPaid, message));
                    return message;
                }
                else if (amountPaid > drink.Price)
                {
                    decimal change = amountPaid - drink.Price;
                    if (ReturnsChange)
                    {
                        CashBalance += drink.Price;
                        DeductResources(drink);
                        string message = $"{drink.Name} готується. Решта: {change} грн.";
                        OnDrinkOrdered(new DrinkOrderedEventArgs(Address, drink.Name, amountPaid, message));
                        return message;
                    }
                    else
                    {
                        CashBalance += amountPaid;
                        DeductResources(drink);
                        string message = $"Не можу видати решту. {drink.Name} готується.";
                        OnDrinkOrdered(new DrinkOrderedEventArgs(Address, drink.Name, amountPaid, message));
                        return message;
                    }
                }
                else
                {
                    CashBalance += drink.Price;
                    DeductResources(drink);
                    string message = $"{drink.Name} готується.";
                    OnDrinkOrdered(new DrinkOrderedEventArgs(Address, drink.Name, amountPaid, message));
                    return message;
                }
            }

            // Віднімаємо ресурси
            if (paymentType != PaymentType.Cash)
            {
                DeductResources(drink);
                string message = $"{drink.Name} готується.";
                OnDrinkOrdered(new DrinkOrderedEventArgs(Address, drink.Name, 0, message));
                return message;
            }

            string successMessage = $"{drink.Name} готується.";
            OnDrinkOrdered(new DrinkOrderedEventArgs(Address, drink.Name, amountPaid, successMessage));
            return successMessage;
        }

        private void DeductResources(IDrink drink)
        {
            PaperCups -= drink.PaperCups;
            Stirrers -= drink.Stirrers;
            Straws -= drink.Straws;
            CoffeePortions -= drink.CoffeePortions;
            WaterPortions -= drink.WaterPortions;
            MilkPortions -= drink.MilkPortions;
            SugarPortions -= drink.SugarPortions;

            // Перевірка на вичерпання будь-якого ресурсу
            if (PaperCups == 0 || Stirrers == 0 || Straws == 0 ||
                CoffeePortions == 0 || WaterPortions == 0 || MilkPortions == 0 || SugarPortions == 0)
            {
                string depletedResource = "";
                if (PaperCups == 0) depletedResource = "Паперові стакани";
                else if (Stirrers == 0) depletedResource = "Палички для цукру";
                else if (Straws == 0) depletedResource = "Трубочки";
                else if (CoffeePortions == 0) depletedResource = "Кава";
                else if (WaterPortions == 0) depletedResource = "Вода";
                else if (MilkPortions == 0) depletedResource = "Молоко";
                else if (SugarPortions == 0) depletedResource = "Цукор";

                string message = $"Ресурс {depletedResource} вичерпано.";
                OnResourceDepleted(new ResourceDepletedEventArgs(Address, depletedResource, message));
            }
        }

        protected virtual void OnDrinkOrdered(DrinkOrderedEventArgs e)
        {
            DrinkOrdered?.Invoke(this, e);
        }

        protected virtual void OnResourceDepleted(ResourceDepletedEventArgs e)
        {
            ResourceDepleted?.Invoke(this, e);
        }

        /// <summary>
        /// Метод для поповнення ресурсів кавового автомату.
        /// </summary>
        /// <param name="resources">Об'єкт ResourceStorage з ресурсами для поповнення.</param>
        public void RefillResources(ResourceStorage resources)
        {
            PaperCups += resources.PaperCups;
            Stirrers += resources.Stirrers;
            Straws += resources.Straws;
            CoffeePortions += resources.Coffee;
            WaterPortions += resources.Water;
            MilkPortions += resources.Milk;
            SugarPortions += resources.Sugar;
        }
    }

    // Класи аргументів для подій
    public class DrinkOrderedEventArgs : EventArgs
    {
        public string MachineAddress { get; }
        public string DrinkName { get; }
        public decimal AmountPaid { get; }
        public string Result { get; }

        public DrinkOrderedEventArgs(string machineAddress, string drinkName, decimal amountPaid, string result)
        {
            MachineAddress = machineAddress;
            DrinkName = drinkName;
            AmountPaid = amountPaid;
            Result = result;
        }
    }

    public class ResourceDepletedEventArgs : EventArgs
    {
        public string MachineAddress { get; }
        public string ResourceName { get; }
        public string Message { get; }

        public ResourceDepletedEventArgs(string machineAddress, string resourceName, string message)
        {
            MachineAddress = machineAddress;
            ResourceName = resourceName;
            Message = message;
        }
    }
}
