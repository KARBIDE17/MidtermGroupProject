using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermGroupProject
{
    public abstract class Media
    {
        public Media()
        {
            Status = "Available"; // available / checked out
            DueDate = "Jan 1"; // possibly implement pc time into this
        }

        public string Status { get; set; }
        public string DueDate { get; set; }
    }
}
