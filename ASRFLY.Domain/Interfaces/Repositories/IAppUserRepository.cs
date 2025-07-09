using ASRFLY.Domain.Entities;

namespace ASRFLY.Domain.Interfaces.Repositories.GenericRepository
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        Task<AppUser> FindByIdAsync(int id);
        Task<AppUser?> FindByUsernameAsync(string userName);
    }
}
