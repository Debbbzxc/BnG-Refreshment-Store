using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OOP_GUI3
{
    public partial class Form1 : Form
    {
        private Total total = new Total();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCalculateSelection_Click(object sender, EventArgs e)
        {
            // Classes
            Constant constant = new Constant();
            InitialOrder initialOrder = new InitialOrder();

            // Input Quantity
            while (true)
            {
                if (double.TryParse(txtQuantity.Text, out double quantity))
                {
                    if (quantity > 0)
                    {
                        initialOrder.quantity = quantity;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a quantity greater than zero.");
                        txtQuantity.Text = string.Empty;
                        txtQuantity.Focus();
                        return;
                    }
                }
                else if (txtQuantity.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the quantity.");
                    txtQuantity.Text = string.Empty;
                    txtQuantity.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                    txtQuantity.Text = string.Empty;
                    txtQuantity.Focus();
                    return;
                }
            }

            // Coffee Selection
            while (true)
            {
                if (rbCapuccino.Checked || rbEspresso.Checked || rbLatte.Checked || rbLatte.Checked || rbIcedLatte.Checked || rbIcedCapuccino.Checked)
                {
                    if (rbCapuccino.Checked)
                    {
                        initialOrder.itemAmount += initialOrder.quantity * constant.capuccino;
                        total.subtotal += initialOrder.itemAmount;
                        total.countTotalDollarAmount += initialOrder.itemAmount;
                        if (cbTakeout.Checked)
                        {
                            total.tax += initialOrder.itemAmount * constant.taxRate;
                            total.countTotalDollarAmount += initialOrder.itemAmount * constant.taxRate;
                        }
                    }
                    else if (rbEspresso.Checked)
                    {
                        initialOrder.itemAmount += initialOrder.quantity * constant.espresso;
                        total.subtotal += initialOrder.itemAmount;
                        total.countTotalDollarAmount += initialOrder.itemAmount;
                        if (cbTakeout.Checked)
                        {
                            total.tax += initialOrder.itemAmount * constant.taxRate;
                            total.countTotalDollarAmount += initialOrder.itemAmount * constant.taxRate;
                        }
                    }
                    else if (rbLatte.Checked)
                    {
                        initialOrder.itemAmount += initialOrder.quantity * constant.latte;
                        total.subtotal += initialOrder.itemAmount;
                        total.countTotalDollarAmount += initialOrder.itemAmount;
                        if (cbTakeout.Checked)
                        {
                            total.tax += initialOrder.itemAmount * constant.taxRate;
                            total.countTotalDollarAmount += initialOrder.itemAmount * constant.taxRate;
                        }
                    }
                    else if (rbIcedLatte.Checked)
                    {
                        initialOrder.itemAmount += initialOrder.quantity * constant.icedLatte;
                        total.subtotal += initialOrder.itemAmount;
                        total.countTotalDollarAmount += initialOrder.itemAmount;
                        if (cbTakeout.Checked)
                        {
                            total.tax += initialOrder.itemAmount * constant.taxRate;
                            total.countTotalDollarAmount += initialOrder.itemAmount * constant.taxRate;
                        }
                    }
                    else if (rbIcedCapuccino.Checked)
                    {
                        initialOrder.itemAmount += initialOrder.quantity * constant.icedCapuccino;
                        total.subtotal += initialOrder.itemAmount;
                        total.countTotalDollarAmount += initialOrder.itemAmount;
                        if (cbTakeout.Checked)
                        {
                            total.tax += initialOrder.itemAmount * constant.taxRate;
                            total.countTotalDollarAmount += initialOrder.itemAmount * constant.taxRate;
                        }
                    }
                    break;
                }
                else
                {
                    MessageBox.Show("Please select a coffee.");
                    return;
                }
            }

            // 1st Container - Result
            txtItemAmount.Text = initialOrder.itemAmount.ToString("C2");
            // 2nd Container - Result
            txtSubtotal.Text = total.subtotal.ToString("C2");
            txtTax.Text = total.tax.ToString("C2");

            total.totalDue = total.subtotal + total.tax;
            txtTotalDue.Text = total.totalDue.ToString("C2");

            // Summary-related
            total.countOrders += initialOrder.quantity;
            //total.countTotalDollarAmount += ;

            // Button enable/disable
            btnCalculateSelection.Enabled = false;
            btnClearForNextItem.Enabled = true;
            groupBox1.Focus();
            // Disabled
            txtQuantity.Enabled = false;
            cbTakeout.Enabled = false;
            rbCapuccino.Enabled = false;
            rbEspresso.Enabled = false;
            rbLatte.Enabled = false;
            rbIcedLatte.Enabled = false;
            rbIcedCapuccino.Enabled = false;
        }

        private void btnClearForNextItem_Click(object sender, EventArgs e)
        {
            // Reset buttons / texts
            txtQuantity.Text = string.Empty;
            cbTakeout.Checked = false;
            txtItemAmount.Text = string.Empty;
            rbCapuccino.Checked = false;
            rbEspresso.Checked = false;
            rbLatte.Checked = false;
            rbIcedLatte.Checked = false;
            rbIcedCapuccino.Checked = false;

            // Enabled
            txtQuantity.Enabled = true;
            cbTakeout.Enabled = true;
            rbCapuccino.Enabled = true;
            rbEspresso.Enabled = true;
            rbLatte.Enabled = true;
            rbIcedLatte.Enabled = true;
            rbIcedCapuccino.Enabled = true;

            // Button enable/disable
            btnClearForNextItem.Enabled = false;
            btnCalculateSelection.Enabled = true;

            // Typing cursor back to quantity
            txtQuantity.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disable clear button at first start
            btnClearForNextItem.Enabled = false;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to create a new order?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                btnClearForNextItem_Click(sender, e);
                txtSubtotal.Text = string.Empty;
                txtTax.Text = string.Empty;
                txtTotalDue.Text = string.Empty;

                total.subtotal = 0;
                total.tax = 0;
                total.totalDue = 0;
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            total.showAverageSale(total);
            MessageBox.Show($"Number of orders: {total.countOrders}\nTotal dollar amount: {total.countTotalDollarAmount:C2}\nAverage sale amount per order: {total.countAverageSale:C2}");
        }
    }
}
