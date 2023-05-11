namespace User.Management_Domain.Repository
{
    public interface IGenericRepository<T> where T : class
    {
    
        Task<T> Add(T entity);
        Task<T> Get(T entity);
        Task<T> Update(T entity);
        


    }
}
