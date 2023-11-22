using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_DavidAbarca_Classes2
{ 

    public class Item
    {
        // Fields
        string _name;
        string _description;
        double _price;
        double _discount;

        // Constructor
        public Item(string name, string description, double price, double discount)
        {
            // Field = argument
            _name = name;
            _description = description;
            _price = price;
            _discount = discount;

        } // Item
          // Take a name, and a price
        public Item(string name, double price)
        {
            _name = name;
            _price = price;
            _description = "";
            _discount = 0;
        }


        // access modifier - Return Type - Name ( Same as the Field )
        // DOES NOT TAKE PARAMETERS
        public string Name
        {
            // This is a get, it lets the user READ the value
            get
            {
                return _name;


            }


            set
            {
                _name = value;
            }



        }


        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }




        public double Price
        {
            get { return _price; }
            set
            {
                // Prevent a negative number from being ASSIGNED to an item
                if (value >= 0)
                {
                    _price = value;
                }
            }
        } // Price


        public double Discount
        {
            get { return _discount; }
            set
            {
                // 0 --------------------- 1
                if (value >= 0 && value <= 1)
                {
                    _discount = value;
                }
            }
        }


        // Class Method
        public double DiscountedAmount()
        {
            return Price * Discount;
        }
        public double CalculateTotalPrice()
        {
            return Price - DiscountedAmount();
        }

        // OVERRIDE ToString()
        public override string ToString()
        {
            // Name: Granny Smith - Price: $1.50 - Discount: $0.15 - Total Price: $1.35
            return $"Name: {_name} - Price: {_price.ToString("c")} - Discount:  {DiscountedAmount().ToString("c")} - Total Price: {CalculateTotalPrice().ToString("c")}";
        } // ToString()


    }




}
