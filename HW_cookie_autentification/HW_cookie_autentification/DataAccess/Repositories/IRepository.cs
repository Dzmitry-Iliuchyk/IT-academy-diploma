namespace HW_cookie_autentification.DataAccess.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task Create(T entity);
        Task Delete(int id);
        Task Update(T entity);
        Task<T> GetDetails(int id );
    }
}
