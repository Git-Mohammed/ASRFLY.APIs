using ASRFLY.Domain.Interfaces.Repository.GenericRepository;

namespace ASRFLY.Domain.Interfaces.Repositories.GenericRepository
{
    public interface IRepository<TEntity> : ICommandRepository<TEntity>, IQueryRepository<TEntity> where TEntity : class
    {

    }
}