using App.Models;

namespace App.Data
{
    public class EFVehicleCategoryRepository : IRepository<VehicleCategory>
    {
        private readonly AppDbContext _dbContext;

        public EFVehicleCategoryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public VehicleCategory Add(VehicleCategory model)
        {
            return _dbContext.VehicleCategories.Add(model).Entity;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public List<VehicleCategory> GetAll()
        {
            return _dbContext.VehicleCategories.ToList();
        }

        public VehicleCategory GetById(int id)
        {
            return _dbContext.VehicleCategories.Single(r => r.Id == id);
        }
        public void Delete(VehicleCategory model)
        {
            _dbContext.VehicleCategories.Remove(model);
        }
        public List<VehicleCategory> Get3Last(){
            return new List<VehicleCategory>();
        }
    }
}