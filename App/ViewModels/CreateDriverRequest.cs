using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreateDriverRequest
    {
        [Required(ErrorMessage = "Ce champ ne peut pas être vide")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(15)]
        [RegularExpression(@"(?=.*\d)(?=.*[A-Z])", ErrorMessage = "Doit contenir au moins 1 Majuscule et 1 chiffre")]
        public string Password { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(15)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Le mot de passe et le mot de passe de confirmation doivent correspondre")]
        public string ConfirmPassword { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Required]
        [Display(Name = "Birth Date")]
        public DateOnly BirthDate { get; set; }
    }
}