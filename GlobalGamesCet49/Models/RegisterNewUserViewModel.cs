using System.ComponentModel.DataAnnotations;

namespace GlobalGamesCet49.Models
{
    public class RegisterNewUserViewModel
    {



        [Required]
        [Display(Name = "Primeiro Nome")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Ultimo Nome")]
        public string LastName { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }


        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }





    }
}
