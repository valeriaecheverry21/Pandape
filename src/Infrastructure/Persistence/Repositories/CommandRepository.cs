using Microsoft.EntityFrameworkCore;
using Pandape.Infrastructure.Persistence.DataBase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pandape.Infrastructure.Persistence.Repositories
{
    public class CommandRepository<T> : ICommandRepository<T> where T : class
    {
        private PandapeContext _context;

        private DbSet<T> _dbSet;

        public CommandRepository(PandapeContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task Insert(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(object id)
        {
            var entity = _dbSet.FindAsync(id);
            await Delete(entity.Result);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

    }
}
