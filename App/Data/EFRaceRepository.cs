using App.Models;

namespace App.Data
{
    public class EFRaceRepository : IRepository<Race>
    {
        private readonly AppDbContext _dbContext;

        public EFRaceRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Race Add(Race model)
        {
            return _dbContext.Races.Add(model).Entity;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public List<Race> GetAll()
        {
            return _dbContext.Races.ToList();
        }

        public List<Race> Get3Last()
        {
            return _dbContext.Races.Take(3).ToList();
        }

        public Race GetById(int id)
        {
            return _dbContext.Races.Single(r => r.Id == id);
        }

        public void Delete(Race model)
        {
            _dbContext.Races.Remove(model);
        }
    }
}