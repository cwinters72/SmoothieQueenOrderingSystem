/**********************************************************
 * Author:  Cindy Breneman-Winters
 * Program Name:  Smoothie Queen Ordering System
 * Class:  Customer Class
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
{   [Serializable]
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string CardType { get; set; }

        public string CardNumber { get; set; }

        public string Expiration { get; set; }

        public double CashReceived { get; set; }

        public bool SavedCard { get; set; }

        public bool Cash { get; set; }

        public bool Paid { get; set; }


        
    }
}
