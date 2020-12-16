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
        [RegularExpression(@"^[a-zA-Z0-9'\s-]{3,60}$", ErrorMessage = "Between 3 and 60 characters allowed (a-z, A-Z, 0-9)")]
        public string DeveloperName { get; set; }

        [Required]
        [Display(Name = "Description")]
        [RegularExpression(@"^[a-zA-Z0-9',.\s-]{3,600}$", ErrorMessage = "Between 3 and 600 characters allowed (a-z, A-Z, 0-9)")]
        public string DeveloperDescription { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}