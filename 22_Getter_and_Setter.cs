using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Movie
    {
        private String title;
        private String rating;

        public Movie(string title, string rating)
        {
            this.title = title;
            this.setRating(rating);
        }
        public String getRating()
        {
            return this.rating;
        }
        public void setRating(String rating)
        {
            if (rating == "G" || rating == "PG" || rating == "PG-13" || rating == "R" || rating == "NR")
            {
                this.rating = rating;
            }
            else
                this.rating = "NR";

        }
    }
}
