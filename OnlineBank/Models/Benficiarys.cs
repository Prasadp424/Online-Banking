using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBank.Models
{
    public class Benficiarys
    {
        [Key]
        public int ID { get; set; }
        public string Payee_Name { get; set; }
        public string Payee_Contact { get; set; }
        public string Bnak_name { get; set; }
        public bool Status { get; set; }
        public string Customer { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
    }
}
