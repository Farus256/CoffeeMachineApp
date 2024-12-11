namespace CoffeeMachineApp.View
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Декларація контролів
        private System.Windows.Forms.GroupBox grpCompany;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.Label lblEDRPOU;
        private System.Windows.Forms.TextBox txtEDRPOU;
        private System.Windows.Forms.Button btnCreateCompany;
        private System.Windows.Forms.Button btnSaveCompany;
        private System.Windows.Forms.Button btnLoadCompany;

        private System.Windows.Forms.GroupBox grpMachines;
        private System.Windows.Forms.Label lblSelectMachine;
        private System.Windows.Forms.ComboBox cmbMachines;
        private System.Windows.Forms.Label lblMachineDetails;
        private System.Windows.Forms.TextBox txtMachineDetails;

        private System.Windows.Forms.GroupBox grpAddMachine;
        private System.Windows.Forms.Label lblAddPaperCups;
        private System.Windows.Forms.TextBox txtAddPaperCups;
        private System.Windows.Forms.Label lblAddStirrers;
        private System.Windows.Forms.TextBox txtAddStirrers;
        private System.Windows.Forms.Label lblAddStraws;
        private System.Windows.Forms.TextBox txtAddStraws;
        private System.Windows.Forms.Label lblAddCoffeePortions;
        private System.Windows.Forms.TextBox txtAddCoffeePortions;
        private System.Windows.Forms.Label lblAddWaterPortions;
        private System.Windows.Forms.TextBox txtAddWaterPortions;
        private System.Windows.Forms.Label lblAddMilkPortions;
        private System.Windows.Forms.TextBox txtAddMilkPortions;
        private System.Windows.Forms.Label lblAddSugarPortions;
        private System.Windows.Forms.TextBox txtAddSugarPortions;
        private System.Windows.Forms.CheckBox chkAddAcceptsCard;
        private System.Windows.Forms.CheckBox chkAddReturnsChange;
        private System.Windows.Forms.Label lblAddAddress;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.Button btnAddMachine;

        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.Button btnRemoveMachine;
        private System.Windows.Forms.Button btnPrepareDrink;
        private System.Windows.Forms.Label lblDrinkType;
        private System.Windows.Forms.ComboBox cmbDrinkType;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.TextBox txtOutput;

        private System.Windows.Forms.GroupBox grpRefillResources;
        private System.Windows.Forms.Label lblRefillCoffee;
        private System.Windows.Forms.TextBox txtRefillCoffee;
        private System.Windows.Forms.Label lblRefillSugar;
        private System.Windows.Forms.TextBox txtRefillSugar;
        private System.Windows.Forms.Label lblRefillWater;
        private System.Windows.Forms.TextBox txtRefillWater;
        private System.Windows.Forms.Label lblRefillMilk;
        private System.Windows.Forms.TextBox txtRefillMilk;
        private System.Windows.Forms.Button btnRefill;

        /// <summary>
        /// Метод InitializeComponent, де налаштовуються всі UI елементи
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCompany = new System.Windows.Forms.GroupBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.lblEDRPOU = new System.Windows.Forms.Label();
            this.txtEDRPOU = new System.Windows.Forms.TextBox();
            this.btnCreateCompany = new System.Windows.Forms.Button();
            this.btnSaveCompany = new System.Windows.Forms.Button();
            this.btnLoadCompany = new System.Windows.Forms.Button();
            this.grpMachines = new System.Windows.Forms.GroupBox();
            this.lblSelectMachine = new System.Windows.Forms.Label();
            this.cmbMachines = new System.Windows.Forms.ComboBox();
            this.lblMachineDetails = new System.Windows.Forms.Label();
            this.txtMachineDetails = new System.Windows.Forms.TextBox();
            this.grpAddMachine = new System.Windows.Forms.GroupBox();
            this.lblAddPaperCups = new System.Windows.Forms.Label();
            this.txtAddPaperCups = new System.Windows.Forms.TextBox();
            this.lblAddStirrers = new System.Windows.Forms.Label();
            this.txtAddStirrers = new System.Windows.Forms.TextBox();
            this.lblAddStraws = new System.Windows.Forms.Label();
            this.txtAddStraws = new System.Windows.Forms.TextBox();
            this.lblAddCoffeePortions = new System.Windows.Forms.Label();
            this.txtAddCoffeePortions = new System.Windows.Forms.TextBox();
            this.lblAddWaterPortions = new System.Windows.Forms.Label();
            this.txtAddWaterPortions = new System.Windows.Forms.TextBox();
            this.lblAddMilkPortions = new System.Windows.Forms.Label();
            this.txtAddMilkPortions = new System.Windows.Forms.TextBox();
            this.lblAddSugarPortions = new System.Windows.Forms.Label();
            this.txtAddSugarPortions = new System.Windows.Forms.TextBox();
            this.chkAddAcceptsCard = new System.Windows.Forms.CheckBox();
            this.chkAddReturnsChange = new System.Windows.Forms.CheckBox();
            this.lblAddAddress = new System.Windows.Forms.Label();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.btnRemoveMachine = new System.Windows.Forms.Button();
            this.btnPrepareDrink = new System.Windows.Forms.Button();
            this.lblDrinkType = new System.Windows.Forms.Label();
            this.cmbDrinkType = new System.Windows.Forms.ComboBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpRefillResources = new System.Windows.Forms.GroupBox();
            this.lblRefillCoffee = new System.Windows.Forms.Label();
            this.txtRefillCoffee = new System.Windows.Forms.TextBox();
            this.lblRefillSugar = new System.Windows.Forms.Label();
            this.txtRefillSugar = new System.Windows.Forms.TextBox();
            this.lblRefillWater = new System.Windows.Forms.Label();
            this.txtRefillWater = new System.Windows.Forms.TextBox();
            this.lblRefillMilk = new System.Windows.Forms.Label();
            this.txtRefillMilk = new System.Windows.Forms.TextBox();
            this.btnRefill = new System.Windows.Forms.Button();
            this.grpCompany.SuspendLayout();
            this.grpMachines.SuspendLayout();
            this.grpAddMachine.SuspendLayout();
            this.grpOperations.SuspendLayout();
            this.grpRefillResources.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.lblCompanyName);
            this.grpCompany.Controls.Add(this.txtCompanyName);
            this.grpCompany.Controls.Add(this.lblCompanyAddress);
            this.grpCompany.Controls.Add(this.txtCompanyAddress);
            this.grpCompany.Controls.Add(this.lblEDRPOU);
            this.grpCompany.Controls.Add(this.txtEDRPOU);
            this.grpCompany.Controls.Add(this.btnCreateCompany);
            this.grpCompany.Controls.Add(this.btnSaveCompany);
            this.grpCompany.Controls.Add(this.btnLoadCompany);
            this.grpCompany.Location = new System.Drawing.Point(12, 12);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(450, 150);
            this.grpCompany.TabIndex = 0;
            this.grpCompany.TabStop = false;
            this.grpCompany.Text = "Кавова компанія";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(10, 25);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(88, 13);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Назва компанії:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(130, 22);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(300, 20);
            this.txtCompanyName.TabIndex = 1;
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Location = new System.Drawing.Point(10, 55);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(93, 13);
            this.lblCompanyAddress.TabIndex = 2;
            this.lblCompanyAddress.Text = "Адреса компанії:";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(130, 52);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(300, 20);
            this.txtCompanyAddress.TabIndex = 3;
            // 
            // lblEDRPOU
            // 
            this.lblEDRPOU.AutoSize = true;
            this.lblEDRPOU.Location = new System.Drawing.Point(10, 85);
            this.lblEDRPOU.Name = "lblEDRPOU";
            this.lblEDRPOU.Size = new System.Drawing.Size(79, 13);
            this.lblEDRPOU.TabIndex = 4;
            this.lblEDRPOU.Text = "Код ЄДРПОУ:";
            // 
            // txtEDRPOU
            // 
            this.txtEDRPOU.Location = new System.Drawing.Point(130, 82);
            this.txtEDRPOU.Name = "txtEDRPOU";
            this.txtEDRPOU.Size = new System.Drawing.Size(150, 20);
            this.txtEDRPOU.TabIndex = 5;
            // 
            // btnCreateCompany
            // 
            this.btnCreateCompany.Location = new System.Drawing.Point(10, 120);
            this.btnCreateCompany.Name = "btnCreateCompany";
            this.btnCreateCompany.Size = new System.Drawing.Size(130, 23);
            this.btnCreateCompany.TabIndex = 6;
            this.btnCreateCompany.Text = "Створити компанію";
            this.btnCreateCompany.UseVisualStyleBackColor = true;
            this.btnCreateCompany.Click += new System.EventHandler(this.btnCreateCompany_Click);
            // 
            // btnSaveCompany
            // 
            this.btnSaveCompany.Location = new System.Drawing.Point(160, 120);
            this.btnSaveCompany.Name = "btnSaveCompany";
            this.btnSaveCompany.Size = new System.Drawing.Size(130, 23);
            this.btnSaveCompany.TabIndex = 7;
            this.btnSaveCompany.Text = "Зберегти дані";
            this.btnSaveCompany.UseVisualStyleBackColor = true;
            this.btnSaveCompany.Click += new System.EventHandler(this.btnSaveCompany_Click);
            // 
            // btnLoadCompany
            // 
            this.btnLoadCompany.Location = new System.Drawing.Point(310, 120);
            this.btnLoadCompany.Name = "btnLoadCompany";
            this.btnLoadCompany.Size = new System.Drawing.Size(120, 23);
            this.btnLoadCompany.TabIndex = 8;
            this.btnLoadCompany.Text = "Завантажити";
            this.btnLoadCompany.UseVisualStyleBackColor = true;
            this.btnLoadCompany.Click += new System.EventHandler(this.btnLoadCompany_Click);
            // 
            // grpMachines
            // 
            this.grpMachines.Controls.Add(this.lblSelectMachine);
            this.grpMachines.Controls.Add(this.cmbMachines);
            this.grpMachines.Controls.Add(this.lblMachineDetails);
            this.grpMachines.Controls.Add(this.txtMachineDetails);
            this.grpMachines.Location = new System.Drawing.Point(12, 180);
            this.grpMachines.Name = "grpMachines";
            this.grpMachines.Size = new System.Drawing.Size(450, 300);
            this.grpMachines.TabIndex = 1;
            this.grpMachines.TabStop = false;
            this.grpMachines.Text = "Кавові автомати компанії";
            // 
            // lblSelectMachine
            // 
            this.lblSelectMachine.AutoSize = true;
            this.lblSelectMachine.Location = new System.Drawing.Point(10, 25);
            this.lblSelectMachine.Name = "lblSelectMachine";
            this.lblSelectMachine.Size = new System.Drawing.Size(144, 13);
            this.lblSelectMachine.TabIndex = 0;
            this.lblSelectMachine.Text = "Виберіть кавовий автомат:";
            // 
            // cmbMachines
            // 
            this.cmbMachines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachines.FormattingEnabled = true;
            this.cmbMachines.Location = new System.Drawing.Point(160, 22);
            this.cmbMachines.Name = "cmbMachines";
            this.cmbMachines.Size = new System.Drawing.Size(280, 21);
            this.cmbMachines.TabIndex = 1;
            this.cmbMachines.SelectedIndexChanged += new System.EventHandler(this.cmbMachines_SelectedIndexChanged);
            // 
            // lblMachineDetails
            // 
            this.lblMachineDetails.AutoSize = true;
            this.lblMachineDetails.Location = new System.Drawing.Point(10, 60);
            this.lblMachineDetails.Name = "lblMachineDetails";
            this.lblMachineDetails.Size = new System.Drawing.Size(95, 13);
            this.lblMachineDetails.TabIndex = 2;
            this.lblMachineDetails.Text = "Деталі автомата:";
            // 
            // txtMachineDetails
            // 
            this.txtMachineDetails.Location = new System.Drawing.Point(10, 80);
            this.txtMachineDetails.Multiline = true;
            this.txtMachineDetails.Name = "txtMachineDetails";
            this.txtMachineDetails.ReadOnly = true;
            this.txtMachineDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMachineDetails.Size = new System.Drawing.Size(420, 200);
            this.txtMachineDetails.TabIndex = 3;
            // 
            // grpAddMachine
            // 
            this.grpAddMachine.Controls.Add(this.btnRemoveMachine);
            this.grpAddMachine.Controls.Add(this.lblAddPaperCups);
            this.grpAddMachine.Controls.Add(this.txtAddPaperCups);
            this.grpAddMachine.Controls.Add(this.lblAddStirrers);
            this.grpAddMachine.Controls.Add(this.txtAddStirrers);
            this.grpAddMachine.Controls.Add(this.lblAddStraws);
            this.grpAddMachine.Controls.Add(this.txtAddStraws);
            this.grpAddMachine.Controls.Add(this.lblAddCoffeePortions);
            this.grpAddMachine.Controls.Add(this.txtAddCoffeePortions);
            this.grpAddMachine.Controls.Add(this.lblAddWaterPortions);
            this.grpAddMachine.Controls.Add(this.txtAddWaterPortions);
            this.grpAddMachine.Controls.Add(this.lblAddMilkPortions);
            this.grpAddMachine.Controls.Add(this.txtAddMilkPortions);
            this.grpAddMachine.Controls.Add(this.lblAddSugarPortions);
            this.grpAddMachine.Controls.Add(this.txtAddSugarPortions);
            this.grpAddMachine.Controls.Add(this.chkAddAcceptsCard);
            this.grpAddMachine.Controls.Add(this.chkAddReturnsChange);
            this.grpAddMachine.Controls.Add(this.lblAddAddress);
            this.grpAddMachine.Controls.Add(this.txtAddAddress);
            this.grpAddMachine.Controls.Add(this.btnAddMachine);
            this.grpAddMachine.Location = new System.Drawing.Point(480, 12);
            this.grpAddMachine.Name = "grpAddMachine";
            this.grpAddMachine.Size = new System.Drawing.Size(500, 324);
            this.grpAddMachine.TabIndex = 2;
            this.grpAddMachine.TabStop = false;
            this.grpAddMachine.Text = "Додавання нового кавового автомату";
            // 
            // lblAddPaperCups
            // 
            this.lblAddPaperCups.AutoSize = true;
            this.lblAddPaperCups.Location = new System.Drawing.Point(10, 25);
            this.lblAddPaperCups.Name = "lblAddPaperCups";
            this.lblAddPaperCups.Size = new System.Drawing.Size(100, 13);
            this.lblAddPaperCups.TabIndex = 0;
            this.lblAddPaperCups.Text = "Паперові стакани:";
            // 
            // txtAddPaperCups
            // 
            this.txtAddPaperCups.Location = new System.Drawing.Point(150, 22);
            this.txtAddPaperCups.Name = "txtAddPaperCups";
            this.txtAddPaperCups.Size = new System.Drawing.Size(100, 20);
            this.txtAddPaperCups.TabIndex = 1;
            this.txtAddPaperCups.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // lblAddStirrers
            // 
            this.lblAddStirrers.AutoSize = true;
            this.lblAddStirrers.Location = new System.Drawing.Point(10, 55);
            this.lblAddStirrers.Name = "lblAddStirrers";
            this.lblAddStirrers.Size = new System.Drawing.Size(105, 13);
            this.lblAddStirrers.TabIndex = 2;
            this.lblAddStirrers.Text = "Палички для цукру:";
            // 
            // txtAddStirrers
            // 
            this.txtAddStirrers.Location = new System.Drawing.Point(150, 52);
            this.txtAddStirrers.Name = "txtAddStirrers";
            this.txtAddStirrers.Size = new System.Drawing.Size(100, 20);
            this.txtAddStirrers.TabIndex = 3;
            this.txtAddStirrers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // lblAddStraws
            // 
            this.lblAddStraws.AutoSize = true;
            this.lblAddStraws.Location = new System.Drawing.Point(10, 85);
            this.lblAddStraws.Name = "lblAddStraws";
            this.lblAddStraws.Size = new System.Drawing.Size(57, 13);
            this.lblAddStraws.TabIndex = 4;
            this.lblAddStraws.Text = "Трубочки:";
            // 
            // txtAddStraws
            // 
            this.txtAddStraws.Location = new System.Drawing.Point(150, 82);
            this.txtAddStraws.Name = "txtAddStraws";
            this.txtAddStraws.Size = new System.Drawing.Size(100, 20);
            this.txtAddStraws.TabIndex = 5;
            this.txtAddStraws.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // lblAddCoffeePortions
            // 
            this.lblAddCoffeePortions.AutoSize = true;
            this.lblAddCoffeePortions.Location = new System.Drawing.Point(10, 115);
            this.lblAddCoffeePortions.Name = "lblAddCoffeePortions";
            this.lblAddCoffeePortions.Size = new System.Drawing.Size(68, 13);
            this.lblAddCoffeePortions.TabIndex = 6;
            this.lblAddCoffeePortions.Text = "Порції кави:";
            // 
            // txtAddCoffeePortions
            // 
            this.txtAddCoffeePortions.Location = new System.Drawing.Point(150, 112);
            this.txtAddCoffeePortions.Name = "txtAddCoffeePortions";
            this.txtAddCoffeePortions.Size = new System.Drawing.Size(100, 20);
            this.txtAddCoffeePortions.TabIndex = 7;
            this.txtAddCoffeePortions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // lblAddWaterPortions
            // 
            this.lblAddWaterPortions.AutoSize = true;
            this.lblAddWaterPortions.Location = new System.Drawing.Point(10, 145);
            this.lblAddWaterPortions.Name = "lblAddWaterPortions";
            this.lblAddWaterPortions.Size = new System.Drawing.Size(68, 13);
            this.lblAddWaterPortions.TabIndex = 8;
            this.lblAddWaterPortions.Text = "Порції води:";
            // 
            // txtAddWaterPortions
            // 
            this.txtAddWaterPortions.Location = new System.Drawing.Point(150, 142);
            this.txtAddWaterPortions.Name = "txtAddWaterPortions";
            this.txtAddWaterPortions.Size = new System.Drawing.Size(100, 20);
            this.txtAddWaterPortions.TabIndex = 9;
            this.txtAddWaterPortions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // lblAddMilkPortions
            // 
            this.lblAddMilkPortions.AutoSize = true;
            this.lblAddMilkPortions.Location = new System.Drawing.Point(10, 175);
            this.lblAddMilkPortions.Name = "lblAddMilkPortions";
            this.lblAddMilkPortions.Size = new System.Drawing.Size(82, 13);
            this.lblAddMilkPortions.TabIndex = 10;
            this.lblAddMilkPortions.Text = "Порції молока:";
            // 
            // txtAddMilkPortions
            // 
            this.txtAddMilkPortions.Location = new System.Drawing.Point(150, 172);
            this.txtAddMilkPortions.Name = "txtAddMilkPortions";
            this.txtAddMilkPortions.Size = new System.Drawing.Size(100, 20);
            this.txtAddMilkPortions.TabIndex = 11;
            this.txtAddMilkPortions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // lblAddSugarPortions
            // 
            this.lblAddSugarPortions.AutoSize = true;
            this.lblAddSugarPortions.Location = new System.Drawing.Point(10, 205);
            this.lblAddSugarPortions.Name = "lblAddSugarPortions";
            this.lblAddSugarPortions.Size = new System.Drawing.Size(72, 13);
            this.lblAddSugarPortions.TabIndex = 12;
            this.lblAddSugarPortions.Text = "Порції цукру:";
            // 
            // txtAddSugarPortions
            // 
            this.txtAddSugarPortions.Location = new System.Drawing.Point(150, 202);
            this.txtAddSugarPortions.Name = "txtAddSugarPortions";
            this.txtAddSugarPortions.Size = new System.Drawing.Size(100, 20);
            this.txtAddSugarPortions.TabIndex = 13;
            this.txtAddSugarPortions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // chkAddAcceptsCard
            // 
            this.chkAddAcceptsCard.AutoSize = true;
            this.chkAddAcceptsCard.Location = new System.Drawing.Point(10, 235);
            this.chkAddAcceptsCard.Name = "chkAddAcceptsCard";
            this.chkAddAcceptsCard.Size = new System.Drawing.Size(110, 17);
            this.chkAddAcceptsCard.TabIndex = 14;
            this.chkAddAcceptsCard.Text = "Приймає картки";
            this.chkAddAcceptsCard.UseVisualStyleBackColor = true;
            // 
            // chkAddReturnsChange
            // 
            this.chkAddReturnsChange.AutoSize = true;
            this.chkAddReturnsChange.Location = new System.Drawing.Point(150, 235);
            this.chkAddReturnsChange.Name = "chkAddReturnsChange";
            this.chkAddReturnsChange.Size = new System.Drawing.Size(90, 17);
            this.chkAddReturnsChange.TabIndex = 15;
            this.chkAddReturnsChange.Text = "Видає решту";
            this.chkAddReturnsChange.UseVisualStyleBackColor = true;
            // 
            // lblAddAddress
            // 
            this.lblAddAddress.AutoSize = true;
            this.lblAddAddress.Location = new System.Drawing.Point(10, 265);
            this.lblAddAddress.Name = "lblAddAddress";
            this.lblAddAddress.Size = new System.Drawing.Size(47, 13);
            this.lblAddAddress.TabIndex = 16;
            this.lblAddAddress.Text = "Адреса:";
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Location = new System.Drawing.Point(150, 262);
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(171, 20);
            this.txtAddAddress.TabIndex = 17;
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.Location = new System.Drawing.Point(150, 290);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(100, 23);
            this.btnAddMachine.TabIndex = 18;
            this.btnAddMachine.Text = "Додати автомат";
            this.btnAddMachine.UseVisualStyleBackColor = true;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.btnPrepareDrink);
            this.grpOperations.Controls.Add(this.lblDrinkType);
            this.grpOperations.Controls.Add(this.cmbDrinkType);
            this.grpOperations.Controls.Add(this.lblPaymentType);
            this.grpOperations.Controls.Add(this.cmbPaymentType);
            this.grpOperations.Controls.Add(this.lblAmountPaid);
            this.grpOperations.Controls.Add(this.txtAmountPaid);
            this.grpOperations.Controls.Add(this.txtOutput);
            this.grpOperations.Location = new System.Drawing.Point(12, 503);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(968, 237);
            this.grpOperations.TabIndex = 3;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Операції";
            // 
            // btnRemoveMachine
            // 
            this.btnRemoveMachine.Location = new System.Drawing.Point(361, 290);
            this.btnRemoveMachine.Name = "btnRemoveMachine";
            this.btnRemoveMachine.Size = new System.Drawing.Size(133, 23);
            this.btnRemoveMachine.TabIndex = 0;
            this.btnRemoveMachine.Text = "Видалити автомат";
            this.btnRemoveMachine.UseVisualStyleBackColor = true;
            this.btnRemoveMachine.Click += new System.EventHandler(this.btnRemoveMachine_Click);
            // 
            // btnPrepareDrink
            // 
            this.btnPrepareDrink.Location = new System.Drawing.Point(13, 19);
            this.btnPrepareDrink.Name = "btnPrepareDrink";
            this.btnPrepareDrink.Size = new System.Drawing.Size(186, 47);
            this.btnPrepareDrink.TabIndex = 2;
            this.btnPrepareDrink.Text = "Приготувати";
            this.btnPrepareDrink.UseVisualStyleBackColor = true;
            this.btnPrepareDrink.Click += new System.EventHandler(this.btnPrepareDrink_Click);
            // 
            // lblDrinkType
            // 
            this.lblDrinkType.AutoSize = true;
            this.lblDrinkType.Location = new System.Drawing.Point(8, 86);
            this.lblDrinkType.Name = "lblDrinkType";
            this.lblDrinkType.Size = new System.Drawing.Size(64, 13);
            this.lblDrinkType.TabIndex = 3;
            this.lblDrinkType.Text = "Тип напою:";
            // 
            // cmbDrinkType
            // 
            this.cmbDrinkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrinkType.FormattingEnabled = true;
            this.cmbDrinkType.Location = new System.Drawing.Point(78, 83);
            this.cmbDrinkType.Name = "cmbDrinkType";
            this.cmbDrinkType.Size = new System.Drawing.Size(121, 21);
            this.cmbDrinkType.TabIndex = 4;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(218, 86);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(67, 13);
            this.lblPaymentType.TabIndex = 5;
            this.lblPaymentType.Text = "Тип оплати:";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(298, 83);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(121, 21);
            this.cmbPaymentType.TabIndex = 6;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(448, 86);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(74, 13);
            this.lblAmountPaid.TabIndex = 7;
            this.lblAmountPaid.Text = "Сума оплати:";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(528, 83);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(100, 20);
            this.txtAmountPaid.TabIndex = 8;
            this.txtAmountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBoxWithDecimal_KeyPress);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(8, 129);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(950, 102);
            this.txtOutput.TabIndex = 9;
            // 
            // grpRefillResources
            // 
            this.grpRefillResources.Controls.Add(this.lblRefillCoffee);
            this.grpRefillResources.Controls.Add(this.txtRefillCoffee);
            this.grpRefillResources.Controls.Add(this.lblRefillSugar);
            this.grpRefillResources.Controls.Add(this.txtRefillSugar);
            this.grpRefillResources.Controls.Add(this.lblRefillWater);
            this.grpRefillResources.Controls.Add(this.txtRefillWater);
            this.grpRefillResources.Controls.Add(this.lblRefillMilk);
            this.grpRefillResources.Controls.Add(this.txtRefillMilk);
            this.grpRefillResources.Controls.Add(this.btnRefill);
            this.grpRefillResources.Location = new System.Drawing.Point(480, 342);
            this.grpRefillResources.Name = "grpRefillResources";
            this.grpRefillResources.Size = new System.Drawing.Size(500, 173);
            this.grpRefillResources.TabIndex = 4;
            this.grpRefillResources.TabStop = false;
            this.grpRefillResources.Text = "Поповнення ресурсів";
            // 
            // lblRefillCoffee
            // 
            this.lblRefillCoffee.AutoSize = true;
            this.lblRefillCoffee.Location = new System.Drawing.Point(10, 25);
            this.lblRefillCoffee.Name = "lblRefillCoffee";
            this.lblRefillCoffee.Size = new System.Drawing.Size(35, 13);
            this.lblRefillCoffee.TabIndex = 0;
            this.lblRefillCoffee.Text = "Кава:";
            // 
            // txtRefillCoffee
            // 
            this.txtRefillCoffee.Location = new System.Drawing.Point(80, 22);
            this.txtRefillCoffee.Name = "txtRefillCoffee";
            this.txtRefillCoffee.Size = new System.Drawing.Size(100, 20);
            this.txtRefillCoffee.TabIndex = 1;
            this.txtRefillCoffee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // lblRefillSugar
            // 
            this.lblRefillSugar.AutoSize = true;
            this.lblRefillSugar.Location = new System.Drawing.Point(10, 55);
            this.lblRefillSugar.Name = "lblRefillSugar";
            this.lblRefillSugar.Size = new System.Drawing.Size(41, 13);
            this.lblRefillSugar.TabIndex = 2;
            this.lblRefillSugar.Text = "Цукор:";
            // 
            // txtRefillSugar
            // 
            this.txtRefillSugar.Location = new System.Drawing.Point(80, 52);
            this.txtRefillSugar.Name = "txtRefillSugar";
            this.txtRefillSugar.Size = new System.Drawing.Size(100, 20);
            this.txtRefillSugar.TabIndex = 3;
            this.txtRefillSugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // lblRefillWater
            // 
            this.lblRefillWater.AutoSize = true;
            this.lblRefillWater.Location = new System.Drawing.Point(204, 25);
            this.lblRefillWater.Name = "lblRefillWater";
            this.lblRefillWater.Size = new System.Drawing.Size(35, 13);
            this.lblRefillWater.TabIndex = 4;
            this.lblRefillWater.Text = "Вода:";
            // 
            // txtRefillWater
            // 
            this.txtRefillWater.Location = new System.Drawing.Point(274, 22);
            this.txtRefillWater.Name = "txtRefillWater";
            this.txtRefillWater.Size = new System.Drawing.Size(100, 20);
            this.txtRefillWater.TabIndex = 5;
            this.txtRefillWater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // lblRefillMilk
            // 
            this.lblRefillMilk.AutoSize = true;
            this.lblRefillMilk.Location = new System.Drawing.Point(204, 55);
            this.lblRefillMilk.Name = "lblRefillMilk";
            this.lblRefillMilk.Size = new System.Drawing.Size(49, 13);
            this.lblRefillMilk.TabIndex = 6;
            this.lblRefillMilk.Text = "Молоко:";
            // 
            // txtRefillMilk
            // 
            this.txtRefillMilk.Location = new System.Drawing.Point(274, 52);
            this.txtRefillMilk.Name = "txtRefillMilk";
            this.txtRefillMilk.Size = new System.Drawing.Size(100, 20);
            this.txtRefillMilk.TabIndex = 7;
            this.txtRefillMilk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(13, 100);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(137, 55);
            this.btnRefill.TabIndex = 8;
            this.btnRefill.Text = "Поповнити";
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(995, 752);
            this.Controls.Add(this.grpRefillResources);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.grpAddMachine);
            this.Controls.Add(this.grpMachines);
            this.Controls.Add(this.grpCompany);
            this.Name = "MainForm";
            this.Text = "Кавовий Автомат - Кавова Компанія";
            this.grpCompany.ResumeLayout(false);
            this.grpCompany.PerformLayout();
            this.grpMachines.ResumeLayout(false);
            this.grpMachines.PerformLayout();
            this.grpAddMachine.ResumeLayout(false);
            this.grpAddMachine.PerformLayout();
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.grpRefillResources.ResumeLayout(false);
            this.grpRefillResources.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
