using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models.Entity
{
    public class Person:BaseEntity
    {
        public int Name { get; set; }

        public int Age { get; set; }
        public string Location { get; set; }
        public int Experience { get; set; }
        public string Degree { get; set; }
        public string Careerlevel { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public int linkedinn { get; set; }

    }
}
