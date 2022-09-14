using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreateRaceRequest
    {
        [Required(ErrorMessage = "Vous devez renseigner un nom à votre course")]
        [MaxLength(10)]
        public string? RaceName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime RaceDate { get; set; }

        [Required]
        [Range(0, 23, 
            ErrorMessage = "L'heure doit être comprise entre 0 et 23h")]
        public int RaceStart { get; set; }

        [Required]
        public float RaceLatitude { get; set; }

        [Required]
        public float RaceLongitude { get; set; }

        [Required]
        public int MaxParticipant { get; set; }
    }
}