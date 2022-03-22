using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Inheritance_Practice
{
    internal class Book:Product
    {
        public string Genre;

        public Book(int no, string name, int price, string genre, int count = 0):base(no,name,price)
        {
            Genre = genre;
        }
    }
}
