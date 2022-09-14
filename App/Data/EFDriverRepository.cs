using App.Models;

namespace App.Data
{
    public class EFDriverRepository : IDriverRepository<Driver>
    {
        private readonly AppDbContext _dbContext;

         public EFDriverRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Driver Add(Driver model)
        {
            return _dbContext.Drivers.Add(model).Entity;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public List<Driver> GetAll()
        {
            return _dbContext.Drivers.ToList();
        }

        public Driver GetById(int id)
        {
            return _dbContext.Drivers.Single(r => r.Id == id);
        }

        public Driver GetByMail(string mail){
            return _dbContext.Drivers.Single(r => r.Email == mail);
        }

        public Driver GetByFirstName(string firstName){
            return _dbContext.Drivers.Single(r => r.FirstName == firstName);
        }
    }
}