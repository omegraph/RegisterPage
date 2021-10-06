using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAEventSpace.Models
{
    public class Ticket
    {
        public Ticket()
        {

        }

        public Ticket(Movie movie, int quantity, DateTime showTime)
        {
            this.Movie = movie;
            this.Quantity = quantity;
            this.ShowTime = showTime;
        }

        public Movie Movie { get; set; }

        public int Quantity { get; set; }

        public DateTime ShowTime { get; set; }
    }
}
