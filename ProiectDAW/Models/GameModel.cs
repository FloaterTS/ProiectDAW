using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProiectDAW.Models
{
    public class GameModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Game Name")]
        public string GameName { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string GameDescription { get; set; }

        [Required]
        [Display(Name = "Price")]
        public string GamePrice { get; set; }
    }
}