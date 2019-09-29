/**********************************************************
 * Author:  Cindy Breneman-Winters
 * Program Name:  Smoothie Queen Ordering System
 * Class:  OrderForm Class
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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SmoothieQueenOrderingStystem
{
    public partial class OrderForm : Form
    {
        //Instantiate Customer, Order, and Smoothie List
        //for use in this class
        Customer customer = new Customer();
        List<Smoothie> smoothiesList = new List<Smoothie>();
        Order order = new Order();
        BinaryFormatter bFormatter = new BinaryFormatter();
        string customerFileName = "customers.txt";
        

        //Method to allow list of smoothies to be passed
        //in to this instance of the form.
        public void PassOrderList(List<Smoothie> smoothies)
        {
            this.smoothiesList = smoothies;
        }

        //OrderForm Constructor
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            order.Smoothies = smoothiesList; //load smoothies into order class
            UpdateLabelTotals(); //update labels with info from list
            customer.Paid = false;


        }


        //Methods to provide helper functions in this class
        private void UpdateLabelTotals()
        {
            lblsmoothiesTotal.Text = $"Smoothies:  {order.SubTotal.ToString("C2")}";
            lblDiscount.Text = $"Discount:  -{order.Discount.ToString("C2")}";
            lblSubTotal.Text = $"SubTotal:  {(order.SubTotal - order.Discount).ToString("C2")}";
            lblSalesTax.Text = $"Sales Tax:  {order.TaxTotal.ToString("C2")}";
            lblTotal.Text = $"Total:  {order.OrderTotal.ToString("C2")}";
        }

        private void EnableCashLabels()
        {
            lblPaymentMethod.Visible = true;
            lblCardType.Visible = true;
            lblChange.Visible = true;
            lblCardNumber.Visible = false;
            lblExpirationDate.Visible = false;
        }

        private void EnableCreditLabels()
        {
            lblPaymentMethod.Visible = true;
            lblCardType.Visible = true;
            lblCardNumber.Visible = true;
            lblExpirationDate.Visible = true;
            lblChange.Visible = false;
        }

        private void ReturningCustomers()
        {
            lblPaymentMethod.Text = $"Paid with credit card.";
            lblCardType.Text = $"{customer.CardType}";
            lblCardNumber.Text = $"{customer.CardNumber}";
            lblExpirationDate.Text = $"{customer.Expiration}";
            EnableCreditLabels();
        }

        //Validation Method
        private bool IsValid()
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter your First Name.", "Entry Error");
                txtFirstName.Focus();
                return false;
            }
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please enter your Last Name.", "Entry Error");
                txtLastName.Focus();
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your Email.", "Entry Error");
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        //Event Handlers
        private void cmbDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            order.DiscountType = cmbDiscountType.SelectedIndex;
            UpdateLabelTotals();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            smoothiesList.Clear();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid() && customer.Paid)
            {
                MessageBox.Show("Thank you!" + "\n" + "Your order will be out soon!.", "Order Complete");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose a payment method.");
            }
        }

        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
         
            if (IsValid())
            {
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.Email = txtEmail.Text;
                PaymentForm paymentForm = new PaymentForm();
                paymentForm.PassInCustomer(customer);
                paymentForm.ShowDialog();
                customer = paymentForm.GetCustomer();
                if (customer.Cash)
                {
                    lblPaymentMethod.Text = "Paid with Cash";
                    lblCardType.Text = $"Received {customer.CashReceived.ToString("C2")}";
                    lblChange.Text = $"Change:  {(customer.CashReceived - order.OrderTotal).ToString("C2")}";
                    EnableCashLabels();
                }
                else
                {
                    lblPaymentMethod.Text = $"Paid with credit card.";
                    lblCardType.Text = $"{customer.CardType}";
                    lblCardNumber.Text = $"{customer.CardNumber}";
                    lblExpirationDate.Text = $"{customer.Expiration}";
                    EnableCreditLabels();
                }

                
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            customer.Email = txtEmail.Text;
            if (File.Exists(customerFileName))
            {
                bool success = false;
                FileStream inFile = new FileStream(customerFileName, FileMode.Open, FileAccess.Read);
                while (!success && inFile.Position < inFile.Length)
                {
                    Customer tempCustomer = new Customer();
                    tempCustomer = (Customer)bFormatter.Deserialize(inFile);
                    if (tempCustomer.Email == customer.Email)
                    {
                        success = true;
                        customer.CardNumber = tempCustomer.CardNumber;
                        customer.CardType = tempCustomer.CardType;
                        customer.Expiration = tempCustomer.Expiration;
                        customer.Paid = true;
                        ReturningCustomers();
                    }
                }
                inFile.Close();
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMessage = "Author: Cindy Breneman-Winters \n";
            aboutMessage += "Description: Computerized ordering system for Smoothie Queen \n";
            aboutMessage += "  \n";
            aboutMessage += "Copyright - April 28, 2019";

            MessageBox.Show(aboutMessage, "About");


        }
    }
}
