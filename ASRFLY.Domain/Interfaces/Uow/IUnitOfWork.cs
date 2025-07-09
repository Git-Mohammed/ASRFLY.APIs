namespace ASRFLY.Domain.Interfaces.Repositories.GenericRepository
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken  cancellationToken);
    }
   
}