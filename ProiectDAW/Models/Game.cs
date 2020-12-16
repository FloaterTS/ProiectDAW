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
        [RegularExpression(@"^[a-zA-Z0-9'\s-]{3,50}$", ErrorMessage = "Between 3 and 50 characters allowed (a-z, A-Z, 0-9)")]
        public string GameName { get; set; }

        [Display(Name = "Description")]
        [RegularExpression(@"^[a-zA-Z0-9'\s-]{3,500}$", ErrorMessage = "Between 3 and 500 characters allowed (a-z, A-Z, 0-9)")]
        public string GameDescription { get; set; }

        public int DeveloperId { get; set; }

        public virtual Developer Developer { get; set; }

        public virtual Review Review { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}