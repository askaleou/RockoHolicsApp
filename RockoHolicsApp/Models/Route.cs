using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RockoHolicsApp.Models
{
    public class Route
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a Route name!")]
        [StringLength(50, ErrorMessage = "Route names should not exceed 50 characters. ")]
        [Display(Name = "Route")]
        public string Name { get; set; }

        public byte Meters { get; set; }


        // 1->1 Relationship with class Grade
        public int GradeID { get; set; }
        public Grade Grade { get; set; }
        
        // 1->1 Relationship with class Sector
        public int SectionID { get; set; }
        public Sector Sector { get; set; }
        
        
    }
}