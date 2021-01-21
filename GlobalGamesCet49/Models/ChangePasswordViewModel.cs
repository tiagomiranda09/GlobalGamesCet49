using System.ComponentModel.DataAnnotations;

namespace GlobalGamesCet49.Models
{
    public class ChangePasswordViewModel
    {

        [Required]
        [Display(Name = "Password Antiga")]
        public string OldPassword { get; set; }


        [Required]
        [Display(Name = "Nova Password")]
        public string NewPassword { get; set; }


        [Required]
        [Compare("NewPassword")]
        public string Confirm { get; set; }


    }
}
