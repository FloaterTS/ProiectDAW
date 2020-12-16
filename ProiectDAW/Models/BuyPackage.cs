using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProiectDAW.Models
{
    public class BuyPackage
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Package Name")]
        [RegularExpression(@"^[a-zA-Z0-9'\s-]{3,30}$", ErrorMessage = "Between 3 and 30 characters allowed (a-z, A-Z, 0-9)")]
        public string BuyPackageName { get; set; }

        [Required]
        [Range(0, 3000)]
        [Display(Name = "Price (RON)")]
        public int BuyPackagePrice { get; set; }

        [Required]
        [Range(0, 168)]
        [Display(Name = "Duration (Hrs)")]
        public int BuyPackageDuration { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }

}