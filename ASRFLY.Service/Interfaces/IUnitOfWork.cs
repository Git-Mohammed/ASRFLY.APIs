using ASRFLY.Application.Commons.Result;
using ASRFLY.Domain.Interfaces.IRepository;
namespace ASRFLY.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;

        Result SaveChanges();
        Task<Result> SaveChangesAsync();

        Result StartTransaction();
        Task<Result> StartTransactionAsync();

        Result Commit();
        Task<Result> CommitAsync();

        Result Rollback();
        Task<Result> RollbackAsync();
    }
}
