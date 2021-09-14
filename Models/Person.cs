using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQLDb.Models
{
    public class Person
    {
        [Key]
        public  int PersonID { get; set; }
        public string PersonName { get; set; }
        public string address { get; set; }
    }
}