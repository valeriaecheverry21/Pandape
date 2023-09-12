using Microsoft.EntityFrameworkCore;
using Pandape.Infrastructure.Persistence.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pandape.Infrastructure.Persistence.Repositories
{
    public class QueryRepository<T> : IQueryRepository<T> where T : class
    {
        private PandapeContext _context;

        private DbSet<T> _dbSet;

        public QueryRepository(PandapeContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate) => await _dbSet.Where(predicate).ToListAsync();

        public async Task<IEnumerable<T>> GetAll() => await _dbSet.ToListAsync();

        public async Task<T> GetById(int id) => await _dbSet.FindAsync(id);
    }
}
