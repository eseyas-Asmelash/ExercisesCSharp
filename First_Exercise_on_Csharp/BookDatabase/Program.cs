using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookDatabase
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            string input;

            Console.WriteLine("Hello, This is a program that saves your favorite books in a file");
            Console.WriteLine("This is Your Main Menu You can choose from the following options:");
            Console.WriteLine("Input \"add\" if you want to add");
            Console.WriteLine("Input \"show\" if you want to show your books");
            Console.WriteLine("Input \"remove\" if you want to remove a book from you book list");
            Console.WriteLine("Input \"quit\" if you want to remove quit this program");
            Console.WriteLine();

            do
            {
                Console.Write("Input you choose: ");
                input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "add":
                        AddBook();
                        break;
                    case "show":
                        ShowBooks();
                        break;
                    case "remove":
                        RemoveBook();
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
            }
            while (input != "quit");

        }

        static void AddBook()
        {
            List<string> newBooks = new List<string>();

            int books = 0;
            try
            {
                Console.Write("how many books do you want to add: ");
                books = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Wrong input :( start over from the top");
            }


            for (int i = 0; i < books; i++)
            {
                Console.Write("Enter a new book title: ");
                string newTitle = Console.ReadLine();
                Console.Write("Enter the author of the book: ");
                string newAuthor = Console.ReadLine();

                newBooks.Add(newTitle + " " + newAuthor);
            }
            File.AppendAllLines(@"bookdatabase.txt", newBooks);

            foreach (string temp in newBooks)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();
        }
        static void ShowBooks()
        {
            string[] textOne = File.ReadAllLines(@"bookdatabase.txt");
            for (int i = 0; i < textOne.Length; i++)
            {
                Console.WriteLine(textOne[i]);
            }
        }
        static void RemoveBook()
        {

            Console.Write("Which book do you want to remove? (write the title and author): ");
            string bookToRemove = Console.ReadLine();

            string[] bookList = File.ReadAllLines(@"bookdatabase.txt");

            bookList = bookList.Where(book => book != bookToRemove).ToArray();

            File.WriteAllLines(@"bookdatabase.txt", bookList);

            ShowBooks();
            Console.WriteLine();
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
