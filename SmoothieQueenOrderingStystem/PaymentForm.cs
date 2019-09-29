/**********************************************************
 * Author:  Cindy Breneman-Winters
 * Program Name:  Smoothie Queen Ordering System
 * Class:  PaymentForm Class
 * Date:  04/28/2018
 * Description: Multiform Ordering system for 
 *      Smoothie Queen with payment and order
 *      management
 * *******************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SmoothieQueenOrderingStystem
{
    public partial class PaymentForm : Form
    {
        Customer customer = new Customer();
        BinaryFormatter bFormatter = new BinaryFormatter();
        string customerFileName = "customers.txt";

        public PaymentForm()
        {
            InitializeComponent();
        }

        public void PassInCustomer(Customer customer)
        {
            this.customer = customer;
        }

        public Customer GetCustomer()
        {
            return customer;
        }

        private void EnableControls()
        {
            lstCardTypes.Enabled = true;
            txtCardNumber.Enabled = true;
            cmbExpMonth.Enabled = true;
            cmbExpYear.Enabled = true;
            chkDefaultOption.Enabled = true;
            txtCashReceived.Enabled = false;
        }
        private void DisableControls()
        {
            lstCardTypes.Enabled = false;
            txtCardNumber.Enabled = false;
            cmbExpMonth.Enabled = false;
            cmbExpYear.Enabled = false;
            chkDefaultOption.Enabled = false;
            txtCashReceived.Enabled = true;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            string[] months = {"January", "February", "March", "April",
                "May", "June", "July", "August", "September", "October", "November", "December" };
            int startYear = DateTime.Today.Year;
            int endYear = startYear + 8;

            cmbExpMonth.Items.AddRange(months);

            for (int x = startYear; x <= endYear; ++x)
            {
                cmbExpYear.Items.Add(x);
            }
        }

        private void cmbExpMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbExpYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            DisableControls();
        }

        private void rdoCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls();
        }
        private bool IsValid()
        {
            if (rdoCreditCard.Checked)
            {
                if (lstCardTypes.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose credit card type.", "Entry Error.");
                    lstCardTypes.Focus();
                    return false;
                }
                if (txtCardNumber.Text == "")
                {
                    MessageBox.Show("Please enter a valid card number.", "Entry Error.");
                    txtCardNumber.Focus();
                    return false;
                }
                if (cmbExpMonth.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose expiration month.", "Entry Error.");
                    cmbExpMonth.Focus();
                    return false;
                }
                if (cmbExpYear.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose expiration year.", "Entry Error.");
                    cmbExpYear.Focus();
                    return false;
                }
                
                
            }
            else
            {
                if (txtCashReceived.Text == "")
                {
                    MessageBox.Show("Please enter cash received.");
                    txtCashReceived.Focus();
                    return false;
                }
                try
                {
                    double cash = Convert.ToDouble(txtCashReceived.Text);

                }
                catch
                {
                    MessageBox.Show("Please enter cash received.");
                    txtCashReceived.Focus();
                    return false;
                }
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (rdoCreditCard.Checked)
                {
                    customer.CardNumber = txtCardNumber.Text;
                    customer.CardType = lstCardTypes.SelectedItem.ToString();
                    customer.Expiration = $"{cmbExpMonth.SelectedItem.ToString()} / {cmbExpYear.SelectedItem.ToString()}";
                    customer.SavedCard = chkDefaultOption.Checked;
                    customer.Cash = rdoCash.Checked;
                    if (customer.SavedCard)
                    {
                        if (File.Exists(customerFileName))
                        {
                            FileStream outFile = new FileStream(customerFileName, FileMode.Append, FileAccess.Write);
                            bFormatter.Serialize(outFile, customer);
                            outFile.Close();
                        }
                        else
                        {
                            FileStream outFile = new FileStream(customerFileName, FileMode.Create, FileAccess.Write);
                            bFormatter.Serialize(outFile, customer);
                            outFile.Close();
                        }
                    }
                }
                else
                {
                    customer.CashReceived = Convert.ToDouble(txtCashReceived.Text);
                    customer.Cash = rdoCash.Checked;
                }
                customer.Paid = true;

                this.Close();
            }  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
