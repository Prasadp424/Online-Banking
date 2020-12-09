using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBank.Models
{
    public class Registration
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Contact_No { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
