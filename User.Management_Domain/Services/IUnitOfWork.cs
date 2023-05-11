namespace User.Management_Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository NewUser { get; }
        IRoleRepository Role { get; }

        int Save();
    }
}
