/**********************************************************
 * Author:  Cindy Breneman-Winters
 * Program Name:  Smoothie Queen Ordering System
 * Class:  Order Class
 * Date:  04/28/2018
 * Description: Multiform Ordering system for 
 *      Smoothie Queen with payment and order
 *      management
 * *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothieQueenOrderingStystem
{
    class Order
    {
        //Constants for Program Maintenance
        const double SALES_TAX = .0925;
        const double PREFERRED_CUST = .15;
        const double COUPON = .1;

        //Private fields
        private int smoothieCount;
        private double subTotal;
        private double discount;
        private double orderTotal;
        private List<Smoothie> smoothies;
        private double taxTotal;
        private int discountType;

        //Public Properties
        public int DiscountType
        {
            get
            {
                return discountType;
            }
            set
            {
                discountType = value;
                CalculateTotal();
            }
        }
       
        public List<Smoothie> Smoothies
        {
            get
            {
                return smoothies;
            }
            set
            {
                smoothies = value;
                CalculateTotal();
            }
        }
        public int SmoothieCount
        {
            get
            {
                return smoothieCount;
            }
        
        }
        public double TaxTotal
        {
            get
            {
                return taxTotal;
            }
        }
        public double Discount
        {
            get
            {
                return discount;
            }
        }

        public double SubTotal
        {
            get
            {
                return subTotal;
            }
        }
        public double OrderTotal
        {
            get
            {
                return orderTotal;
            }
        }

        //Constructors
        public Order()
        {

        }

        public Order(List<Smoothie> smoothies)
        {
            this.Smoothies = smoothies;

        }
        
        //Class Methods to Calculate totals
        private void CalculateTotal()
        {
            smoothieCount = 0;
            subTotal = 0;
            discount = 0;
            orderTotal = 0;
            taxTotal = 0;
            foreach (Smoothie smoothie in smoothies)
            {
                smoothieCount += smoothie.Quantity;
                subTotal += smoothie.Price;
                
            }
            if (discountType == 1)
            {
                discount = subTotal * PREFERRED_CUST;
            
            }
            else if (discountType == 2)
            {
                discount = subTotal * COUPON;
            }
            else
            {
                discount = 0;
            }
            taxTotal = (subTotal - discount) * SALES_TAX;
            orderTotal = subTotal - discount + taxTotal;

        }
   

    }
}
