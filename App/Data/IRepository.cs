namespace App.Data
{
    public interface IRepository<TModel> where TModel : class
    {
        List<TModel> GetAll();

        List<TModel> Get3Last();

        TModel GetById(int id);

        TModel Add(TModel model);

        int Commit();

        void Delete(TModel model);
    }
}