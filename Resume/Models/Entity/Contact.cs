using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models.Entity
{
    public class Contact:BaseEntity
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
        public string Answer { get; set; }
        public DateTime MessageDate { get; set; }
        public DateTime? AnswerDate { get; set; }
        
        
    }
}
