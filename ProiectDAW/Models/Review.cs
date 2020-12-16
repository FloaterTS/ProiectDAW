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
        [Display(Name = "Review Score (%)")]
        public int ReviewScore { get; set; }

        [Required]
        [Display(Name = "Review")]
        public string ReviewInfo { get; set; }

        public virtual Game Game { get; set; }
    }
}