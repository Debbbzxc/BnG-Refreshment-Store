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
        Total total = new Total();
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
            InitialOrder initialOrder = new InitialOrder();

            while (true)
            {
                if (double.TryParse(txtQuantity.Text, out double input))
                {
                    if (input > 0)
                    {
                        initialOrder.quantity = input;
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

            while (true)
            {
                if (rbCappuccino.Checked) { initialOrder.coffeeSelection(total, "cappuccino"); break; }
                else if (rbEspresso.Checked) { initialOrder.coffeeSelection(total, "espresso"); break; }
                else if (rbLatte.Checked) { initialOrder.coffeeSelection(total, "latte"); break; }
                else if (rbIcedLatte.Checked) { initialOrder.coffeeSelection(total, "icedLatte"); break; }
                else if (rbIcedCappuccino.Checked) { initialOrder.coffeeSelection(total, "icedCappuccino"); break; }
                else { MessageBox.Show("Please select a coffee."); return; }
            }

            if (cbTakeout.Checked) { initialOrder.ifTakeout(total); } // if takeout

            txtItemAmount.Text = initialOrder.itemAmount.ToString("C2"); // item amount result
            txtSubtotal.Text = total.subtotal.ToString("C2"); // subtotal result
            txtTax.Text = total.tax.ToString("C2"); // tax result
            total.totalDue = total.subtotal + total.tax;
            txtTotalDue.Text = total.totalDue.ToString("C2"); // total due result

            total.countOrders += initialOrder.quantity; // increment order count

            btnCalculateSelection.Enabled = false;
            btnClearForNextItem.Enabled = true;
            txtQuantity.Enabled = false;
            cbTakeout.Enabled = false;
            rbCappuccino.Enabled = false;
            rbEspresso.Enabled = false;
            rbLatte.Enabled = false;
            rbIcedLatte.Enabled = false;
            rbIcedCappuccino.Enabled = false;
            groupBox1.Focus();
        }

        private void btnClearForNextItem_Click(object sender, EventArgs e)
        {
            // Reset buttons / texts
            txtQuantity.Text = string.Empty;
            cbTakeout.Checked = false;
            txtItemAmount.Text = string.Empty;
            rbCappuccino.Checked = false;
            rbEspresso.Checked = false;
            rbLatte.Checked = false;
            rbIcedLatte.Checked = false;
            rbIcedCappuccino.Checked = false;

            // Enabled
            txtQuantity.Enabled = true;
            cbTakeout.Enabled = true;
            rbCappuccino.Enabled = true;
            rbEspresso.Enabled = true;
            rbLatte.Enabled = true;
            rbIcedLatte.Enabled = true;
            rbIcedCappuccino.Enabled = true;

            // Button enable/disable
            btnClearForNextItem.Enabled = false;
            btnCalculateSelection.Enabled = true;

            // Typing cursor back to quantity
            txtQuantity.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            total.summaryAverageSale(total);
            total.summaryMessageBox();
        }
    }
}
