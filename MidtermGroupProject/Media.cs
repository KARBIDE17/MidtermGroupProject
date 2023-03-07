using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermGroupProject
{
    public abstract class Media
    {
        //public Media()
        //{
        //    Status = "Available"; // available / checked out
        //    //DueDate = "Jan 1"; // possibly implement pc time into this

        //    //SMJ

        //    DateTime now = DateTime.Now;
        //    CheckOutDate = DateOnly.FromDateTime(now); //today
        //    DueDate = CheckOutDate.AddDays(7);

        //}

        public abstract string Title { get; set; }
        public abstract string Status { get; set; }
        public abstract DateOnly? DueDate { get; set; }
        public abstract string Type { get; set; }
        public abstract DateOnly? CheckOutDate { get; set; }
        public abstract string? Author { get; set; }

    }
}
