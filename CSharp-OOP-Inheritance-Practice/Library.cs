using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Inheritance_Practice
{
    internal class Library
    {
        public Book[] Books = new Book[0];

        public Book[] AddBook(Book[] booksFromUser)
        {
            if (Books.Length>0)
            {

            Book[] books = new Book[Books.Length + booksFromUser.Length];
            for (int i = 0; i < Books.Length; i++)
            {
                books[i] = Books[i];
            }

            for (int i = Books.Length; i < books.Length; i++)
            {
                books[i] = booksFromUser[i];
            }
            
            this.Books = books;
            return this.Books;

            }
            else
            {
                this.Books = booksFromUser;
                return this.Books;
            }
        }
    }
}
