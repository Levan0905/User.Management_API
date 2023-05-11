namespace User.Management_Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        INewUserRepository NewUser { get; }
        IRoleRepository Role { get; }

        int Save();
    }
}
