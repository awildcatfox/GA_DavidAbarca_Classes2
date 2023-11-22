using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_DavidAbarca_Classes2
{


    internal class ShopingCart
    {
        // Fields
        string _storeName;
        List<Item> _itemsInCart;
        double _tax;




        // Constructor
        public ShopingCart(string storeName)
        {
            _storeName = storeName;
            _itemsInCart = new List<Item>();
            _tax = .1;
        } // ShoppingCart()



        // Properties
        public string StoreName
        {
            get => _storeName; // This is shorthand for get
            set => _storeName = value; // This is shorthand for set
        } // StoreName


        public List<Item> ItemsInCart
        {
            get
            {
                return _itemsInCart;
            }
        }

        public double Tax
        {
            get => _tax;
        } // Tax



        public void AddItem(Item item)
        {
            _itemsInCart.Add(item);
        } // 

        public double TotalBeforeTax()
        {
            double sum = 0;
            foreach (Item item in _itemsInCart)
            {
                sum += item.CalculateTotalPrice();
            }

            return sum;
        } // TotalBeforeTax()


        public double TaxOnTotal()
        {
            return TotalBeforeTax() * _tax;
        } // TaxOnTotal()


        public double TotalPrice()
        {
            return TotalBeforeTax() + TaxOnTotal();
        } // TotalPrice()

        public string Receipt()
        {
            // This C# object will help us display the exact time the receipt is processed
            DateTime dto = DateTime.Now;
            // Creating an empty string to start formatting.
            string fullReceipt = "";

            // Concatenating our store name into our receipt
            fullReceipt += $"Welcome to {_storeName}\n";
            // Displaying the current day and time on the receipt
            fullReceipt += $"Date: {dto.ToShortDateString()} {dto.ToLongTimeString()}";
            fullReceipt += $"\n-----\n\n";
            fullReceipt += $"Items\n";

            // Using a foreach loop, we go through the items in our cart and concatenate the .ToString() to our receipt string. This will show every item in our cart.
            foreach (Item item in _itemsInCart)
            {
                fullReceipt += $"{item.ToString()}\n";
            }

            // Displays all the final calculations and the final total
            fullReceipt += $"\n-----\n\n";
            fullReceipt += $"Number Of Items : {_itemsInCart.Count}\n";
            fullReceipt += $"Total Before Tax : {TotalBeforeTax().ToString("c")}\n";
            fullReceipt += $"Tax : {TaxOnTotal().ToString("c")}\n";
            fullReceipt += $"Total Price : {TotalPrice().ToString("c")}\n";
            return fullReceipt;
        } // Receipt


    }

}
