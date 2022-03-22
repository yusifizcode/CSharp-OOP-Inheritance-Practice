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
            int bookCount = 0;
            do
            {
                Console.WriteLine("Elave edilecek kitablarin sayini yazin: ");
                bookCount = Convert.ToInt32(Console.ReadLine());
            } while (bookCount<=0);

            Library library = new Library();
            library.Books = new Book[bookCount];

            for (int i = 0; i < bookCount; i++)
            {
                string bookName = "";
                do
                {
                    Console.WriteLine($"{i + 1}. kitabin adini daxil edin: ");
                    bookName = Console.ReadLine();
                } while (bookName.Length <= 1 || bookName.Length >= 50);


                string bookGenre = "";
                do
                {
                    Console.WriteLine($"{i+1}. kitabin janrini daxil edin: ");
                    bookGenre = Console.ReadLine();
                } while (bookGenre.Length <= 3 || bookGenre.Length >= 20);


                int bookNo = 0;
                bool check = true;
                while (check)
                {
                    check = false;
                    Console.WriteLine($"{i+1}. kitabin nomresini daxil edin: ");
                    bookNo = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j < i; j++)
                    {
                        if (library.Books[j].No == bookNo)
                        {
                            check = true;
                            break;
                        }
                    }
                }


                double bookPrice = 0;
                do
                {
                    Console.WriteLine($"{i+1}. kitabin qiymetini daxil edin: ");
                    bookPrice = Convert.ToDouble(Console.ReadLine());
                } while (bookPrice<=0);

                int count = 0;
                do
                {
                    Console.WriteLine($"{i+1}. kitabin sayini daxil edin: ");
                    count = Convert.ToInt32(Console.ReadLine());
                } while (count<=0);
                Book book = new Book(bookNo, bookName, bookPrice, bookGenre, count);
                library.AddBook(book);
                Console.WriteLine("book arr length --> "+library.Books.Length);
                //Console.WriteLine($"{i+1}. kitab: "+"ADI: "+library.Books[i].Name+" Nomresi: "+library.Books[i].No+ " Qiymeti: "+ library.Books[i].Price+ " Sayi: "+ library.Books[i].Count+" Janri: " + library.Books[i].Genre);
            }


            string answer = "";

            do
            {
                Console.WriteLine("Filterlemek isteyirsinizmi?y/n");
                answer = Console.ReadLine();
            } while (answer != "y" && answer != "Y" && answer != "n" && answer != "N");
            if (answer == "y" || answer == "Y")
            {
                string filterAnswer = "";
                do
                {
                    Console.WriteLine("1 - Janr adina gore , 2 - Qiymet intervalina gore");
                    filterAnswer = Console.ReadLine();
                } while (filterAnswer != "1" && filterAnswer != "2");
                if (filterAnswer=="1")
                {
                    Console.WriteLine("Filter etmek istediyiniz janri daxil edin: ");
                    string filterGenre = Console.ReadLine();
                    library.BookInfo(library.GetFilteredBooks(filterGenre));
                }
                else
                {
                    Console.WriteLine("Filter etmek istediyiniz qiymet araligini secin: ");
                    Console.WriteLine("Minimum qiymet: ");
                    double min = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Maksimum qiymet: ");
                    double max = Convert.ToDouble(Console.ReadLine());
                    library.BookInfo(library.GetFiltererdBooks(min,max));

                }
            }
            else
            {
                library.BookInfo(library.Books);
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


        
    }
}
