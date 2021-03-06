﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProiectDAW.Models
{
    public class CustomDateRangeAttribute : RangeAttribute
    {
        public CustomDateRangeAttribute()
          : base(typeof(DateTime),
                DateTime.Now.ToShortDateString(),
                DateTime.Now.AddYears(1).ToShortDateString())
        { }
    }

    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        [CustomDateRange]
        [DataType(DataType.Date)]
        [Display(Name = "Reservation Date")]
        public DateTime ReservationDate { get; set; }

        public int BuyPackageId { get; set; }

        public virtual BuyPackage BuyPackage { get; set; }

        public int GameId { get; set; }

        public virtual Game Game { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
