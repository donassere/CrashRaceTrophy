using App.Models;

namespace App.Data;
public static class AppDbContextExtensions
{
    public static void Seed(this AppDbContext dbContext)
    {
        if (!dbContext.Races.Any()){
            var races = new List<Race>()
            {
                new Race()
                {
                    Id = 1,
                    Name = "Ma course 123",
                    EventDate = new DateTime(2022, 04, 02)
                },
                new Race()
                {
                    Id = 2,
                    Name = "Ma super pas course",
                    EventDate = new DateTime(2022, 02, 02)
                },
                new Race()
                {
                    Id = 3,
                    Name= "Ma course pourrie",
                    EventDate = new DateTime(2022, 04, 02)
                }
            };
            dbContext.Races.AddRange(races);
            dbContext.SaveChanges();
        }
        if (!dbContext.ResultItem.Any())
        {
            var resultItems = new List<ResultItem>()
            {
                new ResultItem()
                {
                    Id = 1,
                    DriverName = "Jean Louis",
                    Rank = 1
                },
                new ResultItem()
                {
                    Id = 2,
                    DriverName = "Jean Claude",
                    Rank = 2
                },
                new ResultItem()
                {
                    Id = 3,
                    DriverName = "Jean Pierre",
                    Rank = 3
                },
                new ResultItem()
                {
                    Id = 4,
                    DriverName = "Jean Damien",
                    Rank = 4
                },
                new ResultItem()
                {
                    Id = 5,
                    DriverName = "Jean Jean",
                    Rank = 5
                },
                new ResultItem()
                {
                    Id = 6,
                    DriverName = "Jean Cristophe",
                    Rank = 6
                },
                new ResultItem()
                {
                    Id = 7,
                    DriverName = "Jean Rémi",
                    Rank = 7
                }
            };

            dbContext.ResultItem.AddRange(resultItems);
            dbContext.SaveChanges();
        }
        if(!dbContext.VehicleCategories.Any() || !dbContext.Vehicles.Any()){

            var vehicleCategories = new List<VehicleCategory>(){

                new VehicleCategory(){
                    Id = 1,
                    Name = "Super Car",
                    Description = "Voiture de sport hautes performances.",
                    Image = "wwwroot/img/Categories/supercar.jpg",
                    Color = "#3383ff",
                    Vehicles = new List<Vehicle>()
                },
                new VehicleCategory(){
                    Id = 2,
                    Name = "Hyper Car",
                    Description = "Voiture qui affiche une puissance et des performances hors du commun.",
                    Image = "wwwroot/img/Categories/hypercar.jpg",
                    Color = "#d433ff",
                    Vehicles = new List<Vehicle>()
                },
                new VehicleCategory(){
                    Id = 3,
                    Name = "Muscle Car",
                    Description = "Automobile américaine propulsée par un moteur surdimensionné, le plus souvent un V8.",
                    Image = "wwwroot/img/Categories/musclecar.jpg",
                    Color = "#fc1c1c" ,
                    Vehicles = new List<Vehicle>()
                },
                new VehicleCategory(){
                    Id = 4,
                    Name = "Sport Car",
                    Description = "Automobile dont la conception a pour but premier de valoriser les sensations et les performances.",
                    Image = "wwwroot/img/Categories/sportcar.jpg",
                    Color = "#cdcdcd",
                    Vehicles = new List<Vehicle>()
                },
                new VehicleCategory(){
                    Id = 5,
                    Name = "American Legend",
                    Description = "Automobile mythique incarnant la puissance industrielle des USA.",
                    Image = "wwwroot/img/Categories/americanlegend.jpg",
                    Color = "#1ceefc",
                    Vehicles = new List<Vehicle>()
                },
                new VehicleCategory(){
                    Id = 6,
                    Name = "German Classic",
                    Description = "Voiture de sport mythique allemande.",
                    Image = "wwwroot/img/Categories/germanclassic.jpg",
                    Color = "#ffa33b",
                    Vehicles = new List<Vehicle>()
                },
                new VehicleCategory(){
                    Id = 7,
                    Name = "Italian Classic",
                    Description = "Voiture de sport mythique italienne.",
                    Image = "wwwroot/img/Categories/italianclassic.jpg",
                    Color = "#26fc1c",
                    Vehicles = new List<Vehicle>()
                },
                new VehicleCategory(){
                    Id = 8,
                    Name = "Japan Race Car",
                    Description = "Voiture de sport japonaises.",
                    Image = "wwwroot/img/Categories/japanracecar.jpg",
                    Color = "#db91da",
                    Vehicles = new List<Vehicle>()
                },
                new VehicleCategory(){
                    Id = 9,
                    Name = "High Performance Sport Car",
                    Description = "Automobile dont les performances dépassent celles des voitures de sport.",
                    Image = "wwwroot/img/Categories/highperformancecar.png",
                    Color = "#5e5e5e",
                    Vehicles = new List<Vehicle>()
                }
            };

            var vehicles = new List<Vehicle>(){

                new Vehicle(){
                    Id = 1,
                    Categories = new List<VehicleCategory>(),
                    ConstructionYear = 1987,
                    Brand = "Ferrari",
                    Model = "F40",
                    Power = 7,
                    Image = "wwwroot/img/Vehicles/f40.jpg"
                },

                new Vehicle(){
                    Id = 2,
                    Categories = new List<VehicleCategory>(),
                    ConstructionYear = 2014,
                    Brand = "Lamborghini",
                    Model = "Huracan",
                    Power = 7,
                    Image = "wwwroot/img/Vehicles/huracan.jpg"
                },
                new Vehicle(){
                    Id = 3,
                    Categories = new List<VehicleCategory>(),
                    ConstructionYear = 1967,
                    Brand = "Ford",
                    Model = "Mustang",
                    Power = 3,
                    Image = "wwwroot/img/Vehicles/f40.jpg"
                },
                new Vehicle(){
                    Id = 4,
                    Categories = new List<VehicleCategory>(),
                    ConstructionYear = 2021,
                    Brand = "Dodge",
                    Model = "Charger R/T",
                    Power = 5,
                    Image = "wwwroot/img/Vehicles/charger.jpg"
                },
                new Vehicle(){
                    Id = 5,
                    Categories = new List<VehicleCategory>(),
                    ConstructionYear = 2018,
                    Brand = "Pagani",
                    Model = "Huayra R",
                    Power = 9,
                    Image = "wwwroot/img/Vehicles/huayra.jpg"
                },
                new Vehicle(){
                    Id = 6,
                    Categories = new List<VehicleCategory>(),
                    ConstructionYear = 2019,
                    Brand = "Bugatti",
                    Model = "Chiron",
                    Power = 10,
                    Image = "wwwroot/img/Vehicles/chiron.jpg"
                },
                new Vehicle(){
                    Id = 7,
                    Categories = new List<VehicleCategory>(),
                    ConstructionYear = 1995,
                    Brand = "Toyota",
                    Model = "Supra Yakuza Edition",                        
                    Power = 7,
                    Image = "wwwroot/img/Vehicles/supra.jpg"
                },
                new Vehicle(){
                    Id = 8,
                    Categories = new List<VehicleCategory>(),
                    ConstructionYear = 2009,
                    Brand = "Honda",
                    Model = "S2000 Racing",
                    Power = 6,
                    Image = "wwwroot/img/Vehicles/s2000.jpg"
                },
                new Vehicle(){
                    Id = 9,
                    Categories = new List<VehicleCategory>(),
                    ConstructionYear = 1991,
                    Brand = "BMW",
                    Model = "E30",
                    Power = 6,
                    Image = "wwwroot/img/Vehicles/e30.jpg"
                },
                new Vehicle(){
                    Id = 10,
                    Categories = new List<VehicleCategory>(),
                    ConstructionYear = 2007,
                    Brand = "Porsche",
                    Model = "911 GT3",
                    Power = 7,
                    Image = "/wwwroot/img/Vehicles/911.jpg"
                }
            };
            if (!dbContext.VehicleCategories.Any()) {
                vehicleCategories[0].Vehicles.Add(vehicles[0]);
                vehicleCategories[0].Vehicles.Add(vehicles[1]);
                vehicleCategories[1].Vehicles.Add(vehicles[4]);
                vehicleCategories[1].Vehicles.Add(vehicles[5]);
                vehicleCategories[2].Vehicles.Add(vehicles[2]);
                vehicleCategories[2].Vehicles.Add(vehicles[3]);
                vehicleCategories[3].Vehicles.Add(vehicles[7]);
                vehicleCategories[3].Vehicles.Add(vehicles[8]);
                vehicleCategories[4].Vehicles.Add(vehicles[2]);
                vehicleCategories[5].Vehicles.Add(vehicles[8]);
                vehicleCategories[5].Vehicles.Add(vehicles[9]);
                vehicleCategories[6].Vehicles.Add(vehicles[0]);
                vehicleCategories[7].Vehicles.Add(vehicles[6]);
                vehicleCategories[7].Vehicles.Add(vehicles[7]);
                vehicleCategories[8].Vehicles.Add(vehicles[9]);
                dbContext.VehicleCategories.AddRange(vehicleCategories);
                dbContext.SaveChanges();
            }
            if (!dbContext.Vehicles.Any()){
                vehicles[0].Categories.Add(vehicleCategories[0]);
                vehicles[0].Categories.Add(vehicleCategories[6]);
                vehicles[1].Categories.Add(vehicleCategories[0]);
                vehicles[2].Categories.Add(vehicleCategories[2]);
                vehicles[2].Categories.Add(vehicleCategories[4]);
                vehicles[3].Categories.Add(vehicleCategories[2]);
                vehicles[4].Categories.Add(vehicleCategories[1]);
                vehicles[5].Categories.Add(vehicleCategories[1]);
                vehicles[6].Categories.Add(vehicleCategories[7]);
                vehicles[7].Categories.Add(vehicleCategories[3]);
                vehicles[7].Categories.Add(vehicleCategories[7]);
                vehicles[8].Categories.Add(vehicleCategories[3]);
                vehicles[8].Categories.Add(vehicleCategories[5]);
                vehicles[9].Categories.Add(vehicleCategories[5]);
                vehicles[9].Categories.Add(vehicleCategories[8]);
                dbContext.Vehicles.AddRange(vehicles);
                dbContext.SaveChanges();
            }   
        }
    }
}