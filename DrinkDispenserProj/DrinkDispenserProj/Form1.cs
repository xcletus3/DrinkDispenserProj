using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkDispenserProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int priceApple = 150;
        int priceOrange = 120;
        int priceGuava = 100;

        public int priceTotal = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            orderlbl1.Text = "";
            orderlbl2.Text = "";
            orderlbl3.Text = "";

            orderTotallbl.Text = "";
            amountlbl.Text = "";
            txtbxAmount.Text = "";
            priceTotal = 0;

            // Checking the Checked boxes
            if (checkBoxApp.Checked)
            {
                orderlbl1.Text = $"Apple \t{numericUpDownApp.Value} * {priceApple}";
                priceTotal += priceApple * Convert.ToInt32(numericUpDownApp.Value);
            }
            if (checkBoxOrng.Checked)
            {
                orderlbl2.Text = $"Orange \t{numericUpDownOrng.Value} * {priceOrange}";
                priceTotal += priceOrange * Convert.ToInt32(numericUpDownOrng.Value);
            }
            if (checkBoxGuav.Checked)
            {
                orderlbl3.Text = $"Guava \t{numericUpDownGuav.Value} * {priceGuava}";
                priceTotal += priceGuava * Convert.ToInt32(numericUpDownGuav.Value);
            }

            orderTotallbl.Text = $"Total: {priceTotal.ToString()}";
            amountlbl.Text = priceTotal.ToString();
        }

        // Validate the input and show bill
private void paybutton_Click(object sender, EventArgs e)
        {
            String paymentAmount = txtbxAmount.Text;
            int payment = Convert.ToInt16(paymentAmount);

            if (payment >= priceTotal)
            {
                int balance = payment - priceTotal;
                MessageBox.Show($"Total Amount = {priceTotal}\nYour Payment = {paymentAmount}\nBalance = {balance}\n\nThanks for buying");
            }
            else 
            {
                MessageBox.Show("Enter a valid amount");
            }
        }

        // Reset the UI
        private void butnReset_Click(object sender, EventArgs e)
        {
            checkBoxApp.Checked = false;
            checkBoxOrng.Checked = false;
            checkBoxGuav.Checked = false;

            orderlbl1.Text = "";
            orderlbl2.Text = "";
            orderlbl3.Text = "";

            orderTotallbl.Text = "";
            amountlbl.Text = "";
            txtbxAmount.Text = "";
            priceTotal = 0;

            numericUpDownApp.Value = 0;
            numericUpDownOrng.Value = 0;
            numericUpDownGuav.Value = 0;
        }

        // Enable and Desable numeric box
        private void checkBoxApp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxApp.Checked == true) 
            {
                numericUpDownApp.Enabled = true;
            }
            if (checkBoxApp.Checked == false)
            {
                numericUpDownApp.Enabled = false;
            }
        }
        private void checkBoxOrng_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOrng.Checked == true)
            {
                numericUpDownOrng.Enabled = true;
            }
            if (checkBoxOrng.Checked == false)
            {
                numericUpDownOrng.Enabled = false;
            }
        }
        private void checkBoxGuav_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGuav.Checked == true)
            {
                numericUpDownGuav.Enabled = true;
            }
            if (checkBoxGuav.Checked == false)
            {
                numericUpDownGuav.Enabled = false;
            }
        }
    }
    }
