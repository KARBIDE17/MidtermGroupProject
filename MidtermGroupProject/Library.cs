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

        //public List<Book> BookSearch(int searchChoice, string input)
        //{

        //    // ask user to searech by author or by title, if title use 1, if author use 2
        //    // then take input and use it to search list for either title or author and return
        //    // the book they  are looking for.

        //}
        public string CheckOut(List<Media> mediaList, string title)
        {
            foreach (var item in mediaList)
            {
                if (item.Title.Contains(title))
                {
                    mediaList.Single(x => x.Title == item.Title).Status = "Checked Out";
                    mediaList.Single(x => x.Title == item.Title).DueDate = DateOnly.FromDateTime(DateTime.Now).AddDays(14);
                    mediaList.Single(x => x.Title == item.Title).CheckOutDate = DateOnly.FromDateTime(DateTime.Now);
                    return $"Thank you checking out {item.Title}!";
                }
            }
            return "I dont recognize that title.";
        }

        public string CheckIn(List<Media> mediaList,string title)
        {
            foreach (var item in mediaList)
            {
                if (item.Title.Contains(title))
                {
                    mediaList.Single(x => x.Title == item.Title).Status = "Available";
                    mediaList.Single(x => x.Title == item.Title).DueDate = null;
                    mediaList.Single(x => x.Title == item.Title).CheckOutDate = null;
                    return $"Thank you for returning {item.Title}!";
                }
            }
            return "I dont recognize that title.";
        }

        //public List<Book> BookCollection() 
        //{

        //    // print the entire collection of books to the console


        //}
    }
}
