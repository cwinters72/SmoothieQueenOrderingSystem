/**********************************************************
 * Author:  Cindy Breneman-Winters
 * Program Name:  Smoothie Queen Ordering System
 * Class:  Smoothie Class
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
    public class Smoothie
    {
        //Constants for Program Maintenance
        const double BASE_PRICE = 5.99;
        const double ORGANIC_PRICE = 1.00;
        const double ADD_INS = .75;

        //Private Fields
        private int size;
        private bool organic = false;
        private int addInCount;
        private double price;
        private double sizeCharge;
        private double organicCharge;
        private double addInCharge;
        private int quantity;

        //Public Properties
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                GetPrice();
            }
        }
        public double SizeCharge
        {
            get
            {
                return sizeCharge;
            }
        }
        public double OrganicCharge
        {
            get
            {
                return organicCharge;
            }
        }
        public double AddInCharge
        {
            get
            {
                return addInCharge;
            }
        }
        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
                GetPrice();
               
            }


        }
        public bool Organic
        {
            get
            {
                return organic;
            }
            set
            {
                organic = value;
                GetPrice();
            }
        }
        public int AddInCount
        {
            get
            {
                return addInCount;
            }
            set
            {
                addInCount = value;
                GetPrice();
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            
        }

        //Constructors
        public Smoothie()
        {
            
            this.AddInCount = 0;
            this.Quantity = 1;
        }
        public Smoothie(Smoothie smoothie)
        {
            this.Size = smoothie.Size;
            this.Quantity = smoothie.Quantity;
            this.Organic = smoothie.Organic;
            this.AddInCount = smoothie.AddInCount;

        }


        //Methods to set price
        private void GetPrice()
        {
            
            sizeCharge = BASE_PRICE;
            organicCharge = 0;
            addInCharge = 0;

            if (size == 1)
                {
                    sizeCharge += 1;
                }
            else if (size == 2)
                {
                     sizeCharge += 2;
                }
            else if (size == 3)
                {
                    sizeCharge += 3;
                }
            if (organic)
            {
                organicCharge += 1;
            }
            if (addInCount > 0)
            {
                addInCharge += addInCount * ADD_INS;
            }
            price = (sizeCharge + organicCharge + addInCharge) * quantity;


        }

    }
}
