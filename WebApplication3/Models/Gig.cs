using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Gig
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(250)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }
}