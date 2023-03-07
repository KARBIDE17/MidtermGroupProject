using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;

namespace LibraryApp
{
    internal class Library
    {
        private List<Book> books = new List<Book>();
        public Library()
        {
            init();
        }

        private void init()
        {
            books.Add(new Book("The Great Gatsby", "Scott Fitzgerald"));
            books.Add(new Book("I Am Pilgrim", "Terry Hayes"));
            books.Add(new Book("Great Dune Trilogy", "Frank Herbert"));
            books.Add(new Book("The Reckoning", "John Grisham"));
            books.Add(new Book("Moveable Feast", "Ernest Hemingway"));
            books.Add(new Book("The Name of the Wind", "Patrick Rothfuss"));
            books.Add(new Book("Pulse", "Michael Harvey"));
            books.Add(new Book("The Outsider", "Albert Camus"));
            books.Add(new Book("All the light we cannot see", "Anthony Doerr"));
            books.Add(new Book("Churchill. The Power of Words", "Winston Churchill"));
            books.Add(new Book("The Short Story of Photography", "Ian Haydn Smith"));
            books.Add(new Book("The Illustration Idea Book", "Heller Steven"));
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books:");
            for (int i = 0; i < books.Count; i++)
            {
                Book book = books[i];
                String bookStr = String.Format("\nId: {0} \nBook: {1}\n",
                i + 1, book.ToString());
                Console.WriteLine(bookStr);
            }
        }

        public bool AddBook(Book newBook)
        {
            foreach (Book book in books)
            {
                if (book.GetTitle().Equals(newBook.GetTitle(), StringComparison.OrdinalIgnoreCase) && book.GetAuthor().Equals(newBook.GetAuthor(), StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }

            books.Add(newBook);
            return true;
        }

        public void CheckOutBook(int id)
        {
            if (id < 1 && id > books.Count)
            {
                Console.WriteLine("Incorrect id");
            }

            id--;

            Book book = books[id];
            if (book.IsCheckedOut())
            {
                Console.WriteLine("The book is already checked out");
            }
            book.SetIsCheckedOut(true);
            book.SetDueDate(DateTime.Now.AddDays(14));
            Console.WriteLine("The book has been successfully checked out");
        }

        public void FindBookByAuthor(string author)
        {
            for (int i = 0; i < books.Count; i++)
            {
                Book book = books[i];
                if (book.GetAuthor().Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    String bookStr = String.Format("\nId: {0} \nBook: {1}\n",
                i + 1, book.ToString());
                    Console.WriteLine(bookStr);
                    return;
                }
            }
            Console.WriteLine("Can't find the book by author: " + author);
        }

        public void FindBookByTitleKeyword(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                Book book = books[i];
                if (book.GetTitle().Contains(title))
                {
                    String bookStr = String.Format("\nId: {0} \nBook: {1}\n",
                i + 1, book.ToString());
                    Console.WriteLine(bookStr);
                    return;
                }
            }
            Console.WriteLine("Can't find the book by title keyword: " + title);
        }
    }

}
}
