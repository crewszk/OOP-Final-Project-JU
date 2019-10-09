/*-------------------------------------------------------------------
 * Name: Zackery Crews
 * Project: Final Project
 * Description: A pizza ordering application.
 *-------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace PizzaApp
{
    public partial class PizzaForm : Form
    {
        private double currentPizzaTotal;
        private double allPizzaTotal;
        private double allSideTotal;
        private double subTotal;
        private double taxAmount;
        private double tipAmount;
        private double grandTotal;

        EmailAddressAttribute email;

        private string pizzaOrder;
        private string sideOrder;

        int counterCrust,
            counterDelivery,
            counterPizzaOrder,
            counterSideOrder;
               
        public PizzaForm()
        {
            InitializeComponent();
        }

        private void PizzaForm_Load(object sender, EventArgs e)
        {
            string intro = "Welcome to Zack's Pizza and Cafe ordering application!\n\n" +
                           "Thank you for choosing us! We have the finest pies in all\n" +
                           "of Jacksonville. If you have any questions please contact\n" +
                           "us either by email, phone, or in person. Our contact info\n" +
                           "is under the about tab in the application.\n\n" + 
                           "Because of resource restrictions at our store, we ask that\n" +
                           "you keep all orders below 10 pizzas and 10 sides. This is\n" +
                           "the maximum we can process at a time. We are sorry for any\n" +
                           "inconvenience this will cause. Thank you!";


            txtBxBeverageAmount.Text = "Quantity...";
            txtBxSidesAmount.Text = "Quantity...";
            counterCrust = 0;
            counterDelivery = 0;
            counterPizzaOrder = 0;
            counterSideOrder = 0;
            pizzaOrder = "";
            sideOrder = "";

            cmBxSize.Enabled = false;
            cmBxCrust.Enabled = false;
            cmBxSauce.Enabled = false;
            checkBxMeats.Enabled = false;
            checkBxVeggies.Enabled = false;
            btnFinishOrder.Enabled = false;
            for (int i = 0; i < 9; i++)
            {
                checkBxMeats.SetItemChecked(i, false);
            }
            for (int i = 0; i < 11; i++)
            {
                checkBxVeggies.SetItemChecked(i, false);
            }
            checkBxVeggies.SetItemChecked(0, true);
            lblPizzaTotal.Text = string.Format("{0:C}", 0.00);
            currentPizzaTotal = 0;
            lblCurrentTotal.Text = string.Format("{0:C}", 0.00);
            subTotal = 0;
            lblTaxAmount.Text = string.Format("{0:C}", 0.00);
            taxAmount = 0;
            lblTipAmount.Text = string.Format("{0:C}", 0.00);
            tipAmount = 0;
            lblGrandTotal.Text = string.Format("{0:C}", 0.00);
            grandTotal = 0;
            allPizzaTotal = 0;
            allSideTotal = 0;
            rdBtnDelivery.Checked = false;
            rdBtnWalkIn.Checked = false;

            if (MessageBox.Show(intro, "Welcome!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Well do ya?", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    Application.Exit();
            }

            ChangeConnectionStatus();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Well do ya?", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                Application.Exit();
        }

        private void viewCurrentOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Zack's Pizza and Cafe was created in 2016 by Zackery Kyle Crews as\n" +
                           "a simple business to fulfill the requirements of his programming project." +
                           "\n\nOwner: Zackery Crews\nLocation: 2800 University Blvd.\n" +
                           "Phone: (904) 555 - 8888\nEmail: ZacksPizzaCS160@outlook.com";

            MessageBox.Show(about, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmBxPizzaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                checkBxMeats.SetItemChecked(i, false);
            }
            checkBxMeats.Enabled = false;
            for (int i = 0; i < 11; i++)
            {
                checkBxVeggies.SetItemChecked(i, false);
            }
            checkBxVeggies.Enabled = false;

            switch (cmBxPizzaType.SelectedIndex)
            {
                case 0:
                    checkBxVeggies.Enabled = true;
                    checkBxMeats.Enabled = true;
                    cmBxSize.Enabled = true;
                    cmBxCrust.Enabled = true;
                    cmBxSauce.Enabled = true;
                    SetSizePrices();
                    break;
                case 1:
                    checkBxVeggies.Enabled = true;
                    checkBxMeats.Enabled = true;

                    checkBxMeats.SetItemChecked(0, true);
                    checkBxVeggies.SetItemChecked(0, true);
                    cmBxSize.Enabled = true;
                    cmBxCrust.Enabled = true;
                    cmBxSauce.SelectedIndex = 0;
                    cmBxSauce.Enabled = true;
                    SetSizePrices();
                    break;
                case 2:
                    checkBxVeggies.Enabled = true;
                    checkBxMeats.Enabled = true;

                    checkBxVeggies.SetItemChecked(0, true);
                    cmBxSize.Enabled = true;
                    cmBxCrust.Enabled = true;
                    cmBxSauce.SelectedIndex = 0;
                    cmBxSauce.Enabled = true;
                    SetSizePrices();
                    break;
                case 3:
                    checkBxVeggies.Enabled = true;
                    checkBxMeats.Enabled = true;

                    checkBxMeats.SetItemChecked(4, true);
                    checkBxMeats.SetItemChecked(5, true);
                    checkBxVeggies.SetItemChecked(8, true);
                    checkBxVeggies.SetItemChecked(0, true);
                    cmBxSize.Enabled = true;
                    cmBxCrust.Enabled = true;
                    cmBxSauce.SelectedIndex = 0;
                    cmBxSauce.Enabled = true;
                    SetSizePrices();
                    break;
                case 4:
                    checkBxVeggies.Enabled = true;
                    checkBxMeats.Enabled = true;

                    checkBxMeats.SetItemChecked(6, true);
                    checkBxMeats.SetItemChecked(5, true);
                    checkBxVeggies.SetItemChecked(10, true);
                    checkBxVeggies.SetItemChecked(0, true);
                    cmBxSize.Enabled = true;
                    cmBxCrust.Enabled = true;
                    cmBxSauce.SelectedIndex = 1;
                    cmBxSauce.Enabled = true;
                    SetSizePrices();
                    break;
                case 5:
                    checkBxVeggies.Enabled = true;
                    checkBxMeats.Enabled = true;

                    checkBxMeats.SetItemChecked(0, true);
                    checkBxMeats.SetItemChecked(1, true);
                    checkBxMeats.SetItemChecked(4, true);
                    checkBxMeats.SetItemChecked(5, true);
                    checkBxMeats.SetItemChecked(7, true);
                    checkBxMeats.SetItemChecked(8, true);
                    checkBxVeggies.SetItemChecked(0, true);
                    cmBxSize.Enabled = true;
                    cmBxCrust.Enabled = true;
                    cmBxSauce.SelectedIndex = 0;
                    cmBxSauce.Enabled = true;
                    SetSizePrices();
                    break;
                case 6:
                    checkBxVeggies.Enabled = true;
                    checkBxMeats.Enabled = true;

                    checkBxVeggies.SetItemChecked(0, true);
                    checkBxVeggies.SetItemChecked(1, true);
                    checkBxVeggies.SetItemChecked(4, true);
                    checkBxVeggies.SetItemChecked(6, true);
                    checkBxVeggies.SetItemChecked(10, true);
                    checkBxVeggies.SetItemChecked(5, true);
                    cmBxSize.Enabled = true;
                    cmBxCrust.Enabled = true;
                    cmBxSauce.SelectedIndex = 0;
                    cmBxSauce.Enabled = true;
                    SetSizePrices();
                    break;
                case 7:
                    checkBxVeggies.Enabled = true;
                    checkBxMeats.Enabled = true;

                    checkBxMeats.SetItemChecked(1, true);
                    checkBxMeats.SetItemChecked(8, true);
                    checkBxMeats.SetItemChecked(7, true);
                    checkBxVeggies.SetItemChecked(0, true);
                    checkBxVeggies.SetItemChecked(1, true);
                    checkBxVeggies.SetItemChecked(6, true);
                    checkBxVeggies.SetItemChecked(4, true);
                    cmBxSize.Enabled = true;
                    cmBxCrust.Enabled = true;
                    cmBxSauce.SelectedIndex = 0;
                    cmBxSauce.Enabled = true;
                    SetSizePrices();
                    break;
                case 8:
                    checkBxVeggies.Enabled = true;
                    checkBxMeats.Enabled = true;

                    checkBxMeats.SetItemChecked(0, true);
                    checkBxVeggies.SetItemChecked(3, true);
                    checkBxVeggies.SetItemChecked(6, true);
                    checkBxVeggies.SetItemChecked(7, true);
                    checkBxVeggies.SetItemChecked(9, true);
                    checkBxVeggies.SetItemChecked(0, true);
                    cmBxSize.Enabled = true;
                    cmBxCrust.Enabled = true;
                    cmBxSauce.SelectedIndex = 0;
                    cmBxSauce.Enabled = true;
                    SetSizePrices();
                    break;
                case 9:
                    checkBxVeggies.Enabled = true;
                    checkBxMeats.Enabled = true;

                    for (int i = 0; i < 9; i++)
                    {
                        checkBxMeats.SetItemChecked(i, true);
                    }
                    for (int i = 0; i < 11; i++)
                    {
                        checkBxVeggies.SetItemChecked(i, true);
                    }
                    cmBxSize.Enabled = true;
                    cmBxCrust.Enabled = true;
                    cmBxSauce.SelectedIndex = 0;
                    cmBxSauce.Enabled = true;
                    SetSizePrices();
                    break;
                default:
                    for (int i = 0; i < 9; i++)
                    {
                        checkBxMeats.SetItemChecked(i, false);
                    }
                    checkBxMeats.Enabled = true;
                    for (int i = 0; i < 11; i++)
                    {
                        checkBxVeggies.SetItemChecked(i, false);
                    }
                    checkBxVeggies.Enabled = true;
                    break;
            }
        }

        private void cmBxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmBxPizzaType.SelectedIndex)
            {
                case 0:
                case 2: SetLevelOnePrice();
                    break;
                case 1:
                case 3:
                case 5:
                case 6:
                case 7: SetLevelTwoPrice();
                    break;
                case 4:
                case 8:
                case 9: SetLevelThreePrice();
                    break;
            }
        }

        private void cmBxCrust_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmBxCrust.SelectedIndex)
            {
                case 0:
                case 1:
                case 2: if (counterCrust == 1)
                    {
                        AddRemovePizzaPrice(-2.00);
                        counterCrust--;
                    }
                    break;
                case 3: if (counterCrust == 0)
                    {
                        AddRemovePizzaPrice(2.00);
                        counterCrust++;
                    }
                    break;
                default: break;
            }
        }

        private void checkBxMeats_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (checkBxMeats.GetItemChecked(checkBxMeats.SelectedIndex) == true)
                {
                    switch (cmBxSize.SelectedIndex)
                    {
                        case 0: AddRemovePizzaPrice(0.50);
                            break;
                        case 1:
                        case 2: AddRemovePizzaPrice(1.00);
                            break;
                        case 3: AddRemovePizzaPrice(1.50);
                            break;
                    }
                }

                if (checkBxMeats.GetItemChecked(checkBxMeats.SelectedIndex) == false)
                {
                    switch (cmBxSize.SelectedIndex)
                    {
                        case 0:
                            AddRemovePizzaPrice(-0.50);
                            break;
                        case 1:
                        case 2:
                            AddRemovePizzaPrice(-1.00);
                            break;
                        case 3:
                            AddRemovePizzaPrice(-1.50);
                            break;
                    }
                }
        }

        private void checkBxVeggies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBxVeggies.GetItemChecked(checkBxVeggies.SelectedIndex) == true)
            {
                switch (cmBxSize.SelectedIndex)
                {
                    case 0:
                        AddRemovePizzaPrice(0.50);
                        break;
                    case 1:
                    case 2:
                        AddRemovePizzaPrice(1.00);
                        break;
                    case 3:
                        AddRemovePizzaPrice(1.50);
                        break;
                }
            }

            if (checkBxVeggies.GetItemChecked(checkBxVeggies.SelectedIndex) == false)
            {
                switch (cmBxSize.SelectedIndex)
                {
                    case 0:
                        AddRemovePizzaPrice(-0.50);
                        break;
                    case 1:
                    case 2:
                        AddRemovePizzaPrice(-1.00);
                        break;
                    case 3:
                        AddRemovePizzaPrice(-1.50);
                        break;
                }
            }

        }

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            if (cmBxPizzaType.Text == "")
                MessageBox.Show("You have to select a pizza type in order to add a pizza!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cmBxSize.Text == "")
                MessageBox.Show("You have to select a size in order to add a pizza!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cmBxCrust.Text == "")
                MessageBox.Show("You have to select a crust type in order to add a pizza!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cmBxSauce.Text == "")
                MessageBox.Show("You have to select a sauce in order to add a pizza!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (counterPizzaOrder > 9)
                MessageBox.Show("I am sorry. You have reached the maximum number of pizza's available to be ordered at our cafe." + 
                                " Please remove a pizza from the checkout tab, or reconsider your choice.", "Sorry.");
            else
            {
                counterPizzaOrder++;
                subTotal += currentPizzaTotal;
                allPizzaTotal += currentPizzaTotal;
                CalculateTaxTipAndGrand();
                lblCurrentTotal.Text = string.Format("{0:C}", subTotal);
                pizzaOrder += "1x ";
                switch (cmBxSize.SelectedIndex)
                {
                    case 0:
                        pizzaOrder += "Personal ";
                        break;
                    case 1:
                        pizzaOrder += "Medium ";
                        break;
                    case 2:
                        pizzaOrder += "Large ";
                        break;
                    case 3:
                        pizzaOrder += "X Large ";
                        break;
                    default:
                        pizzaOrder += "Unknown Error ";
                        break;
                }
                pizzaOrder += cmBxPizzaType.Text + " (" + currentPizzaTotal.ToString("C") + ")\r\n";
                AddOrderToBoxes();
                cmBxPizzaType.SelectedIndex = -1;
                cmBxSize.SelectedIndex = -1;
                cmBxCrust.SelectedIndex = -1;
                cmBxSauce.SelectedIndex = -1;
                counterCrust = 0;
                cmBxSize.Enabled = false;
                cmBxCrust.Enabled = false;
                cmBxSauce.Enabled = false;
                checkBxMeats.Enabled = false;
                checkBxVeggies.Enabled = false;
                for (int i = 0; i < 9; i++)
                {
                    checkBxMeats.SetItemChecked(i, false);
                }
                for (int i = 0; i < 11; i++)
                {
                    checkBxVeggies.SetItemChecked(i, false);
                }
                checkBxVeggies.SetItemChecked(0, true);
                lblPizzaTotal.Text = string.Format("{0:C}", 0.00);
                currentPizzaTotal = 0;

                MessageBox.Show("Your pizza has been added to your cart!", "YAY!");
            
            }
        }

        private void btnClearSelections_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear your current pizza selections?", "Well do ya?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cmBxPizzaType.SelectedIndex = -1;
                cmBxSize.SelectedIndex = -1;
                cmBxCrust.SelectedIndex = -1;
                cmBxSauce.SelectedIndex = -1;
                counterCrust = 0;
                cmBxSize.Enabled = false;
                cmBxCrust.Enabled = false;
                cmBxSauce.Enabled = false;
                checkBxMeats.Enabled = false;
                checkBxVeggies.Enabled = false;
                for (int i = 0; i < 9; i++)
                {
                    checkBxMeats.SetItemChecked(i, false);
                }
                for (int i = 0; i < 11; i++)
                {
                    checkBxVeggies.SetItemChecked(i, false);
                }
                checkBxVeggies.SetItemChecked(0, true);
                lblPizzaTotal.Text = string.Format("{0:C}", 0.00);
                currentPizzaTotal = 0;
            }
        }

        private void btnAddBeverage_Click(object sender, EventArgs e)
        {
            int quantity = 0;

            double dummyCost = 0;

            if (cmBxBeverageType.Text == "")
                MessageBox.Show("You have to select a beverage type in order to add a beverage!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cmBxBeverageSize.Text == "")
                MessageBox.Show("You have to select a beverage size in order to add a beverage!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtBxBeverageAmount.Text == "Quantity...")
                MessageBox.Show("You have to select a beverage quantity in order to add a beverage!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(txtBxBeverageAmount.Text, out quantity) == false | quantity < 1)
                MessageBox.Show("Please only enter positive integers for the beverage quantity!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (counterSideOrder > 9)
                MessageBox.Show("I am sorry. You have reached the maximum number of sides available to be ordered at our cafe. Please remove a side from the checkout tab, or reconsider your choice.", "Sorry.");
            else
            {
                counterSideOrder++;
                sideOrder += quantity + "x ";
                switch (cmBxBeverageSize.SelectedIndex)
                {
                    case 0: dummyCost = 1.79 * quantity;
                        sideOrder += "18-20 fl oz bottle of ";
                        sideOrder += cmBxBeverageType.Text + " (" + dummyCost.ToString("C") + ")\r\n";
                        break;
                    case 1: dummyCost = 2.99 * quantity;
                        sideOrder += "2 liter bottle of ";
                        sideOrder += cmBxBeverageType.Text + " (" + dummyCost.ToString("C") + ")\r\n";
                        break;
                }
                allSideTotal += dummyCost;
                subTotal += dummyCost;
                CalculateTaxTipAndGrand();
                AddOrderToBoxes();
                cmBxBeverageType.SelectedIndex = -1;
                cmBxBeverageSize.SelectedIndex = -1;
                txtBxBeverageAmount.Text = "Quantity...";
                lblCurrentTotal.Text = string.Format("{0:C}", subTotal);
                MessageBox.Show("The Beverage has successfully been added to your cart!", "YAY");
            }
        }

        private void btnAddWings_Click(object sender, EventArgs e)
        {
            double dummyCost = 0;

            if (cmBxWingType.Text == "")
                MessageBox.Show("You have to select a wing type in order to add wings!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cmBxWingSauce.Text == "")
                MessageBox.Show("You have to select a wing sauce in order to add wings!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cmBxWingAmount.Text == "")
                MessageBox.Show("You have to select a quantity of wings in order to add wings!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (counterSideOrder > 9)
                MessageBox.Show("I am sorry. You have reached the maximum number of sides available to be ordered at our cafe. Please remove a side from the checkout tab, or reconsider your choice.", "Sorry.");
            else
            {
                counterSideOrder++;
                switch (cmBxWingAmount.SelectedIndex)
                {
                    case 0: dummyCost = 6.99;
                        sideOrder += "6 Piece ";
                        sideOrder += cmBxWingSauce.Text + " " + cmBxWingType.Text + " Wings";
                        sideOrder += " (" + dummyCost.ToString("C") + ")";
                        break;
                    case 1: dummyCost = 13.49;
                        sideOrder += "12 Piece ";
                        sideOrder += cmBxWingSauce.Text + " " + cmBxWingType.Text + " Wings";
                        sideOrder += " (" + dummyCost.ToString("C") + ")";

                        break;
                    case 2: dummyCost = 18.99;
                        sideOrder += "18 Piece ";
                        sideOrder += cmBxWingSauce.Text + " " + cmBxWingType.Text + " Wings";
                        sideOrder += " (" + dummyCost.ToString("C") + ")";

                        break;
                    case 3: dummyCost = 37.98;
                        sideOrder += "36 Piece ";
                        sideOrder += cmBxWingSauce.Text + " " + cmBxWingType.Text + " Wings";
                        sideOrder += " (" + dummyCost.ToString("C") + ")";
                        break;
                }
                subTotal += dummyCost;
                allSideTotal += dummyCost;
                lblCurrentTotal.Text = string.Format("{0:C}", subTotal);
                CalculateTaxTipAndGrand();
                sideOrder += "\r\n";
                AddOrderToBoxes();
                cmBxWingType.SelectedIndex = -1;
                cmBxWingSauce.SelectedIndex = -1;
                cmBxWingAmount.SelectedIndex = -1;
                MessageBox.Show("The wings have been added to your cart!", "YAY");
            }
        }

        private void btnAddSides_Click(object sender, EventArgs e)
        {
            int quantity = 0;

            double dummyCost = 0;

            if (cmBxSidesType.Text == "")
                MessageBox.Show("You have to select a side in order to add a side!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtBxSidesAmount.Text == "Quantity...")
                MessageBox.Show("You have to enter a quantity for your side in order to add a side!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(txtBxSidesAmount.Text, out quantity) == false | quantity < 1)
                MessageBox.Show("Please only enter positive integers for a side quantity.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (counterSideOrder > 9)
                MessageBox.Show("I am sorry. You have reached the maximum number of sides available to be ordered at our cafe. Please remove a side from the checkout tab, or reconsider your choice.", "Sorry.");
            else
            {
                counterSideOrder++;
                switch (cmBxSidesType.SelectedIndex)
                {
                    case 0:
                        dummyCost = 4.29 * quantity;
                        sideOrder += quantity + "x Bread Sticks" + " (" + dummyCost.ToString("C") + ")";
                        break;
                    case 1: dummyCost = 5.29 * quantity;
                        sideOrder += quantity + "x Cheesesticks" + " (" + dummyCost.ToString("C") + ")";
                        break;
                    case 2: dummyCost = 4.29 * quantity;
                        sideOrder += quantity + "x Hot Pepper Bread Sticks" + " (" + dummyCost.ToString("C") + ")";
                        break;
                    case 3: dummyCost = 3.49 * quantity;
                        sideOrder += quantity + "x Fries" + " (" + dummyCost.ToString("C") + ")";
                        break;
                    case 4: dummyCost = 3.49 * quantity;
                        sideOrder += quantity + "x Cajun Seasoned Fries" + " (" + dummyCost.ToString("C") + ")";
                        break;
                    case 5: dummyCost = 4.49 * quantity;
                        sideOrder += quantity + "x Mozzarella Cheesesticks" + " (" + dummyCost.ToString("C") + ")";
                        break;
                }
                subTotal += dummyCost * quantity;
                allSideTotal += dummyCost * quantity;
                CalculateTaxTipAndGrand();
                lblCurrentTotal.Text = string.Format("{0:C}", subTotal);
                sideOrder += "\r\n";
                AddOrderToBoxes();
                cmBxSidesType.SelectedIndex = -1;
                txtBxSidesAmount.Text = "Quantity...";
                MessageBox.Show("The side has been added to your cart!", "YAY");
            }
        }

        private void btnCheckoutAddPizza_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void rdBtnDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnDelivery.Checked == true)
                if (counterDelivery != 1)
                {
                    subTotal += 2;
                    lblCurrentTotal.Text = string.Format("{0:C}", subTotal);
                    counterDelivery++;
                    CalculateTaxTipAndGrand();
                }
        }

        private void rdBtnWalkIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnWalkIn.Checked == true)
                if (counterDelivery != 0)
                {
                    subTotal -= 2;
                    lblCurrentTotal.Text = string.Format("{0:C}", subTotal);
                    counterDelivery--;
                    CalculateTaxTipAndGrand();
                }

        }

        private void btnFinalizeOrder_Click(object sender, EventArgs e)
        {
            if (rdBtnDelivery.Checked == false & rdBtnWalkIn.Checked == false)
                MessageBox.Show("Please choose a delivery option in the checkout menu!", "Pretty please.");
            else if (subTotal == 0 | subTotal < 0)
                MessageBox.Show("You don't have anything in your cart!", "Awkward.");
            else
            {
                MessageBox.Show("Alright, this is the final step of the process. Please enter your contact" +
                                " information below so that we may create a profile on hand. This will allow for" +
                                " speedy checkouts. By just giving us your phone number, we will already know" +
                                " who we're delivering to and where we need to go." +
                                "\n\nThank you for chosing Zack's Pizza and Cafe!!!", "Thank you!");
                tabControl1.SelectTab(3);
                btnFinishOrder.Enabled = true;
            }
        }

        private void btnCheckoutRemovePizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove all of your pizza selections from your cart?" +
                "\nThere is no going back.", "Well do ya?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                counterPizzaOrder = 0;
                txtBxPizzaOrder.Clear();
                subTotal -= allPizzaTotal;
                allPizzaTotal = 0;
                lblCurrentTotal.Text = string.Format("{0:C}", subTotal);
                CalculateTaxTipAndGrand();
            }
        }

        private void btnCheckoutRemoveSide_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove all of your side selections from your cart?\n" +
                "There is no going back.", "Well do ya?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                counterSideOrder = 0;
                txtBxSidesOrder.Clear();
                subTotal -= allSideTotal;
                allSideTotal = 0;
                lblCurrentTotal.Text = string.Format("{0:C}", subTotal);
                CalculateTaxTipAndGrand();
            }
        }

        private void SetLevelOnePrice()
        {
            switch (cmBxSize.SelectedIndex)
            {
                case 0:
                    lblPizzaTotal.Text = "$4.29";
                    currentPizzaTotal = 4.29;
                    break;
                case 1:
                    lblPizzaTotal.Text = "$7.99";
                    currentPizzaTotal = 7.99;
                    break;
                case 2:
                    lblPizzaTotal.Text = "$9.99";
                    currentPizzaTotal = 9.99;
                    break;
                case 3:
                    lblPizzaTotal.Text = "$12.99";
                    currentPizzaTotal = 12.99;
                    break;
                default:
                    lblPizzaTotal.Text = "$0.00";
                    currentPizzaTotal = 0.00;
                    break;
            }
        }

        private void SetLevelTwoPrice()
        {
            switch (cmBxSize.SelectedIndex)
            {
                case 0:
                    lblPizzaTotal.Text = "$4.79";
                    currentPizzaTotal = 4.79;
                    break;
                case 1:
                    lblPizzaTotal.Text = "$11.99";
                    currentPizzaTotal = 11.99;
                    break;
                case 2:
                    lblPizzaTotal.Text = "$14.99";
                    currentPizzaTotal = 14.99;
                    break;
                case 3:
                    lblPizzaTotal.Text = "$17.99";
                    currentPizzaTotal = 17.99;
                    break;
                default:
                    lblPizzaTotal.Text = "$0.00";
                    currentPizzaTotal = 0.00;
                    break;
            }
        }

        private void SetLevelThreePrice()
        {
            switch (cmBxSize.SelectedIndex)
            {
                case 0:
                    lblPizzaTotal.Text = "$5.29";
                    currentPizzaTotal = 5.29;
                    break;
                case 1:
                    lblPizzaTotal.Text = "$12.99";
                    currentPizzaTotal = 12.99;
                    break;
                case 2:
                    lblPizzaTotal.Text = "$15.99";
                    currentPizzaTotal = 15.99;
                    break;
                case 3:
                    lblPizzaTotal.Text = "$18.99";
                    currentPizzaTotal = 18.99;
                    break;
                default:
                    lblPizzaTotal.Text = "$0.00";
                    currentPizzaTotal = 0.00;
                    break;
            }
        }

        private void btnCheckoutAddSides_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void SetSizePrices()
        {
            switch (cmBxPizzaType.SelectedIndex)
            {
                case 0:
                case 2:
                    SetLevelOnePrice();
                    break;
                case 1:
                case 3:
                case 5:
                case 6:
                case 7:
                    SetLevelTwoPrice();
                    break;
                case 4:
                case 8:
                case 9:
                    SetLevelThreePrice();
                    break;
            }
        }

        private void AddRemovePizzaPrice(double addRemove)
        {
            double dummy = currentPizzaTotal;

            dummy += addRemove;
            currentPizzaTotal = dummy;
            lblPizzaTotal.Text = string.Format("{0:C}", dummy);
        }

        private void txtBxBeverageAmount_MouseHover(object sender, EventArgs e)
        {
            txtBxBeverageAmount.Text = "";
        }

        private void txtBxSidesAmount_MouseHover(object sender, EventArgs e)
        {
            txtBxSidesAmount.Text = "";
        }

        private void CalculateTaxTipAndGrand()
        {
            taxAmount = subTotal * 0.06;
            lblTaxAmount.Text = string.Format("{0:C}", taxAmount);
            tipAmount = subTotal * 0.15;
            lblTipAmount.Text = string.Format("{0:C}", tipAmount);
            grandTotal = subTotal + taxAmount + tipAmount;
            lblGrandTotal.Text = string.Format("{0:C}", grandTotal);
            lblGrandTotalContact.Text = string.Format("{0:C}", grandTotal);
        }

        private void btnChangeOrder_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            double dummy;
            bool emailValid;

            email = new EmailAddressAttribute();
            emailValid = email.IsValid(txtBxEmail.Text);

            if (txtBxName.Text == "")
                MessageBox.Show("Please enter a name into the Name box.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtBxPhone.Text == "")
                MessageBox.Show("Please enter a phone number into the phone box.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtBxPhone.Text.Length < 10 | txtBxPhone.Text.Length > 10 | double.TryParse(txtBxPhone.Text, out dummy) == false)
                MessageBox.Show("Please only enter a 10 digit numeric phone number into the phone box. No symbols required.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (emailValid == false)
                MessageBox.Show("Please enter a valid email address.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtBxHomeAddress.Text == "")
                MessageBox.Show("Please enter a home address or we can't deliver to you!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CalculateTaxTipAndGrand();

                try
                {

                    MailMessage emailMessage = new MailMessage("ZacksPizzaCS160@outlook.com", txtBxEmail.Text);
                    SmtpClient client = new SmtpClient();
                    client.Port = 25;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("ZacksPizzaCS160@outlook.com", "zack310302");
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.Host = "smtp.live.com";
                    emailMessage.Subject = "Zacks Pizza and Cafe Online Order Receipt";
                    emailMessage.Body = "Zack's Pizza and Cafe\nOwner: Zackery Crews\nLocation: 2800 University Blvd.\n" +
                                        "Phone: (904) 555 - 8888\nEmail: ZacksPizzaCS160@outlook.com\n\nPizza's\n\n" + pizzaOrder +
                                        "\n\nSides\n\n" + sideOrder + "\n\nSubtotal: " + subTotal.ToString("C") + "\nTax: " + taxAmount.ToString("C") +
                                        "\nTip (15%): " + tipAmount + "\n\nGrand Total: " + grandTotal + "\n\n\nThank you for choosing Zack's Pizza" +
                                        " and Cafe!\nYour order will be done within 30 minutes.\nOther wise everything is half off! Enjoy!";
                    emailMessage.BodyEncoding = UTF8Encoding.UTF8;
                    emailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    client.Send(emailMessage);
                    MessageBox.Show("Your email receipt has been sent! Thank you for choosing Zack's Pizza and Cafe! Enjoy your food!\n\n" +
                                    "The application will now exit...");
                    Application.Exit();
                }
                catch
                {
                    if (MessageBox.Show("Something went wrong and the application couldn't send the email receipt.\n\n" +
                                    "Do you wish to double check your email address/order? If not the application will close, " +
                                    "and a receipt will be given to you when you receive your order!", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {

                        MessageBox.Show("Thank you for choosing Zack's Pizza and Cafe! Enjoy your food!");

                        Application.Exit();
                    }
                }
            }
        }

        private void AddOrderToBoxes()
        {
            txtBxPizzaOrder.Text = pizzaOrder;
            txtBxSidesOrder.Text = sideOrder;
        }

        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void ChangeConnectionStatus()
        {
            bool result;

            result = CheckForInternetConnection();

            if (result == true)
            {
                internetConnectionToolStripMenuItem.BackColor = Color.Green;
                internetConnectionToolStripMenuItem.ForeColor = Color.White;
                internetConnectionToolStripMenuItem.Image = Image.FromFile("greenCheckMark.jpg");
            }
            else
            {
                internetConnectionToolStripMenuItem.BackColor = Color.Transparent;
                internetConnectionToolStripMenuItem.ForeColor = Color.Black;
                internetConnectionToolStripMenuItem.Image = Image.FromFile("redXMark.png");
            }
        }
    }
}
