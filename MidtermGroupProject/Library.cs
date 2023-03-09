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

        public List<Media> BookSearch(string searchCategory, string input, List<Media> mediaList)
        {
            List<Media> list = new List<Media>();
            if (searchCategory.ToLower() == "author")
            {
                if (mediaList.Where(book => book.Author.ToLower().Contains(input)).ToList().Any())
                {
                    return mediaList.Where(book => book.Author.ToLower().Contains(input)).ToList();
                }   
            }
            else
            {
                if (mediaList.Where(book => book.Title.ToLower().Contains(input)).ToList().Any())
                {
                    return mediaList.Where(book => book.Title.ToLower().Contains(input)).ToList();
                }
            }
            return list; //possible to return an empty list
        }

        public string CheckOut(List<Media> mediaList, string title)
        {
            foreach (var item in mediaList)
            {
                if (item.Title.ToLower().Contains(title))
                {
                    mediaList.Single(x => x.Title == item.Title).Status = "Checked Out";
                    mediaList.Single(x => x.Title == item.Title).DueDate = DateOnly.FromDateTime(DateTime.Now).AddDays(14);
                    mediaList.Single(x => x.Title == item.Title).CheckOutDate = DateOnly.FromDateTime(DateTime.Now);
                    return $"Thank you checking out {item.Title}!";
                }
            }
            if (mediaList.Single(x => (x.Title.ToLower().Contains(title)) && (x.Status == "Checked Out")) is not null)
            {
                return "This title is already checked out.";
            }
            return "I dont recognize that title.";
        }

        public string CheckIn(List<Media> mediaList,string title)
        {
            foreach (var item in mediaList)
            {
                if (item.Title.ToLower().Contains(title))
                {
                    mediaList.Single(x => x.Title == item.Title).Status = "Available";
                    mediaList.Single(x => x.Title == item.Title).DueDate = null;
                    mediaList.Single(x => x.Title == item.Title).CheckOutDate = null;
                    return $"Thank you for returning {item.Title}!";
                }
            }
            if (mediaList.Single(x => (x.Title.ToLower().Contains(title)) && (x.Status == "Checked In")) is not null)
            {
                return "This title is already checked in.";
            }
            return "I dont recognize that title.";
        }

        public List<Media> Collection(string type)
        {
            List<Media> list = new List<Media>();
            return list.Where(x => x.Type.ToLower() == type).ToList(); //can return empty list
        }
    }
}
