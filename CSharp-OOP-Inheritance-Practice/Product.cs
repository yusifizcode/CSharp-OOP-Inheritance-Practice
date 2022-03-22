using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Inheritance_Practice
{
    internal class Product
    {
        public int No;
        public string Name;
        public int Price;
        public int Count;

        public Product(int no, string name, int price, int count=0)
        {
            No = no;
            Name = name;
            Price = price;
            Count = count;
        }
    }
}
