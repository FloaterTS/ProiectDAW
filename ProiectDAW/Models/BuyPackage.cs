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
        public string BuyPackageName { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int BuyPackagePrice { get; set; }

        [Required]
        [Display(Name = "Duration (hours)")]
        public int BuyPackageDuration { get; set; }
    }
}