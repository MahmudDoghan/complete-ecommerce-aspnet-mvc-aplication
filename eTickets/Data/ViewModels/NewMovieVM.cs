using eTickets.Data.Base;
using eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name ="Movie name")]
        [Required(ErrorMessage ="Name is requierd")]
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is requierd")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is requierd")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is requierd")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie Start Date")]
        [Required(ErrorMessage = "Start Date is requierd")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie End Date")]
        [Required(ErrorMessage = "End Date is requierd")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is requierd")]
        public MovieCategory MovieCategory { get; set; }
        //RelatipnShips
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actro(s) is requierd")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Movie cinema is requierd")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Movie producer is requierd")]
        public int ProducerId { get; set; }
    }
}
