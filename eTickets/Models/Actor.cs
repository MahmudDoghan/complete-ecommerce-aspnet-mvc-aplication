﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is requierd")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is requierd")]
        [StringLength(50,MinimumLength = 3,ErrorMessage ="Full Name must be btween 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = " Biography is requierd")]
        public string Bio { get; set; }
        //RelatipnShips
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
