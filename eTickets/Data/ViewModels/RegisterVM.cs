using System.ComponentModel.DataAnnotations;

namespace eTickets.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Full name is requierd")]
        public string FullName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage ="Email addres is requierd")]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Confirm password")]
        [Required(ErrorMessage ="Confirm password is requierd")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Passwordd do not match")]
        public string ConfirmPassword { get; set; }
    }
}
