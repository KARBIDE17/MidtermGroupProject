
using MidtermGroupProject;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using static System.Reflection.Metadata.BlobBuilder;
using System.Linq;

string filePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"../../../", "Media.txt");
Library library = new();
Search search= new();
FileIO fileio = new(filePath);
List<Media> mediaList = fileio.FileRead();

do
{
    Console.WriteLine("Welcome to the Library!");
    Console.WriteLine("To see a list of available books, type \"List\" ");
    Console.WriteLine("To search for a book, type \"Search\" ");
    Console.WriteLine("To return a book, type \"Return\" ");

    string input1 = Console.ReadLine().ToLower();

    if (input1 == "list")
    {
        //display list of books using method
        //List<Media> mediaList = fileio.FileRead();
        foreach (Book book in mediaList)
        {
            Console.WriteLine("Title: " + book.Title + ".  ");
            Console.WriteLine("Author: " + book.Author + ".  ");
            Console.WriteLine("Status: " + book.Status + ".  ");
            Console.WriteLine("Check Out Date" + book.CheckOutDate + ".  ");
            Console.WriteLine("Due Date" + book.DueDate + ".  ");
            Console.WriteLine("Media Type:" + book.Type + ".  ");
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine("Which book would you like to check out? Please enter the title");
        string checkOutBook = Console.ReadLine();
        List<Media> bookList = mediaList.Where(x => (x.Type == "Book") && (x.Status == "Available")).ToList();
        Console.WriteLine(library.CheckOut(bookList, checkOutBook));
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

            //List<Media> mediaList = fileio.FileRead();

            List<Media> searchResults = mediaList.Where(book => book.Title.ToLower().Contains(title)).ToList();

            foreach (Book book in searchResults)
            {
                Console.WriteLine("Here are all books with the title: " + titleInput);
                Console.WriteLine();
                Console.WriteLine("Title: " + book.Title + ".  ");
                Console.WriteLine("Author: " + book.Author + ".  ");
                Console.WriteLine("Status: " + book.Status + ".  ");
                Console.WriteLine("Check Out Date" + book.CheckOutDate + ".  ");
                Console.WriteLine("Due Date" + book.DueDate + ".  ");
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

            //List<Media> mediaList = fileio.FileRead();

            List<Media> searchResults = mediaList.Where(book => book.Author.ToLower().Contains(author)).ToList();

            foreach (Book book in searchResults)
            {
                Console.WriteLine("Here are all books with the title: " + author);
                Console.WriteLine();
                Console.WriteLine("Title: " + book.Title + ".  ");
                Console.WriteLine("Author: " + book.Author + ".  ");
                Console.WriteLine("Status: " + book.Status + ".  ");
                Console.WriteLine("Check Out Date" + book.CheckOutDate + ".  ");
                Console.WriteLine("Due Date" + book.DueDate + ".  ");
                Console.WriteLine("Media Type:" + book.Type + ".  ");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
    else if (input1 == "return")
    {
        //Console.WriteLine("Here are the books currently checked out:");

        //List<Media> returnResults = mediaList.Where(x => (x.Type == "Book") && (x.Status == "Checked Out")).ToList();

        //foreach (var media in returnResults)
        //{
        //    Console.WriteLine("Title: " + media.Title + ".  ");
        //    Console.WriteLine("Author: " + media.Author + ".  ");
        //    Console.WriteLine("Status: " + media.Status + ".  ");
        //    Console.WriteLine("Check Out Date" + media.CheckOutDate + ".  ");
        //    Console.WriteLine("Due Date" + media.DueDate + ".  ");
        //    Console.WriteLine("Media Type:" + media.Type + ".  \n\n");
        //}

        Console.WriteLine("Which book are you returning? Please enter the title");
        string returnBook = Console.ReadLine();
        List<Media> bookList = mediaList.Where(x => x.Type == "Book").ToList();
        Console.WriteLine(library.CheckIn(bookList, returnBook));
    }

    Console.WriteLine("Would you like to try again? y/n?");

} while (Console.ReadLine() == "y");

fileio.FileUpdate(mediaList);












////remove a media item from the list
////mediaList.Remove(mediaList.SingleOrDefault(x => x.Title == "The Dark Tower VII: The Dark Tower"));


////add a book to the list
//DateOnly DateOnly1 = new DateOnly(2023, 03, 04);
//DateOnly DateOnly2 = new DateOnly(2023, 03, 11);
//mediaList.Add(new Book("Book", "Available", DateOnly1, DateOnly2, "The Dark Tower VIII: Susannah's Revenge", "Stephen King"));


////Update status of an item from the list, throws error if title is not unique
//mediaList.Single(x => x.Title == "The Dark Tower VII: The Dark Tower").Status = "Checked Out";







//List<string> strings= new List<string>() { "Misery", "Firestarter", "Delores Claiborne" };

