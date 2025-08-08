using Microsoft.EntityFrameworkCore;
using TodoApp.Domain.Entities.Items;
using TodoApp.Infrastructure.Context.SqlServer;
using TodoApp.Infrastructure.Interface;

namespace TodoApp.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly TodoDBContext _DBContext;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(
            TodoDBContext dBContext,
            DbSet<T> dbSet)
        {
            _DBContext = dBContext;
            _dbSet = dbSet;
        }


        public async Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            IQueryable<T> query = _dbSet.AsNoTracking();
            if (typeof(T) == typeof(Item))
                query = query.Include(t => ((Item)(object)t).Category);

            return await query.ToListAsync();
        }
        public async Task<T> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _DBContext.Entry(entity).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
            return entity;
        }
        public async Task<T> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _DBContext.SaveChangesAsync();
            return entity;
        }
        public async Task<IEnumerable<T>> SearchItemAsync(string term)
        {
            if(typeof(T) == typeof(Item))
            {
                return await _DBContext.Set<Item>()
                    .Include(e => e.Category)
                    .Where(b => EF.Functions.Like(b.Name, $"%{term}%"))
                    .Cast<T>()
                    .ToListAsync();
            }
            else
                throw new InvalidOperationException("جسنجو فقد برای آیتم ها فعال است.");
        }   
    }
}
