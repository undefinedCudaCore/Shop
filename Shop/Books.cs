using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class Books
    {
        public int quantityNumber { get; set; }
        public double priceNumber { get; set; }

        public void SetQuantity(int value)
        {
            quantityNumber += value;
        }
        public int GetQuantity()
        {
            return quantityNumber;
        }
        public void SetPrice(double value)
        {
            priceNumber += value;
        }
        public double GetPrice()
        {
            return priceNumber;
        }
        public string GetName()
        {
            string nameOfBook = "Books";
            return nameOfBook;
        }
    }
}
