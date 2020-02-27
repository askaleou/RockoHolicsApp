using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RockoHolicsApp.Models
{
    public class City
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a City name!")]
        [StringLength(100, ErrorMessage = "City names should not exceed 100 characters. ")]
        [Display(Name = "City")]
        public string Name { get; set; }

        // 1->1 Relationship with class Country
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }

        // 1->Many Relationship with class Sectors
        public virtual ICollection<Sector> Sectors { get; set; }
    }
}