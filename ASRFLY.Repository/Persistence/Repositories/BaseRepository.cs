using ASRFLY.Domain.Interfaces.Repositories.GenericRepository;
using ASRFLY.Infrastructure.EntityFrameworkCore.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ASRFLY.Infrastructure.Persistence.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        // Variables
        private readonly AppDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        // Constructors
        protected BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        // Properties
        public IQueryable<TEntity> Table => _dbSet;

        #region Methods
        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public virtual async Task AddAsync(TEntity entity)
        {
                await _dbSet.AddAsync(entity);

        }
        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
           
            _dbSet.AddRange(entities);
        }
        public virtual async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }
        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        public virtual async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => _dbSet.Remove(entity));
        }
        public virtual void DeleteRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }
        public virtual async Task DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            await Task.Run(() => _dbSet.RemoveRange(entities));
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return  _dbSet;
        }
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await  _dbSet.ToListAsync();
        }
        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
        public virtual async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => _dbSet.Update(entity));
        }
        public virtual void UpdateRange(IEnumerable<TEntity> entities)
        {
 
            _dbSet.UpdateRange(entities);
        }
        public virtual async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
 
            await Task.Run(() => _dbSet.UpdateRange(entities));
        }
        #endregion
    }
}
