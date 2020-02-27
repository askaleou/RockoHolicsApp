using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RockoHolicsApp.Models
{
    public class Grade
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a Grade name!")]
        [StringLength(10, ErrorMessage = "Grade names should not exceed 10 characters. ")]
        [Display(Name = "Grade")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the Grade's points!")]
        public int Points { get; set; }
    }
}