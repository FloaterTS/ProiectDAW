using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProiectDAW.Models
{
    public class Developer
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Developer Name")]
        public string DeveloperName { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string DeveloperDescription { get; set; }
    }
}