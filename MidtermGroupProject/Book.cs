using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermGroupProject
{
    public class Book : Media
    {
        public Book(string title, string author, string status, string dueDate)
        {
            Title = title;
            Author = author;
            Status = status;
            DueDate = dueDate;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }
        public string DueDate { get; set; }



    }
}
