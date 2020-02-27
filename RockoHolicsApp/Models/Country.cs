using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RockoHolicsApp.Models
{
    public class Country
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a Country name!")]
        [StringLength(100, ErrorMessage = "Country names should not exceed 100 characters. ")]
        [Display(Name = "Country")]
        public string Name { get; set; }

        // 1->Many Relationship with class City
        public virtual ICollection<City> Cities { get; set; }
    }
}