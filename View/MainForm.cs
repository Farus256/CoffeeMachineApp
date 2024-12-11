using System;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using CoffeeMachineApp.Model;

namespace CoffeeMachineApp.View
{
    public partial class MainForm : Form
    {
        private CoffeeCompany company;

        public MainForm()
        {
            InitializeComponent();

            // Ініціалізація комбобоксів
            cmbDrinkType.Items.AddRange(new object[] { "Еспресо", "Амерікано", "Капучіно", "Лате" });
            cmbPaymentType.Items.AddRange(new object[] { "Готівка", "Картка" });
            cmbDrinkType.SelectedIndex = 0;
            cmbPaymentType.SelectedIndex = 0;

            // Події для валідації числового вводу
            txtAddPaperCups.KeyPress += NumericTextBox_KeyPress;
            txtAddStirrers.KeyPress += NumericTextBox_KeyPress;
            txtAddStraws.KeyPress += NumericTextBox_KeyPress;
            txtAddCoffeePortions.KeyPress += NumericTextBox_KeyPress;
            txtAddWaterPortions.KeyPress += NumericTextBox_KeyPress;
            txtAddMilkPortions.KeyPress += NumericTextBox_KeyPress;
            txtAddSugarPortions.KeyPress += NumericTextBox_KeyPress;
            txtRefillCoffee.KeyPress += NumericTextBox_KeyPress;
            txtRefillSugar.KeyPress += NumericTextBox_KeyPress;
            txtRefillWater.KeyPress += NumericTextBox_KeyPress;
            txtRefillMilk.KeyPress += NumericTextBox_KeyPress;
            txtAmountPaid.KeyPress += NumericTextBoxWithDecimal_KeyPress;
        }

        // Валідація для числових полів (тільки цифри)
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // Валідація для полів з десятковими числами
        private void NumericTextBoxWithDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (char.IsControl(e.KeyChar))
                return;

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.KeyChar = '.';

                if (txt.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Створення компанії
        private void btnCreateCompany_Click(object sender, EventArgs e)
        {
            try
            {
                string companyName = txtCompanyName.Text.Trim();
                string companyAddress = txtCompanyAddress.Text.Trim();
                string edrpou = txtEDRPOU.Text.Trim();

                if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(companyAddress) || string.IsNullOrEmpty(edrpou))
                {
                    MessageBox.Show("Будь ласка, заповніть всі поля компанії.");
                    return;
                }

                // Ініціалізуємо склад компанії з деякими початковими ресурсами
                ResourceStorage storage = new ResourceStorage(
                    paperCups: 0,
                    stirrers: 0,
                    straws: 0,
                    coffee: 1000,
                    sugar: 500,
                    water: 2000,
                    milk: 1000
                );

                company = new CoffeeCompany(companyName, companyAddress, edrpou, storage);

                MessageBox.Show("Кавова компанія створена успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при створенні компанії: {ex.Message}");
            }
        }

        // Збереження даних компанії
        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            if (company == null)
            {
                MessageBox.Show("Будь ласка, створіть або завантажте компанію перед збереженням.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                saveFileDialog.Title = "Зберегти дані компанії";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        company.SaveCompanyData(saveFileDialog.FileName);
                        MessageBox.Show("Дані компанії збережено успішно.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при збереженні даних: {ex.Message}");
                    }
                }
            }
        }

        // Завантаження даних компанії
        private void btnLoadCompany_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json";
                openFileDialog.Title = "Завантажити дані компанії";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        company = CoffeeCompany.LoadCompanyData(openFileDialog.FileName);
                        // Встановлюємо посилання на компанію для кожного автомата
                        foreach (var machine in company.Machines)
                        {
                            machine.Company = company;
                        }
                        cmbMachines.Items.Clear();
                        foreach (var machine in company.Machines)
                        {
                            cmbMachines.Items.Add($"Автомат {company.Machines.IndexOf(machine) + 1} - {machine.Address}");
                        }
                        MessageBox.Show("Дані компанії завантажено успішно.");
                        DisplayMachineDetails();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}");
                    }
                }
            }
        }

        // Додавання нового кавового автомату
        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            if (company == null)
            {
                MessageBox.Show("Будь ласка, створіть або завантажте компанію перед додаванням автомату.");
                return;
            }

            try
            {
                // Зчитуємо дані з полів додавання автомату
                int paperCups = int.Parse(txtAddPaperCups.Text);
                int stirrers = int.Parse(txtAddStirrers.Text);
                int straws = int.Parse(txtAddStraws.Text);
                int coffeePortions = int.Parse(txtAddCoffeePortions.Text);
                int waterPortions = int.Parse(txtAddWaterPortions.Text);
                int milkPortions = int.Parse(txtAddMilkPortions.Text);
                int sugarPortions = int.Parse(txtAddSugarPortions.Text);
                bool acceptsCard = chkAddAcceptsCard.Checked;
                bool returnsChange = chkAddReturnsChange.Checked;
                string address = txtAddAddress.Text.Trim();

                if (string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Будь ласка, введіть адресу автомату.");
                    return;
                }

                // Перевірка на додатні числа
                if (paperCups < 0 || stirrers < 0 || straws < 0 || coffeePortions < 0 ||
                    waterPortions < 0 || milkPortions < 0 || sugarPortions < 0)
                {
                    MessageBox.Show("Будь ласка, введіть додатні числа для ресурсів.");
                    return;
                }

                CoffeeMachine newMachine = new CoffeeMachine(
                    paperCups: paperCups,
                    stirrers: stirrers,
                    straws: straws,
                    coffeePortions: coffeePortions,
                    waterPortions: waterPortions,
                    milkPortions: milkPortions,
                    sugarPortions: sugarPortions,
                    acceptsCard: acceptsCard,
                    returnsChange: returnsChange,
                    address: address
                );

                newMachine.Company = company;
                company.AddMachine(newMachine);
                cmbMachines.Items.Add($"Автомат {company.Machines.Count} - {newMachine.Address}");
                MessageBox.Show("Кавовий автомат додано успішно.");

                // Очистка полів додавання автомату
                ClearAddMachineFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні автомату: {ex.Message}");
            }
        }

        // Метод для очистки полів додавання автомату
        private void ClearAddMachineFields()
        {
            txtAddPaperCups.Text = "";
            txtAddStirrers.Text = "";
            txtAddStraws.Text = "";
            txtAddCoffeePortions.Text = "";
            txtAddWaterPortions.Text = "";
            txtAddMilkPortions.Text = "";
            txtAddSugarPortions.Text = "";
            txtAddAddress.Text = "";
            chkAddAcceptsCard.Checked = false;
            chkAddReturnsChange.Checked = false;
        }

        // Видалення кавового автомату
        private void btnRemoveMachine_Click(object sender, EventArgs e)
        {
            if (company == null)
            {
                MessageBox.Show("Будь ласка, створіть або завантажте компанію перед видаленням автомату.");
                return;
            }

            if (cmbMachines.SelectedIndex < 0)
            {
                MessageBox.Show("Будь ласка, виберіть кавовий автомат для видалення.");
                return;
            }

            string selectedItem = cmbMachines.SelectedItem.ToString();
            // Припускаємо формат "Автомат X - Address"
            string address = selectedItem.Split('-')[1].Trim();

            DialogResult result = MessageBox.Show($"Ви впевнені, що хочете видалити кавовий автомат за адресою: {address}?", "Підтвердження", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    company.RemoveMachine(address);
                    cmbMachines.Items.RemoveAt(cmbMachines.SelectedIndex);
                    txtMachineDetails.Clear();
                    MessageBox.Show("Кавовий автомат видалено успішно.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при видаленні автомату: {ex.Message}");
                }
            }
        }

        // Відправка кур’єра для поповнення ресурсів
        private void btnSendCourier_Click(object sender, EventArgs e)
        {
            if (company == null)
            {
                MessageBox.Show("Будь ласка, створіть або завантажте компанію перед відправкою кур’єра.");
                return;
            }

            if (cmbMachines.SelectedIndex < 0)
            {
                MessageBox.Show("Будь ласка, виберіть кавовий автомат для поповнення.");
                return;
            }

            string selectedItem = cmbMachines.SelectedItem.ToString();
            string address = selectedItem.Split('-')[1].Trim();

            try
            {
                // Зчитуємо дані з полів поповнення ресурсів
                int refillCoffee = int.Parse(txtRefillCoffee.Text);
                int refillSugar = int.Parse(txtRefillSugar.Text);
                int refillWater = int.Parse(txtRefillWater.Text);
                int refillMilk = int.Parse(txtRefillMilk.Text);

                // Перевірка на додатні числа
                if (refillCoffee < 0 || refillSugar < 0 || refillWater < 0 || refillMilk < 0)
                {
                    MessageBox.Show("Будь ласка, введіть додатні числа для ресурсів.");
                    return;
                }

                // Створюємо ResourceStorage з усіма необхідними параметрами
                ResourceStorage resourcesToReplenish = new ResourceStorage(
                    paperCups: 0,
                    stirrers: 0,
                    straws: 0,
                    coffee: refillCoffee,
                    sugar: refillSugar,
                    water: refillWater,
                    milk: refillMilk
                );

                bool success = company.SendCourier(address, resourcesToReplenish);
                if (success)
                {
                    MessageBox.Show("Ресурси успішно поповнено.");
                    DisplayMachineDetails();
                    ClearRefillFields();
                }
                else
                {
                    MessageBox.Show("Недостатньо ресурсів у компанії для поповнення.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при поповненні ресурсів: {ex.Message}");
            }
        }

        // Метод для очистки полів поповнення ресурсів
        private void ClearRefillFields()
        {
            txtRefillCoffee.Text = "";
            txtRefillSugar.Text = "";
            txtRefillWater.Text = "";
            txtRefillMilk.Text = "";
        }

        // Приготування напою
        private void btnPrepareDrink_Click(object sender, EventArgs e)
        {
            PrepareDrink(cmbDrinkType.Text, cmbPaymentType.Text, txtAmountPaid.Text);
        }

        private void PrepareDrink(string drinkType, string paymentTypeStr, string amountPaidStr)
        {
            if (company == null)
            {
                MessageBox.Show("Будь ласка, створіть або завантажте компанію перед приготуванням напою.");
                return;
            }

            if (cmbMachines.SelectedIndex < 0)
            {
                MessageBox.Show("Будь ласка, виберіть кавовий автомат.");
                return;
            }

            CoffeeMachine machine = company.Machines[cmbMachines.SelectedIndex];

            IDrink drink = null;
            switch (drinkType)
            {
                case "Еспресо":
                    drink = new Espresso();
                    break;
                case "Амерікано":
                    drink = new Americano();
                    break;
                case "Капучіно":
                    drink = new Cappuccino();
                    break;
                case "Лате":
                    drink = new Latte();
                    break;
                default:
                    MessageBox.Show("Будь ласка, виберіть дійсний напій.");
                    return;
            }

            PaymentType paymentType;
            switch (paymentTypeStr)
            {
                case "Готівка":
                    paymentType = PaymentType.Cash;
                    break;
                case "Картка":
                    paymentType = PaymentType.Card;
                    break;
                default:
                    MessageBox.Show("Будь ласка, виберіть дійсний тип оплати.");
                    return;
            }

            decimal amountPaid = 0;
            if (paymentType == PaymentType.Cash)
            {
                if (!decimal.TryParse(amountPaidStr, out amountPaid))
                {
                    MessageBox.Show("Будь ласка, введіть дійсну суму оплати.");
                    return;
                }

                if (amountPaid < 0)
                {
                    MessageBox.Show("Сума оплати повинна бути додатнім числом.");
                    return;
                }
            }

            string result = machine.PrepareDrink(drink, paymentType, amountPaid);
            txtOutput.Text = result;

            DisplayMachineDetails();
        }

        // Відображення деталей обраного автомата
        private void DisplayMachineDetails()
        {
            if (cmbMachines.SelectedIndex < 0)
                return;

            int index = cmbMachines.SelectedIndex;
            CoffeeMachine machine = company.Machines[index];
            txtMachineDetails.Text = $"Адреса: {machine.Address}\r\n" +
                $"Паперові стакани: {machine.PaperCups}\r\n" +
                $"Палички для цукру: {machine.Stirrers}\r\n" +
                $"Трубочки: {machine.Straws}\r\n" +
                $"Порції кави: {machine.CoffeePortions}\r\n" +
                $"Порції води: {machine.WaterPortions}\r\n" +
                $"Порції молока: {machine.MilkPortions}\r\n" +
                $"Порції цукру: {machine.SugarPortions}\r\n" +
                $"Приймає картки: {machine.AcceptsCard}\r\n" +
                $"Видає решту: {machine.ReturnsChange}\r\n" +
                $"Баланс готівки: {machine.CashBalance} грн\r\n" +
                $"Всього грошей компанії: {company.TotalMoney} грн\r\n" +
                $"Склад ресурсів компанії: {company.Storage}";
        }

        // Подія вибору автомата зі списку
        private void cmbMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayMachineDetails();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            btnSendCourier_Click(sender, e);
        }
    }
}
