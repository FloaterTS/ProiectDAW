using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProiectDAW.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Game Name")]
        public string GameName { get; set; }

        [Display(Name = "Description")]
        public string GameDescription { get; set; }

        public int DeveloperId { get; set; }

        public virtual Developer Developer { get; set; }
    }
}