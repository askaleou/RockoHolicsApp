using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RockoHolicsApp.Models
{
    public class Sector
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a Sector name!")]
        [StringLength(50, ErrorMessage = "Sector names should not exceed 50 characters. ")]
        [Display(Name = "Sector")]
        public string Name { get; set; }

        // It is automatically updated after a new route is added
        public byte NumberOfRoutes { get; }

        // 1->1 Relationship with class City
        public int CityID { get; set; }
        public City City { get; set; }

        // 1->Many Relationship with class Route
        public virtual ICollection<Route> Routes { get; set; }
    }
}