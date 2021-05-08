using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string text { get; set; }
        public DateTime addedDate { get; set; }
        public int userId { get; set; }
        public int FilmID { get; set; }
        public Film Film { get; set; }
        
    }
}
