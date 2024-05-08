using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Cinema Logo")]
        [Required(ErrorMessage ="Cinema Logo is requierd")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage ="Cinema name is requierd")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema description is requierd")]
        public string Description { get; set; }

        //Reletionships
        public List<Movie> Movie { get; set; }
    }
}
