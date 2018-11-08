using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Library
{
    class Book
        {
            private string title;
            private string author;

            public string Title
            {
                get
                {
                    return title;
                }
                set
                {
                    title = value;
                }
            }
            public string Author
            {
                get
                {
                    return author;
                }
                set
                {
                    author = value;
                }
            }
            public Book(string t, string a)
            {
                title = t;
                author = a;
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookClassList = new List<Book>();
            bookClassList.Add(new Book("The Name of the Wind", "Patrick Rothfuss"));
            bookClassList.Add(new Book("Call of the Wild", "Jack London"));
            bookClassList.Add(new Book("House of Leaves", "Mark Z. Danielewski"));
            bookClassList.Add(new Book("Of Mice and Men", "John Steinbeck"));
            bookClassList.Add(new Book("To Kill a Mockingbird", "Harper Lee"));
            bookClassList.Add(new Book("Oh, the Places You'll Go", "Dr. Seuss"));
            bookClassList.Add(new Book("The Adventures of Winnie the Pooh", "Ralph Wright"));
            bookClassList.Add(new Book("The Giving Tree", "Shel Silverstein"));
            bookClassList.Add(new Book("Where the Wild Things Are", "Dave Pelzer"));
            bookClassList.Add(new Book("The Child Called It", "Dave Pelzer"));
            bookClassList.Add(new Book("Green Eggs and Ham", "Dr.Seuss"));
            //input
            Console.WriteLine("Welcome to the Grand Circus Libray");
            while (true)
            {
                string userTask = UserInput("What task would you like to complete? \n1. Search by title \n2. Search by author \n3. Quit?");
                while (userTask != "1" && userTask != "2" && userTask != "3")
                {
                    userTask = UserInput("I'm sorry please enter either 1, 2, or 3.");
                }
                if (userTask == "1")
                {
                    string bookSearch = UserInput("What title would you like to look up?").ToLower();
                    //processing
                    List<Book> bookMatches = new List<Book>();

                    foreach (Book book in bookClassList)
                    {
                        if (book.Title.ToLower().Contains(bookSearch))
                        {
                            bookMatches.Add(book);
                        }
                    }
                    foreach (Book book in bookMatches)
                    {
                        Console.WriteLine($"Title: {book.Title} by Author: {book.Author}");
                    }
                    if (bookMatches.Count == 0)
                    {
                        Console.WriteLine("I'm sorry that book does not exist!!!");
                    }
                }
                else if (userTask == "2")
                {
                    //input
                    string authorSearch = UserInput("What author do you want to look up?").ToLower();
                    //processing
                    List<Book> authorMatches = new List<Book>();

                    foreach (Book author in bookClassList)
                    {
                        if (author.Author.ToLower().Contains(authorSearch))
                        {
                            authorMatches.Add(author);
                        }
                    }
                    foreach (Book author in authorMatches)
                    {
                        Console.WriteLine($"Title: {author.Title} by Author: {author.Author}");
                    }
                    if (authorMatches.Count == 0)
                    {
                        Console.WriteLine("I'm sorry that author does not exist!!!");
                    }
                }
                else if (userTask == "3")
                {
                    Console.WriteLine("GoodBye");
                    break;
                }
            }
        }
        public static string UserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
    }
}
