using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public User User{ get; set; }

        public Ticket()
        {
            CreationDate = DateTime.Now;
        }
    }
}
