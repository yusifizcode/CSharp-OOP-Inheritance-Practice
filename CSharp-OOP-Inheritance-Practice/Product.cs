using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Inheritance_Practice
{
    internal class Product
    {
        public int No;
        public string Name;
        public double Price;
        public int Count;

        public Product(int no, string name, double price, int count)
        {
            No = no;
            Name = name;
            Price = price;
            Count = count;
        }

        public Product(int no, string name, double price)
        {
            No = no;
            Name = name;
            Price = price;
        }
    }
}
