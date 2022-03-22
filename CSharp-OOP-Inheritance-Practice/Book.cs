using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Inheritance_Practice
{
    internal class Book:Product
    {
        public string Genre;

        public Book(int no, string name, double price, string genre, int count):base(no,name,price,count)
        {
            Genre = genre;
        }
        public Book(int no, string name, double price, string genre) : base(no, name, price)
        {
            Genre = genre;
        }
    }
}
