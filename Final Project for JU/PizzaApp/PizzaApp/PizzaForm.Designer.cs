namespace PizzaApp
{
    partial class PizzaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPizza = new System.Windows.Forms.TabPage();
            this.lblPizzaTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBxVeggies = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmBxPizzaType = new System.Windows.Forms.ComboBox();
            this.btnClearSelections = new System.Windows.Forms.Button();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBxMeats = new System.Windows.Forms.CheckedListBox();
            this.cmBxSauce = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBxCrust = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBxSize = new System.Windows.Forms.ComboBox();
            this.tabSideItems = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBxSidesAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmBxSidesType = new System.Windows.Forms.ComboBox();
            this.btnAddSides = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmBxWingType = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAddWings = new System.Windows.Forms.Button();
            this.cmBxWingSauce = new System.Windows.Forms.ComboBox();
            this.cmBxWingAmount = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddBeverage = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBxBeverageAmount = new System.Windows.Forms.TextBox();
            this.cmBxBeverageSize = new System.Windows.Forms.ComboBox();
            this.cmBxBeverageType = new System.Windows.Forms.ComboBox();
            this.tabCheckout = new System.Windows.Forms.TabPage();
            this.txtBxSidesOrder = new System.Windows.Forms.TextBox();
            this.txtBxPizzaOrder = new System.Windows.Forms.TextBox();
            this.btnCheckoutClearSide = new System.Windows.Forms.Button();
            this.btnCheckoutAddSides = new System.Windows.Forms.Button();
            this.btnCheckoutClearPizza = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBtnWalkIn = new System.Windows.Forms.RadioButton();
            this.rdBtnDelivery = new System.Windows.Forms.RadioButton();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFinalizeOrder = new System.Windows.Forms.Button();
            this.btnCheckoutAddPizza = new System.Windows.Forms.Button();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.picBxLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCurrentOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCurrentTotal = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxHomeAddress = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lblGrandTotalContact = new System.Windows.Forms.Label();
            this.btnChangeOrder = new System.Windows.Forms.Button();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPizza.SuspendLayout();
            this.tabSideItems.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabCheckout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPizza);
            this.tabControl1.Controls.Add(this.tabSideItems);
            this.tabControl1.Controls.Add(this.tabCheckout);
            this.tabControl1.Controls.Add(this.tabContact);
            this.tabControl1.Location = new System.Drawing.Point(12, 191);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 292);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPizza
            // 
            this.tabPizza.Controls.Add(this.lblPizzaTotal);
            this.tabPizza.Controls.Add(this.label8);
            this.tabPizza.Controls.Add(this.label6);
            this.tabPizza.Controls.Add(this.checkBxVeggies);
            this.tabPizza.Controls.Add(this.label5);
            this.tabPizza.Controls.Add(this.cmBxPizzaType);
            this.tabPizza.Controls.Add(this.btnClearSelections);
            this.tabPizza.Controls.Add(this.btnAddPizza);
            this.tabPizza.Controls.Add(this.label4);
            this.tabPizza.Controls.Add(this.checkBxMeats);
            this.tabPizza.Controls.Add(this.cmBxSauce);
            this.tabPizza.Controls.Add(this.label3);
            this.tabPizza.Controls.Add(this.cmBxCrust);
            this.tabPizza.Controls.Add(this.label2);
            this.tabPizza.Controls.Add(this.label1);
            this.tabPizza.Controls.Add(this.cmBxSize);
            this.tabPizza.Location = new System.Drawing.Point(4, 25);
            this.tabPizza.Name = "tabPizza";
            this.tabPizza.Padding = new System.Windows.Forms.Padding(3);
            this.tabPizza.Size = new System.Drawing.Size(611, 263);
            this.tabPizza.TabIndex = 0;
            this.tabPizza.Text = "Pizza";
            this.tabPizza.UseVisualStyleBackColor = true;
            // 
            // lblPizzaTotal
            // 
            this.lblPizzaTotal.AutoSize = true;
            this.lblPizzaTotal.Location = new System.Drawing.Point(419, 228);
            this.lblPizzaTotal.Name = "lblPizzaTotal";
            this.lblPizzaTotal.Size = new System.Drawing.Size(36, 17);
            this.lblPizzaTotal.TabIndex = 15;
            this.lblPizzaTotal.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pizza Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Veggies ($1.00 Each)";
            // 
            // checkBxVeggies
            // 
            this.checkBxVeggies.CheckOnClick = true;
            this.checkBxVeggies.FormattingEnabled = true;
            this.checkBxVeggies.Items.AddRange(new object[] {
            "Cheese",
            "Mushrooms",
            "Spinach",
            "Cherry Peppers",
            "Red Onions",
            "Black Olives",
            "Green Bell Peppers",
            "Sliced Banana Peppers",
            "Pineapple",
            "Sliced Jalapenos",
            "Diced Tomatoes"});
            this.checkBxVeggies.Location = new System.Drawing.Point(422, 39);
            this.checkBxVeggies.Name = "checkBxVeggies";
            this.checkBxVeggies.Size = new System.Drawing.Size(170, 140);
            this.checkBxVeggies.TabIndex = 12;
            this.checkBxVeggies.SelectedIndexChanged += new System.EventHandler(this.checkBxVeggies_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type of Pizza";
            // 
            // cmBxPizzaType
            // 
            this.cmBxPizzaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxPizzaType.FormattingEnabled = true;
            this.cmBxPizzaType.Items.AddRange(new object[] {
            "Custom",
            "Pepperoni",
            "Cheese",
            "Hawaiian",
            "Chicken Bacon Parmesean",
            "Meat Lovers",
            "Veggie Lovers",
            "The Works",
            "Pepper Madness",
            "Super Surpreme"});
            this.cmBxPizzaType.Location = new System.Drawing.Point(20, 39);
            this.cmBxPizzaType.Name = "cmBxPizzaType";
            this.cmBxPizzaType.Size = new System.Drawing.Size(196, 24);
            this.cmBxPizzaType.TabIndex = 10;
            this.cmBxPizzaType.SelectedIndexChanged += new System.EventHandler(this.cmBxPizzaType_SelectedIndexChanged);
            // 
            // btnClearSelections
            // 
            this.btnClearSelections.Location = new System.Drawing.Point(437, 190);
            this.btnClearSelections.Name = "btnClearSelections";
            this.btnClearSelections.Size = new System.Drawing.Size(137, 24);
            this.btnClearSelections.TabIndex = 9;
            this.btnClearSelections.Text = "Clear Selections";
            this.btnClearSelections.UseVisualStyleBackColor = true;
            this.btnClearSelections.Click += new System.EventHandler(this.btnClearSelections_Click);
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Location = new System.Drawing.Point(256, 190);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(122, 24);
            this.btnAddPizza.TabIndex = 8;
            this.btnAddPizza.Text = "Add Pizza";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Meats ($1.00 Each)";
            // 
            // checkBxMeats
            // 
            this.checkBxMeats.CheckOnClick = true;
            this.checkBxMeats.FormattingEnabled = true;
            this.checkBxMeats.Items.AddRange(new object[] {
            "Pepperoni",
            "Sausage",
            "Salami",
            "Meatball",
            "Ham",
            "Bacon",
            "Grilled Chicken",
            "Beef",
            "Pork"});
            this.checkBxMeats.Location = new System.Drawing.Point(233, 39);
            this.checkBxMeats.Name = "checkBxMeats";
            this.checkBxMeats.Size = new System.Drawing.Size(170, 140);
            this.checkBxMeats.TabIndex = 6;
            this.checkBxMeats.SelectedIndexChanged += new System.EventHandler(this.checkBxMeats_SelectedIndexChanged);
            // 
            // cmBxSauce
            // 
            this.cmBxSauce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxSauce.FormattingEnabled = true;
            this.cmBxSauce.Items.AddRange(new object[] {
            "Classic Marinara",
            "Garlic Parmesean",
            "No Sauce"});
            this.cmBxSauce.Location = new System.Drawing.Point(20, 211);
            this.cmBxSauce.Name = "cmBxSauce";
            this.cmBxSauce.Size = new System.Drawing.Size(196, 24);
            this.cmBxSauce.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sauce";
            // 
            // cmBxCrust
            // 
            this.cmBxCrust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxCrust.FormattingEnabled = true;
            this.cmBxCrust.Items.AddRange(new object[] {
            "Pan Pizza",
            "Hand-Tossed",
            "Thin and Crispy",
            "Stuffed Crust ($2.00)"});
            this.cmBxCrust.Location = new System.Drawing.Point(20, 153);
            this.cmBxCrust.Name = "cmBxCrust";
            this.cmBxCrust.Size = new System.Drawing.Size(196, 24);
            this.cmBxCrust.TabIndex = 3;
            this.cmBxCrust.SelectedIndexChanged += new System.EventHandler(this.cmBxCrust_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crust";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // cmBxSize
            // 
            this.cmBxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxSize.FormattingEnabled = true;
            this.cmBxSize.Items.AddRange(new object[] {
            "Personal ($.50 Tops)",
            "Medium ",
            "Large ",
            "X Large ($1.50 Tops)"});
            this.cmBxSize.Location = new System.Drawing.Point(20, 96);
            this.cmBxSize.Name = "cmBxSize";
            this.cmBxSize.Size = new System.Drawing.Size(196, 24);
            this.cmBxSize.TabIndex = 0;
            this.cmBxSize.SelectedIndexChanged += new System.EventHandler(this.cmBxSize_SelectedIndexChanged);
            // 
            // tabSideItems
            // 
            this.tabSideItems.Controls.Add(this.groupBox3);
            this.tabSideItems.Controls.Add(this.groupBox2);
            this.tabSideItems.Controls.Add(this.groupBox1);
            this.tabSideItems.Location = new System.Drawing.Point(4, 25);
            this.tabSideItems.Name = "tabSideItems";
            this.tabSideItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabSideItems.Size = new System.Drawing.Size(611, 263);
            this.tabSideItems.TabIndex = 1;
            this.tabSideItems.Text = "Side Items";
            this.tabSideItems.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBxSidesAmount);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cmBxSidesType);
            this.groupBox3.Controls.Add(this.btnAddSides);
            this.groupBox3.Location = new System.Drawing.Point(405, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 251);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // txtBxSidesAmount
            // 
            this.txtBxSidesAmount.Location = new System.Drawing.Point(53, 169);
            this.txtBxSidesAmount.Name = "txtBxSidesAmount";
            this.txtBxSidesAmount.Size = new System.Drawing.Size(100, 22);
            this.txtBxSidesAmount.TabIndex = 14;
            this.txtBxSidesAmount.Text = "Quantity...";
            this.txtBxSidesAmount.MouseHover += new System.EventHandler(this.txtBxSidesAmount_MouseHover);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Sides";
            // 
            // cmBxSidesType
            // 
            this.cmBxSidesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxSidesType.FormattingEnabled = true;
            this.cmBxSidesType.Items.AddRange(new object[] {
            "Breadsticks ($4.29)",
            "Cheese Sticks ($5.29)",
            "Hot Breadsticks ($4.29)",
            "Fries ($3.49)",
            "Cajun Fries ($3.49)",
            "Mozzarella Sticks ($4.49)"});
            this.cmBxSidesType.Location = new System.Drawing.Point(20, 51);
            this.cmBxSidesType.Name = "cmBxSidesType";
            this.cmBxSidesType.Size = new System.Drawing.Size(169, 24);
            this.cmBxSidesType.TabIndex = 23;
            // 
            // btnAddSides
            // 
            this.btnAddSides.Location = new System.Drawing.Point(13, 208);
            this.btnAddSides.Name = "btnAddSides";
            this.btnAddSides.Size = new System.Drawing.Size(176, 31);
            this.btnAddSides.TabIndex = 11;
            this.btnAddSides.Text = "Add...";
            this.btnAddSides.UseVisualStyleBackColor = true;
            this.btnAddSides.Click += new System.EventHandler(this.btnAddSides_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmBxWingType);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnAddWings);
            this.groupBox2.Controls.Add(this.cmBxWingSauce);
            this.groupBox2.Controls.Add(this.cmBxWingAmount);
            this.groupBox2.Location = new System.Drawing.Point(201, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 251);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // cmBxWingType
            // 
            this.cmBxWingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxWingType.FormattingEnabled = true;
            this.cmBxWingType.Items.AddRange(new object[] {
            "Traditional",
            "Breaded Boneless",
            "Boneless"});
            this.cmBxWingType.Location = new System.Drawing.Point(12, 51);
            this.cmBxWingType.Name = "cmBxWingType";
            this.cmBxWingType.Size = new System.Drawing.Size(169, 24);
            this.cmBxWingType.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(65, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 17);
            this.label19.TabIndex = 26;
            this.label19.Text = "Sauces";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Wings";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(65, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Quantity";
            // 
            // btnAddWings
            // 
            this.btnAddWings.Location = new System.Drawing.Point(12, 208);
            this.btnAddWings.Name = "btnAddWings";
            this.btnAddWings.Size = new System.Drawing.Size(169, 31);
            this.btnAddWings.TabIndex = 10;
            this.btnAddWings.Text = "Add...";
            this.btnAddWings.UseVisualStyleBackColor = true;
            this.btnAddWings.Click += new System.EventHandler(this.btnAddWings_Click);
            // 
            // cmBxWingSauce
            // 
            this.cmBxWingSauce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxWingSauce.FormattingEnabled = true;
            this.cmBxWingSauce.Items.AddRange(new object[] {
            "Traditional BBQ",
            "Garlic Parmesan",
            "Honey BBQ",
            "Buffalo Mild",
            "Buffalo Medium",
            "Buffalo Screamers",
            "Naked"});
            this.cmBxWingSauce.Location = new System.Drawing.Point(12, 112);
            this.cmBxWingSauce.Name = "cmBxWingSauce";
            this.cmBxWingSauce.Size = new System.Drawing.Size(169, 24);
            this.cmBxWingSauce.TabIndex = 21;
            // 
            // cmBxWingAmount
            // 
            this.cmBxWingAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxWingAmount.FormattingEnabled = true;
            this.cmBxWingAmount.Items.AddRange(new object[] {
            "6 Piece ($6.99)",
            "12 Piece ($13.49)",
            "18 Piece ($18.99)",
            "36 Piece ($37.98)"});
            this.cmBxWingAmount.Location = new System.Drawing.Point(12, 169);
            this.cmBxWingAmount.Name = "cmBxWingAmount";
            this.cmBxWingAmount.Size = new System.Drawing.Size(169, 24);
            this.cmBxWingAmount.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddBeverage);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtBxBeverageAmount);
            this.groupBox1.Controls.Add(this.cmBxBeverageSize);
            this.groupBox1.Controls.Add(this.cmBxBeverageType);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 251);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // btnAddBeverage
            // 
            this.btnAddBeverage.Location = new System.Drawing.Point(6, 208);
            this.btnAddBeverage.Name = "btnAddBeverage";
            this.btnAddBeverage.Size = new System.Drawing.Size(169, 31);
            this.btnAddBeverage.TabIndex = 9;
            this.btnAddBeverage.Text = "Add...";
            this.btnAddBeverage.UseVisualStyleBackColor = true;
            this.btnAddBeverage.Click += new System.EventHandler(this.btnAddBeverage_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Beverages";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(67, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 17);
            this.label18.TabIndex = 25;
            this.label18.Text = "Sizes";
            // 
            // txtBxBeverageAmount
            // 
            this.txtBxBeverageAmount.Location = new System.Drawing.Point(46, 169);
            this.txtBxBeverageAmount.Name = "txtBxBeverageAmount";
            this.txtBxBeverageAmount.Size = new System.Drawing.Size(91, 22);
            this.txtBxBeverageAmount.TabIndex = 12;
            this.txtBxBeverageAmount.Text = "Quantity...";
            this.txtBxBeverageAmount.MouseHover += new System.EventHandler(this.txtBxBeverageAmount_MouseHover);
            // 
            // cmBxBeverageSize
            // 
            this.cmBxBeverageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxBeverageSize.FormattingEnabled = true;
            this.cmBxBeverageSize.Items.AddRange(new object[] {
            "20 oz Bottle ($1.79)",
            "Two Liter Bottle ($2.99)"});
            this.cmBxBeverageSize.Location = new System.Drawing.Point(6, 112);
            this.cmBxBeverageSize.Name = "cmBxBeverageSize";
            this.cmBxBeverageSize.Size = new System.Drawing.Size(169, 24);
            this.cmBxBeverageSize.TabIndex = 18;
            // 
            // cmBxBeverageType
            // 
            this.cmBxBeverageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxBeverageType.FormattingEnabled = true;
            this.cmBxBeverageType.Items.AddRange(new object[] {
            "Pepsi",
            "Diet Pepsi",
            "Mountain Dew",
            "Diet Mtn Dew",
            "Orange Crush",
            "Grape Crush",
            "Sierra Mist",
            "Dr. Pepper",
            "Diet Dr. Pepper",
            "Root Beer",
            "Water"});
            this.cmBxBeverageType.Location = new System.Drawing.Point(6, 51);
            this.cmBxBeverageType.Name = "cmBxBeverageType";
            this.cmBxBeverageType.Size = new System.Drawing.Size(169, 24);
            this.cmBxBeverageType.TabIndex = 19;
            // 
            // tabCheckout
            // 
            this.tabCheckout.Controls.Add(this.txtBxSidesOrder);
            this.tabCheckout.Controls.Add(this.txtBxPizzaOrder);
            this.tabCheckout.Controls.Add(this.btnCheckoutClearSide);
            this.tabCheckout.Controls.Add(this.btnCheckoutAddSides);
            this.tabCheckout.Controls.Add(this.btnCheckoutClearPizza);
            this.tabCheckout.Controls.Add(this.panel1);
            this.tabCheckout.Controls.Add(this.lblGrandTotal);
            this.tabCheckout.Controls.Add(this.lblTaxAmount);
            this.tabCheckout.Controls.Add(this.lblTipAmount);
            this.tabCheckout.Controls.Add(this.label16);
            this.tabCheckout.Controls.Add(this.label15);
            this.tabCheckout.Controls.Add(this.label14);
            this.tabCheckout.Controls.Add(this.label13);
            this.tabCheckout.Controls.Add(this.label9);
            this.tabCheckout.Controls.Add(this.btnFinalizeOrder);
            this.tabCheckout.Controls.Add(this.btnCheckoutAddPizza);
            this.tabCheckout.Location = new System.Drawing.Point(4, 25);
            this.tabCheckout.Name = "tabCheckout";
            this.tabCheckout.Size = new System.Drawing.Size(611, 263);
            this.tabCheckout.TabIndex = 3;
            this.tabCheckout.Text = "Checkout";
            this.tabCheckout.UseVisualStyleBackColor = true;
            // 
            // txtBxSidesOrder
            // 
            this.txtBxSidesOrder.Location = new System.Drawing.Point(218, 29);
            this.txtBxSidesOrder.Multiline = true;
            this.txtBxSidesOrder.Name = "txtBxSidesOrder";
            this.txtBxSidesOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxSidesOrder.Size = new System.Drawing.Size(200, 101);
            this.txtBxSidesOrder.TabIndex = 19;
            // 
            // txtBxPizzaOrder
            // 
            this.txtBxPizzaOrder.Location = new System.Drawing.Point(12, 30);
            this.txtBxPizzaOrder.Multiline = true;
            this.txtBxPizzaOrder.Name = "txtBxPizzaOrder";
            this.txtBxPizzaOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxPizzaOrder.Size = new System.Drawing.Size(200, 100);
            this.txtBxPizzaOrder.TabIndex = 18;
            // 
            // btnCheckoutClearSide
            // 
            this.btnCheckoutClearSide.Location = new System.Drawing.Point(319, 136);
            this.btnCheckoutClearSide.Name = "btnCheckoutClearSide";
            this.btnCheckoutClearSide.Size = new System.Drawing.Size(99, 31);
            this.btnCheckoutClearSide.TabIndex = 17;
            this.btnCheckoutClearSide.Text = "Clear";
            this.btnCheckoutClearSide.UseVisualStyleBackColor = true;
            this.btnCheckoutClearSide.Click += new System.EventHandler(this.btnCheckoutRemoveSide_Click);
            // 
            // btnCheckoutAddSides
            // 
            this.btnCheckoutAddSides.Location = new System.Drawing.Point(218, 136);
            this.btnCheckoutAddSides.Name = "btnCheckoutAddSides";
            this.btnCheckoutAddSides.Size = new System.Drawing.Size(99, 31);
            this.btnCheckoutAddSides.TabIndex = 16;
            this.btnCheckoutAddSides.Text = "Add";
            this.btnCheckoutAddSides.UseVisualStyleBackColor = true;
            this.btnCheckoutAddSides.Click += new System.EventHandler(this.btnCheckoutAddSides_Click);
            // 
            // btnCheckoutClearPizza
            // 
            this.btnCheckoutClearPizza.Location = new System.Drawing.Point(113, 136);
            this.btnCheckoutClearPizza.Name = "btnCheckoutClearPizza";
            this.btnCheckoutClearPizza.Size = new System.Drawing.Size(99, 31);
            this.btnCheckoutClearPizza.TabIndex = 15;
            this.btnCheckoutClearPizza.Text = "Clear";
            this.btnCheckoutClearPizza.UseVisualStyleBackColor = true;
            this.btnCheckoutClearPizza.Click += new System.EventHandler(this.btnCheckoutRemovePizza_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdBtnWalkIn);
            this.panel1.Controls.Add(this.rdBtnDelivery);
            this.panel1.Location = new System.Drawing.Point(442, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 81);
            this.panel1.TabIndex = 14;
            // 
            // rdBtnWalkIn
            // 
            this.rdBtnWalkIn.AutoSize = true;
            this.rdBtnWalkIn.Location = new System.Drawing.Point(4, 34);
            this.rdBtnWalkIn.Name = "rdBtnWalkIn";
            this.rdBtnWalkIn.Size = new System.Drawing.Size(136, 21);
            this.rdBtnWalkIn.TabIndex = 1;
            this.rdBtnWalkIn.TabStop = true;
            this.rdBtnWalkIn.Text = "Walk-In (No Fee)";
            this.rdBtnWalkIn.UseVisualStyleBackColor = true;
            this.rdBtnWalkIn.CheckedChanged += new System.EventHandler(this.rdBtnWalkIn_CheckedChanged);
            // 
            // rdBtnDelivery
            // 
            this.rdBtnDelivery.AutoSize = true;
            this.rdBtnDelivery.Location = new System.Drawing.Point(4, 7);
            this.rdBtnDelivery.Name = "rdBtnDelivery";
            this.rdBtnDelivery.Size = new System.Drawing.Size(158, 21);
            this.rdBtnDelivery.TabIndex = 0;
            this.rdBtnDelivery.TabStop = true;
            this.rdBtnDelivery.Text = "Delivery ($2.00 Fee)";
            this.rdBtnDelivery.UseVisualStyleBackColor = true;
            this.rdBtnDelivery.CheckedChanged += new System.EventHandler(this.rdBtnDelivery_CheckedChanged);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(358, 202);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(44, 17);
            this.lblGrandTotal.TabIndex = 13;
            this.lblGrandTotal.Text = "$0.00";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Location = new System.Drawing.Point(146, 215);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(44, 17);
            this.lblTaxAmount.TabIndex = 12;
            this.lblTaxAmount.Text = "$0.00";
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.AutoSize = true;
            this.lblTipAmount.Location = new System.Drawing.Point(146, 190);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(44, 17);
            this.lblTipAmount.TabIndex = 11;
            this.lblTipAmount.Text = "$0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(249, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 17);
            this.label16.TabIndex = 10;
            this.label16.Text = "Grand Total:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Tax:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tip (15%):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(294, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Sides";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Pizzas";
            // 
            // btnFinalizeOrder
            // 
            this.btnFinalizeOrder.Location = new System.Drawing.Point(442, 195);
            this.btnFinalizeOrder.Name = "btnFinalizeOrder";
            this.btnFinalizeOrder.Size = new System.Drawing.Size(129, 31);
            this.btnFinalizeOrder.TabIndex = 3;
            this.btnFinalizeOrder.Text = "Finalize Order";
            this.btnFinalizeOrder.UseVisualStyleBackColor = true;
            this.btnFinalizeOrder.Click += new System.EventHandler(this.btnFinalizeOrder_Click);
            // 
            // btnCheckoutAddPizza
            // 
            this.btnCheckoutAddPizza.Location = new System.Drawing.Point(12, 136);
            this.btnCheckoutAddPizza.Name = "btnCheckoutAddPizza";
            this.btnCheckoutAddPizza.Size = new System.Drawing.Size(99, 31);
            this.btnCheckoutAddPizza.TabIndex = 2;
            this.btnCheckoutAddPizza.Text = "Add";
            this.btnCheckoutAddPizza.UseVisualStyleBackColor = true;
            this.btnCheckoutAddPizza.Click += new System.EventHandler(this.btnCheckoutAddPizza_Click);
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.btnFinishOrder);
            this.tabContact.Controls.Add(this.btnChangeOrder);
            this.tabContact.Controls.Add(this.lblGrandTotalContact);
            this.tabContact.Controls.Add(this.label24);
            this.tabContact.Controls.Add(this.txtBxHomeAddress);
            this.tabContact.Controls.Add(this.txtBxEmail);
            this.tabContact.Controls.Add(this.txtBxPhone);
            this.tabContact.Controls.Add(this.txtBxName);
            this.tabContact.Controls.Add(this.label23);
            this.tabContact.Controls.Add(this.label22);
            this.tabContact.Controls.Add(this.label21);
            this.tabContact.Controls.Add(this.label20);
            this.tabContact.Location = new System.Drawing.Point(4, 25);
            this.tabContact.Name = "tabContact";
            this.tabContact.Size = new System.Drawing.Size(611, 263);
            this.tabContact.TabIndex = 2;
            this.tabContact.Text = "Contact Info";
            // 
            // picBxLogo
            // 
            this.picBxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBxLogo.Image")));
            this.picBxLogo.Location = new System.Drawing.Point(16, 36);
            this.picBxLogo.Name = "picBxLogo";
            this.picBxLogo.Size = new System.Drawing.Size(619, 140);
            this.picBxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxLogo.TabIndex = 1;
            this.picBxLogo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.viewCurrentOrderToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.internetConnectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewCurrentOrderToolStripMenuItem
            // 
            this.viewCurrentOrderToolStripMenuItem.Name = "viewCurrentOrderToolStripMenuItem";
            this.viewCurrentOrderToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.viewCurrentOrderToolStripMenuItem.Text = "View Current Order";
            this.viewCurrentOrderToolStripMenuItem.Click += new System.EventHandler(this.viewCurrentOrderToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // internetConnectionToolStripMenuItem
            // 
            this.internetConnectionToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.internetConnectionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.internetConnectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internetConnectionToolStripMenuItem.Image")));
            this.internetConnectionToolStripMenuItem.Name = "internetConnectionToolStripMenuItem";
            this.internetConnectionToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.internetConnectionToolStripMenuItem.Text = "Internet Connection";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sub Total:";
            // 
            // lblCurrentTotal
            // 
            this.lblCurrentTotal.AutoSize = true;
            this.lblCurrentTotal.Location = new System.Drawing.Point(519, 171);
            this.lblCurrentTotal.Name = "lblCurrentTotal";
            this.lblCurrentTotal.Size = new System.Drawing.Size(44, 17);
            this.lblCurrentTotal.TabIndex = 4;
            this.lblCurrentTotal.Text = "$0.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "Name:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "Phone:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 17);
            this.label22.TabIndex = 2;
            this.label22.Text = "E-Mail:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 204);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 17);
            this.label23.TabIndex = 3;
            this.label23.Text = "Home Address:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(134, 20);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(208, 22);
            this.txtBxName.TabIndex = 4;
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Location = new System.Drawing.Point(134, 77);
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(208, 22);
            this.txtBxPhone.TabIndex = 5;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(134, 137);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(208, 22);
            this.txtBxEmail.TabIndex = 6;
            // 
            // txtBxHomeAddress
            // 
            this.txtBxHomeAddress.Location = new System.Drawing.Point(134, 201);
            this.txtBxHomeAddress.Name = "txtBxHomeAddress";
            this.txtBxHomeAddress.Size = new System.Drawing.Size(208, 22);
            this.txtBxHomeAddress.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(402, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 17);
            this.label24.TabIndex = 8;
            this.label24.Text = "Grand Total:";
            // 
            // lblGrandTotalContact
            // 
            this.lblGrandTotalContact.AutoSize = true;
            this.lblGrandTotalContact.Location = new System.Drawing.Point(503, 68);
            this.lblGrandTotalContact.Name = "lblGrandTotalContact";
            this.lblGrandTotalContact.Size = new System.Drawing.Size(44, 17);
            this.lblGrandTotalContact.TabIndex = 9;
            this.lblGrandTotalContact.Text = "$0.00";
            // 
            // btnChangeOrder
            // 
            this.btnChangeOrder.Location = new System.Drawing.Point(405, 126);
            this.btnChangeOrder.Name = "btnChangeOrder";
            this.btnChangeOrder.Size = new System.Drawing.Size(130, 31);
            this.btnChangeOrder.TabIndex = 10;
            this.btnChangeOrder.Text = "Change Order";
            this.btnChangeOrder.UseVisualStyleBackColor = true;
            this.btnChangeOrder.Click += new System.EventHandler(this.btnChangeOrder_Click);
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Location = new System.Drawing.Point(405, 197);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(130, 31);
            this.btnFinishOrder.TabIndex = 11;
            this.btnFinishOrder.Text = "Finish Order";
            this.btnFinishOrder.UseVisualStyleBackColor = true;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 495);
            this.Controls.Add(this.lblCurrentTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picBxLogo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PizzaForm";
            this.Text = "Zack\'s Pizza and Cafe";
            this.Load += new System.EventHandler(this.PizzaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPizza.ResumeLayout(false);
            this.tabPizza.PerformLayout();
            this.tabSideItems.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCheckout.ResumeLayout(false);
            this.tabCheckout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabContact.ResumeLayout(false);
            this.tabContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPizza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmBxPizzaType;
        private System.Windows.Forms.Button btnClearSelections;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkBxMeats;
        private System.Windows.Forms.ComboBox cmBxSauce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmBxCrust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBxSize;
        private System.Windows.Forms.TabPage tabSideItems;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.TabPage tabCheckout;
        private System.Windows.Forms.PictureBox picBxLogo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkBxVeggies;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewCurrentOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCurrentTotal;
        private System.Windows.Forms.Label lblPizzaTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmBxSidesType;
        private System.Windows.Forms.ComboBox cmBxWingAmount;
        private System.Windows.Forms.ComboBox cmBxWingSauce;
        private System.Windows.Forms.ComboBox cmBxWingType;
        private System.Windows.Forms.ComboBox cmBxBeverageType;
        private System.Windows.Forms.ComboBox cmBxBeverageSize;
        private System.Windows.Forms.TextBox txtBxSidesAmount;
        private System.Windows.Forms.TextBox txtBxBeverageAmount;
        private System.Windows.Forms.Button btnAddSides;
        private System.Windows.Forms.Button btnAddWings;
        private System.Windows.Forms.Button btnAddBeverage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnWalkIn;
        private System.Windows.Forms.RadioButton rdBtnDelivery;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblTipAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFinalizeOrder;
        private System.Windows.Forms.Button btnCheckoutAddPizza;
        private System.Windows.Forms.Button btnCheckoutClearSide;
        private System.Windows.Forms.Button btnCheckoutAddSides;
        private System.Windows.Forms.Button btnCheckoutClearPizza;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBxSidesOrder;
        private System.Windows.Forms.TextBox txtBxPizzaOrder;
        private System.Windows.Forms.ToolStripMenuItem internetConnectionToolStripMenuItem;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Button btnChangeOrder;
        private System.Windows.Forms.Label lblGrandTotalContact;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBxHomeAddress;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
    }
}

