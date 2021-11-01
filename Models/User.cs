using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        [DataType(DataType.Date)]
        public DateTime MembershipDate { get; set; }

        public User()
        {
            MembershipDate = DateTime.Now;
        }
    }


}
