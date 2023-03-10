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

        public string CheckOut(List<Media> mediaList, string title) //check out a book, returns message to user
        {
            foreach (var item in mediaList)
            {
                if (item.Title.ToLower().Contains(title))
                {
                    if (item.Status == "Checked Out") //check if book is already checked out
                    {
                        return "This title is already checked out.";
                    }

                    mediaList.Single(x => x.Title == item.Title).Status = "Checked Out";
                    mediaList.Single(x => x.Title == item.Title).DueDate = DateOnly.FromDateTime(DateTime.Now).AddDays(14); //2 weeks
                    mediaList.Single(x => x.Title == item.Title).CheckOutDate = DateOnly.FromDateTime(DateTime.Now); //today
                    return $"Thank you checking out {item.Title}!";
                }
            }
            return "I dont recognize that title.";
        }

        public string CheckIn(List<Media> mediaList,string title) //check in a book, returns message to user
        {

            foreach (var item in mediaList)
            {
                if (item.Title.ToLower().Contains(title))

                {
                    if (item.Status == "Available") //check if book is already checked in
                    {
                        return "This title is already checked in.";
                    }

                    mediaList.Single(x => x.Title == item.Title).Status = "Available";
                    mediaList.Single(x => x.Title == item.Title).DueDate = null; //removes due date
                    mediaList.Single(x => x.Title == item.Title).CheckOutDate = null; //removes check out date
                    return $"Thank you for returning {item.Title}!";
                }
            }
            return "I dont recognize that title.";
        }
    }
}
