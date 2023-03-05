using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermGroupProject
{
    public class Book : Media
    {
        public Book(string type, string status, DateOnly? checkOutDate, DateOnly? dueDate, string title, string author)
        {
            Type = type;
            Status = status;
            CheckOutDate = checkOutDate;
            DueDate = dueDate;
            Title = title;
            Author = author;
        }

        public override string Type { get; set; }
        public override string Status { get; set; }
        public override DateOnly? CheckOutDate { get; set; } //SMJ
        public override DateOnly? DueDate { get; set; } //SMJ

        public override string Title { get; set; }
        public string Author { get; set; }

    }
}
