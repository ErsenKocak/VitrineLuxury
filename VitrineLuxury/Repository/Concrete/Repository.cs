using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Core.DataAccess;
using VitrineLuxury.DataAccess;

namespace VitrineLuxury.DataAccess.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected AppDbContext _appDbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<TEntity>();
        }


        
        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {   
            return await _dbSet.FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.SingleOrDefaultAsync(predicate);
        }

        public TEntity Update(TEntity entity)
        {
            _appDbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }
}
