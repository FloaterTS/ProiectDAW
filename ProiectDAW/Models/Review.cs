using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProiectDAW.Models
{
    public class Review
    {
        [ForeignKey("Game")]
        public int Id { get; set; }

        [Required]
        [Range(0, 100)]
        [Display(Name = "Review Score (%)")]
        public int ReviewScore { get; set; }

        [Required]
        [Display(Name = "Review")]
        [RegularExpression(@"^[a-zA-Z0-9'\s-]{3,800}$", ErrorMessage = "Between 3 and 800 characters allowed (a-z, A-Z, 0-9)")]
        public string ReviewInfo { get; set; }

        public virtual Game Game { get; set; }
    }
}