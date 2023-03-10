
using MidtermGroupProject;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using static System.Reflection.Metadata.BlobBuilder;
using System.Linq;

string filePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"../../../", "Media.txt");
Library library = new();
//Search search= new();
FileIO fileio = new(filePath);
//wip-library_check_in/out
List<Media> mediaList = fileio.FileRead();


do
{

    Console.WriteLine("Welcome to the Library!");
    Console.WriteLine("To see a list of available books, type \"List\" ");
    Console.WriteLine("To search for a book, type \"Search\" ");
    Console.WriteLine("To return a book, type \"Return\" ");
    Console.WriteLine("To check out a book, type \"Check Out\" ");
    Console.WriteLine();

    string input1 = Console.ReadLine().ToLower();
    Console.WriteLine();

    if (input1 == "list")
    {

        foreach (Book book in mediaList)
        {

            Console.WriteLine("Title: " + book.Title + ".  ");
            Console.WriteLine("Author: " + book.Author + ".  ");
            Console.WriteLine("Status: " + book.Status + ".  ");
            Console.WriteLine("Check Out Date: " + book.CheckOutDate + ".  ");
            Console.WriteLine("Due Date: " + book.DueDate + ".  ");
            Console.WriteLine("Media Type:" + book.Type + ".  ");
            Console.WriteLine();
            Console.WriteLine();

        }


    }
    else if (input1 == "search")
    {

        Console.WriteLine("Would you like to search by Title, or by Author?");
        string input2 = Console.ReadLine().ToLower();

        if (input2 == "title")
        {

            Console.WriteLine("Please enter the book title youd like to search for: ");
            string titleInput = Console.ReadLine();
            string title = titleInput.ToLower();

            List<Media> searchResults = mediaList.Where(book => book.Title.ToLower().Contains(title)).ToList();

            Console.WriteLine("Here are all book(s) with the title: " + titleInput);

            foreach (Book book in searchResults)
            {
                Console.WriteLine();
                Console.WriteLine("Title: " + book.Title + ".  ");
                Console.WriteLine("Author: " + book.Author + ".  ");
                Console.WriteLine("Status: " + book.Status + ".  ");
                Console.WriteLine("Check Out Date: " + book.CheckOutDate + ".  ");
                Console.WriteLine("Due Date: " + book.DueDate + ".  ");
                Console.WriteLine("Media Type:" + book.Type + ".  ");
                Console.WriteLine();
                Console.WriteLine();

            }

        }
        else if (input2 == "author")
        {

            Console.WriteLine("Please enter the author youd like to search for: ");
            string authorInput = Console.ReadLine();
            string author = authorInput.ToLower();

            List<Media> searchResults = mediaList.Where(book => book.Author.ToLower().Contains(author)).ToList();

            Console.WriteLine("Here are all book(s) by the author: " + author);

            foreach (Book book in searchResults)
            {
                Console.WriteLine();
                Console.WriteLine("Title: " + book.Title + ".  ");
                Console.WriteLine("Author: " + book.Author + ".  ");
                Console.WriteLine("Status: " + book.Status + ".  ");
                Console.WriteLine("Check Out Date: " + book.CheckOutDate + ".  ");
                Console.WriteLine("Due Date: " + book.DueDate + ".  ");
                Console.WriteLine("Media Type:" + book.Type + ".  ");
                Console.WriteLine();
                Console.WriteLine();

            }
        }
    }
    else if (input1 == "return")
    {

        Console.WriteLine("Which book are you returning? Please enter the title");
        string returnBook = Console.ReadLine().ToLower();
        List<Media> bookList = mediaList.Where(x => x.Type == "Book").ToList();
        Console.WriteLine(library.CheckIn(bookList, returnBook));

    }
    else if (input1 == "check out")
    {

        Console.WriteLine("Which book would you like to check out? Please enter the title");
        string checkOutBook = Console.ReadLine().ToLower();
        List<Media> bookList = mediaList.Where(x => x.Type == "Book").ToList();
        Console.WriteLine(library.CheckOut(bookList, checkOutBook));

    }
    else if (string.IsNullOrWhiteSpace(input1))
    {

        Console.WriteLine("Sorry, please type in a selection from above.");

    }
    else
    {
        Console.WriteLine("Sorry that is not one of the choices.");
    }

    Console.WriteLine("Return to main menu? y/n?");
    Console.WriteLine();

} while (Console.ReadLine().ToLower() == "y");

Console.WriteLine("Goodbye!");

fileio.FileUpdate(mediaList);
