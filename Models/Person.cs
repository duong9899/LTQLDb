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

        [Required(ErrorMessage = "Hãy Nhập ID")]

        public String PersonID { get; set; }



        [Required(ErrorMessage = "Hãy Nhập Tên")]

        public String PersonName { get; set; }



        [Required(ErrorMessage = "Hãy Nhập Địa Chỉ")]

        public String address { get; set; }
    }
}