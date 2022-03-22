using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Inheritance_Practice
{
    internal class Library
    {
        public Book[] Books;

        int a = 0;
        public Book[] AddBook(Book book)
        {
            Books[a++] = book;
            return Books;
        }

        public Book[] GetFilteredBooks(string genre)
        {
            int n = 0;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre==genre)
                {
                    n++;
                }
            }

            Book[] newBooks = new Book[n];
            int j = 0;

            for (int i = 0; i < newBooks.Length; i++)
            {
                newBooks[j] = Books[i];
                j++;
            }
            return newBooks;

        }
        public Book[] GetFiltererdBooks(double minPrice, double maxPrice)
        {
            int count = 0;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price >= minPrice && Books[i].Price <= maxPrice)
                {
                    count++;
                }
            }
            Book[] newBooks = new Book[count];
            int j = 0;

            for (int i = 0; i < newBooks.Length; i++)
            {
                newBooks[j] = Books[i];
                j++;
            }
            return newBooks;
        }

        public void BookInfo(Book[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine($"Name:{item.Name} Genre:{item.Genre} No:{item.No} Price:{item.Price} Count:{item.Count}");
            }
        }
    }
}
