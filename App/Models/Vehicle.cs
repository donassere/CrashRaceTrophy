namespace App.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public List<VehicleCategory> Categories { get; set; }
        public int ConstructionYear { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Power { get; set; }
        public string? Image { get; set; }
    }
}