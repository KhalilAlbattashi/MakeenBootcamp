using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace LibraryMS
{

    public class Program
    {
        public class LibraryManagementSystem
        {
            public string[] namesOfTheBooks;
            public string[] authors;
            public int len;
            public int counter = 0;
            public LibraryManagementSystem(int len)
            {
                this.len = len;
                this.namesOfTheBooks = new string[len];
                this.authors = new string[len];
            }
            // set, get indexers 
            public string this[int idx, string name]
            {
                get
                {
                    // return the author at the index idx
                    return authors[idx];
                }
                set
                {   
                    // set the author name for the given book
                    namesOfTheBooks[idx] = name;
                    authors[idx] = value; // value preserved keyword. 
                }
            }
            public string this[string name]
            {
                get
                {
                    // find the author name of the given book name
                    for (int i = 0; i < len; i++)
                    {
                        if (namesOfTheBooks[i] == name)
                            return authors[i];

                    }
                    return "not found";
                }
            }

            public void BorrowBook(string name)
            {   
                for(int i = 0; i < namesOfTheBooks.Length; i++)
                {
                    if (namesOfTheBooks[i] == name)
                    {
                        namesOfTheBooks[i] = "";
                        authors[i] = "";
                    }
                }
            }

            public void ReturnBook(string author, string name)
            {
                for(int i = 0; i < len; i++)
                {
                    if (authors[i]=="" && namesOfTheBooks[i] == "")
                    {
                        authors[i] = author;
                        namesOfTheBooks[i] = name;
                    }
                    else
                    {
                        Console.WriteLine("No Available Space");
                    }
                }
            }
            public void printBooks()
            {
                Console.WriteLine("------Available Books------");
                for (int i = 0; i < len; i++)
                {
                    if (namesOfTheBooks[i] == "" && authors[i] == "")
                    {
                        continue;
                    }
                    Console.WriteLine($"{namesOfTheBooks[i]} ::: {authors[i]}");
                }
                Console.WriteLine("---------------------------");

            }
        }
        static void Main(string[] args)
        {
            LibraryManagementSystem b = new LibraryManagementSystem(10);

            b[0, "House of Dragons"] = "Khalil";
            b[1, "Game of Thrones"] = "R.R Martin";
            b[2, "The India Story"] = "Bimal Jalal";
            b[3, "Listen to Your Heart: The London Adventure"] = "Ruskin Bond";
            b[4, "Business of Sports: The Winning Formula for Success"] = "Vinit Karnik";
            b[5, "A Place Called Home"] = "Preeti Shenoy";
            b[6, "The Struggle for Police Reforms in India"] = "Ex-IPS Prakash Singh";
            b[7, "Pride, Prejudice and Punditry"] = "Shashi Tharoor";
            b[8, "Queen of Fire"] = "Devika Rangachari";
            b[9, "The Maverick Effect"] = "Harish Mehta";

            Console.WriteLine("Library Management System");
            Console.WriteLine("------Options------");
            Console.WriteLine("0. Print Available Books");
            Console.WriteLine("1. Borrow Book");
            Console.WriteLine("2. Return Book");
            Console.WriteLine("-------------------");

            while (true)
            {
                string sInput = Console.ReadLine();
                int option = int.Parse(sInput);

                switch (option)
                {
                    case 0:
                        b.printBooks();
                        break;
                    case 1:
                        Console.WriteLine("Enter the Name of the Book: ");
                        string bookName = Console.ReadLine();
                        b.BorrowBook(bookName);
                        break;
                    case 2:
                        Console.WriteLine("Enter the author Name: ");
                        string Author = Console.ReadLine();
                        Console.WriteLine("Enter the Book Name: ");
                        string Book = Console.ReadLine();
                        b.ReturnBook(Author, Book);
                        break;
                }
            }
            
        }
    }
}