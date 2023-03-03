using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermGroupProject
{
    public class Library
    {

        public List<Book> Books { get; set; }

        public Library() 
        {

            Books.Add(new Book("Misery", "Stephen King", "Available", "JAN 1"));
            Books.Add(new Book("Firestarter", "Stephen King", "Available", "JAN 1"));
            Books.Add(new Book("Delores Claiborne", "Stephen King", "Available", "JAN 1"));
            Books.Add(new Book("Nightmares and Dreamscapes", "Stephen King", "Available", "JAN 1"));
            Books.Add(new Book("Needful Things", "Stephen King", "Available", "JAN 1"));
            Books.Add(new Book("Pet Sematary", "Stephen King", "Available", "JAN 1"));
            Books.Add(new Book("IT", "Stephen King", "Available", "JAN 1"));
            Books.Add(new Book("The Shining", "Stephen King", "Available", "JAN 1"));
            Books.Add(new Book("Carrie", "Stephen King", "Available", "JAN 1"));
            Books.Add(new Book("Salems Lot", "Stephen King", "Available", "JAN 1"));
            Books.Add(new Book("The Dark Tower I: The Gunslinger", "Stephen King", "Available", "JAN 1"));
            Books.Add(new Book("The Dark Tower II: The Drawing of The Three", "Stephen King", "Available", "JAN 1")); 
            Books.Add(new Book("The Dark Tower III: The Wastelands", "Stephen King", "Available", "JAN 1")); 
            Books.Add(new Book("The Dark Tower IV: Wizard and Glass", "Stephen King", "Available", "JAN 1")); 
            Books.Add(new Book("The Dark Tower V: The Wolves of the Calla", "Stephen King", "Available", "JAN 1")); 
            Books.Add(new Book("The Dark Tower VI: Song of Susannah", "Stephen King", "Available", "JAN 1")); 
            Books.Add(new Book("The Dark Tower VII: The Dark Tower", "Stephen King", "Available", "JAN 1"));



        }
        public List<Book> BookSearch(int searchChoice, string input)
        {

            // ask user to searech by author or by title, if title use 1, if author use 2
            // then take input and use it to search list for either title or author and return
            // the book they  are looking for.

        }
        public string BookCheckOut(string title, string author) 
        {
        
            //check out a book, change status to checked out, set due date to 14 days from now
        
        }

        public string BookCheckIn(string title, string author) 
        {
        
            // check in a book, change status to available, remove due date
        
        }



        public List<Book> BookCollection() 
        {
        
            // print the entire collection of books to the console
        
        
        }
    }
}
