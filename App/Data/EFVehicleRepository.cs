using App.Models;

namespace App.Data
{
    public class EFVehicleRepository : IRepository<Vehicle>
    {
        private readonly AppDbContext _dbContext;

        public EFVehicleRepository(AppDbContext dbContext){
            _dbContext = dbContext;
        }
        public Vehicle Add(Vehicle model){
            return _dbContext.Add(model).Entity;
        }

        public int Commit(){
            return _dbContext.SaveChanges();
        }
        public List<Vehicle> GetAll(){
            return _dbContext.Vehicles.ToList();
        }
        public Vehicle GetById(int id){
            return _dbContext.Vehicles.Single(r => r.Id == id);
        }
        public void Delete(Vehicle model)
        {
            _dbContext.Vehicles.Remove(model);
        }
        public List<Vehicle> Get3Last(){
            return new List<Vehicle>();
        }
    }
}