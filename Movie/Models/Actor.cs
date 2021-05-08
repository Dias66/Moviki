using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models
{
    public class Actor
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime birthDate { get; set; }

    }
}
