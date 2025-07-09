namespace ASRFLY.Domain.Interfaces.Repositories.GenericRepository
{
    public interface IQueryRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
    }

}
