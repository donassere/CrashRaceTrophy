namespace App.Models
{
    public class VehicleCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Color { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}