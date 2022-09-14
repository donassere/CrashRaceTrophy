
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime EventDate { get; set; }
        public int RaceStart { get; set; }
        public float RaceLatitude { get; set; }
        public float RaceLongitude { get; set; }
        public int MaxParticipant { get; set; }
    }
}