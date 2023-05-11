namespace User.Management_Domain.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        //T GetById(int id);
        //IEnumerable<T> GetAll();
        
        
        

        void Add(T entity);
        void SetRole(T entity);
        void ChangeRole(T entity);
        void Update(T entity);
        T GetByRole(string userrole);
        IEnumerable<T> Find();
    }
}
