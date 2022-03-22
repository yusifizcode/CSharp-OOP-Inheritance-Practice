using System;

namespace CSharp_OOP_Inheritance_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1 - task2
            Notebook n1 = new Notebook
            {
                Name = "Legion 540",
                BrandName = "Lenovo",
                Price = 3000,
            };
            Notebook n2 = new Notebook
            {
                Name = "ZenBook",
                BrandName = "Asus",
                Price = 4000,
            };
            Notebook n3 = new Notebook
            {
                Name = "GP76 LEOPARD",
                BrandName = "MSI",
                Price = 2000,
            };
            double minPrice = 2500;
            double maxPrice = 4500;
            Notebook[] arr = {n1, n2, n3};

            foreach (var item in FindPrice(arr,minPrice,maxPrice))
            {
                Console.WriteLine($"{minPrice} - {maxPrice} araligindaki notebook qiymetleri: {item}");
            }


            //task3
            Book book = new Book(1, "In Search of Lost Time", 50, "adventure");
            Book book1 = new Book(1, "Ulysses", 20, "dram");
            Book book2 = new Book(1, "Don Quixote", 70, "dedective");
            Book book3 = new Book(1, "One Hundred Years of Solitude", 100, "fantastic");

            Library library = new Library();
            //library.Books[0] = book1;
            //library.Books[1] = book2;
            //library.Books[2] = book3;




            //foreach (var item in library.AddBook(book))
            //{
            //    Console.WriteLine(item.Name,item.Genre,item.Price,item.No);
            //}


            Console.WriteLine("Elave edilecek kitablarin sayini daxil edin: ");
            int bookCount = Convert.ToInt32(Console.ReadLine());
            //library.AddBook(book);

            foreach (var item in library.AddBook(BooksToBeAdded(bookCount)))
            {
                Console.WriteLine(item.Name, item.Genre, item.Price, item.No);
            }
        }

        static double[] FindPrice(Notebook[] arr, double minPrice, double maxPrice)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Price >= minPrice && arr[i].Price <= maxPrice)
                {
                    count++;
                }
            }
            double[] newArr = new double[count];

            for (int i = 0; i < newArr.Length; i++)
            {
                if (arr[i].Price >= minPrice && arr[i].Price <= maxPrice)
                {
                    newArr[i] = arr[i].Price;
                }
            }

            return newArr;

        }


        static Book[] BooksToBeAdded(int val)
        {
            int[] bookNos = new int[val];
            Book[] books = new Book[val];


            for (int i = 0; i < books.Length; i++)
            {

                Console.WriteLine($"{i + 1}. kitabin nomresini daxil edin:");
                int bookNo = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < bookNos.Length; j++)
                {
                    if (bookNo == bookNos[j] && bookNo > 0)
                    {
                        Console.WriteLine("Bu nomre daxil edile bilmez.");
                        break;
                    }
                    else
                    {
                        books[i].No = bookNo;
                        bookNos[j] = j;
                    }
                }

                Console.WriteLine($"{i}. kitabin adini daxil edin:");
                string bookName = Console.ReadLine();
                if (bookName.Length < 1 && bookName.Length > 50)
                {
                    Console.WriteLine("Bu ad daxil edile bilmez.");
                }
                else
                {
                    books[i].Name = bookName;
                }

                Console.WriteLine($"{i}. kitabin janrini daxil edin:");
                string bookGenre = Console.ReadLine();
                if (bookGenre.Length < 3 && bookGenre.Length > 20)
                {
                    Console.WriteLine("Bu ad daxil edile bilmez.");
                }
                else
                {
                    books[i].Genre = bookGenre;
                }

                Console.WriteLine($"{i}. kitabin qiymetini daxil edin:");
                int bookPrice = Convert.ToInt32(Console.ReadLine());
                if (bookPrice < 0)
                {
                    Console.WriteLine("Bu qiymet daxil edile bilmez.");
                }
                else
                {
                    books[i].Price = bookPrice;
                }

                Console.WriteLine($"{i}. kitabin sayini daxil edin:");
                int bookCount = Convert.ToInt32(Console.ReadLine());
                if (bookCount < 0)
                {
                    Console.WriteLine("Bu say daxil edile bilmez.");
                }
                else
                {
                    books[i].Count = bookCount;
                }
            }
            return books;
        }
    }
}
