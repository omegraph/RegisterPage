using EFAEventSpace.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAEventSpace.Models
{
    public class Movie
    {
        public Movie()
        {

        }

        public Movie(string title, Rating rating, List<DateTime> showTimes)
        {
            this.Title = title;
            this.Rating = rating;
            this.ShowTimes = showTimes;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public Rating Rating { get; set; }

        public List<DateTime> ShowTimes { get; set; }
    }
}
