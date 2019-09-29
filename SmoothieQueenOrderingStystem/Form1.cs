/**********************************************************
 * Author:  Cindy Breneman-Winters
 * Program Name:  Smoothie Queen Ordering System
 * Class:  MainForm Class
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

namespace SmoothieQueenOrderingStystem
{
    public partial class frmSmoothieQueen : Form
    {
        //Instantiate class wide variables
        string[] sizeArray = new string[4] { "Small", "Medium", "Large", "King"};
        Smoothie smoothie = new Smoothie();
        List<Smoothie> smoothieOrder = new List<Smoothie>(); 

        //Method to setup form when loaded or refreshed
        private void SetUpForm()
        {
            int smoothiesInOrder = 0;
            foreach (Smoothie item in smoothieOrder)
            {
                smoothiesInOrder += item.Quantity;
            }
            lblNumOfSmoothies.Text = $"Num of Smoothies:  {smoothiesInOrder}";
            cmbSizesList.SelectedIndex = -1;
            rdoRegular.Checked = true;
            numQuantity.Value = 1;
            chkAcaiPowder.Checked = false;
            chkChiaSeeds.Checked = false;
            chkEnergyBooster.Checked = false;
            chkGojiBerries.Checked = false;
            chkMesquitePowder.Checked = false;
            lblSize.Text = "Size Charge:  ";
            lblAddInCharge.Text = "Add In Charge:  ";
            lblOrganic.Text = "Organic Charge:  ";
            lblSmoothieTotal.Text = "Smoothie Total:  ";
            smoothie = new Smoothie();
            cmbSizesList.Text = "Select Your Size";
        }

        //Validation Method
        private bool IsValid()
        {
            if (cmbSizesList.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a size.", "Order error.");
                cmbSizesList.Focus();
                return false;

            }
            else
            {
                return true;
            }
        }

        //Order Validation Method
        private bool IsOrderValid()
        {
            if (smoothieOrder.Count == 0)
            {
                MessageBox.Show("You must add at least one smoothie.", "Order error.");
                cmbSizesList.Focus();
                return false;

            }
            else
            {
                return true;
            }
        }

        //Form Constructor
        public frmSmoothieQueen()
        {
            InitializeComponent();
        }


        //Event Handler Methods
        private void SmoothieQueen_Load(object sender, EventArgs e)
        {
            cmbSizesList.Items.AddRange(sizeArray);
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
               
                smoothieOrder.Add(new Smoothie(smoothie));
                SetUpForm();

            }
            
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (IsOrderValid())
            {
                OrderForm orderForm = new OrderForm();  //Instantiate the OrderForm
                orderForm.PassOrderList(smoothieOrder);  //Pass the list of smoothies into the next form
                
                this.Hide();  //Hide Main form
                orderForm.ShowDialog();  //Show populated Order Form
                this.Show();  // reopen Main form when order form closes
                smoothieOrder.Clear();  //Reset order list
                SetUpForm();  //Refresh Labels
            }

        }

        private void cmbSizesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            smoothie.Size = cmbSizesList.SelectedIndex;
            lblSize.Text = $"Size Charge:  {smoothie.SizeCharge.ToString("C2")}";
            lblSmoothieTotal.Text = $"Smoothie Total:  {smoothie.Price.ToString("C2")}";
        }

        private void rdoRegular_CheckedChanged(object sender, EventArgs e)
        {
            smoothie.Organic = false;
            lblOrganic.Text = $"Organic Charge:  {smoothie.OrganicCharge.ToString("C2")}";
            if (cmbSizesList.SelectedIndex >= 0)
            {
                lblSmoothieTotal.Text = $"Smoothie Total:  {smoothie.Price.ToString("C2")}";
            }
        }

        private void rdoOrganic_CheckedChanged(object sender, EventArgs e)
        {
            smoothie.Organic = true;
            lblOrganic.Text = $"Organic Charge:  {smoothie.OrganicCharge.ToString("C2")}";
            if (cmbSizesList.SelectedIndex >= 0)
            {
                lblSmoothieTotal.Text = $"Smoothie Total:  {smoothie.Price.ToString("C2")}";
            }
        }

        private void chkAcaiPowder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAcaiPowder.Checked)
            {
                smoothie.AddInCount += 1;

            }
            else
            {
                smoothie.AddInCount -= 1;
            }
            lblAddInCharge.Text = $"Add In Charge:  {smoothie.AddInCharge.ToString("C2")}";
            if (cmbSizesList.SelectedIndex >= 0)
            {
                lblSmoothieTotal.Text = $"Smoothie Total:  {smoothie.Price.ToString("C2")}";
            }
        }

        private void chkChiaSeeds_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChiaSeeds.Checked)
            {
                smoothie.AddInCount += 1;

            }
            else
            {
                smoothie.AddInCount -= 1;
            }
            lblAddInCharge.Text = $"Add In Charge:  {smoothie.AddInCharge.ToString("C2")}";
            if (cmbSizesList.SelectedIndex >= 0)
            {
                lblSmoothieTotal.Text = $"Smoothie Total:  {smoothie.Price.ToString("C2")}";
            }
        }

        private void chkEnergyBooster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnergyBooster.Checked)
            {
                smoothie.AddInCount += 1;

            }
            else
            {
                smoothie.AddInCount -= 1;
            }
            lblAddInCharge.Text = $"Add In Charge:  {smoothie.AddInCharge.ToString("C2")}";
            if (cmbSizesList.SelectedIndex >= 0)
            {
                lblSmoothieTotal.Text = $"Smoothie Total:  {smoothie.Price.ToString("C2")}";
            }
        }

        private void chkGojiBerries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGojiBerries.Checked)
            {
                smoothie.AddInCount += 1;

            }
            else
            {
                smoothie.AddInCount -= 1;
            }
            lblAddInCharge.Text = $"Add In Charge:  {smoothie.AddInCharge.ToString("C2")}";
            if (cmbSizesList.SelectedIndex >= 0)
            {
                lblSmoothieTotal.Text = $"Smoothie Total:  {smoothie.Price.ToString("C2")}";
            }
        }

        private void chkMesquitePowder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMesquitePowder.Checked)
            {
                smoothie.AddInCount += 1;

            }
            else
            {
                smoothie.AddInCount -= 1;
            }
            lblAddInCharge.Text = $"Add In Charge:  {smoothie.AddInCharge.ToString("C2")}";
            if (cmbSizesList.SelectedIndex >= 0)
            {
                lblSmoothieTotal.Text = $"Smoothie Total:  {smoothie.Price.ToString("C2")}";
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            smoothie.Quantity = Convert.ToInt32(numQuantity.Value);
            if (cmbSizesList.SelectedIndex >= 0)
            {
                lblSmoothieTotal.Text = $"Smoothie Total:  {smoothie.Price.ToString("C2")}";
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
