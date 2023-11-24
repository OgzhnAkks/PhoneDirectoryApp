using Microsoft.EntityFrameworkCore;
using PhoneDirectory.DataAccess.Services.Contexts;
using PhoneDirectory.DataAccess.Services.Repositores.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.DataAccess.Services.Repositores.Implementation
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly PersonContext _personContext;

        public GenericRepository(PersonContext personContext)
        {
            _personContext = personContext;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await _personContext.AddAsync(entity);
            await _personContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> AddRange(List<TEntity> entity)
        {
            await _personContext.AddRangeAsync(entity);
            await _personContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> Delete(TEntity entity)
        {
            _personContext.Remove(entity);

            return await _personContext.SaveChangesAsync();
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>>? filter = null)
        {
            return await _personContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(filter);
        }

        public async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>>? filter = null)
        {
            return await (filter == null ?
                   _personContext.Set<TEntity>().ToListAsync() :
                   _personContext.Set<TEntity>().Where(filter).ToListAsync());
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _personContext.Update(entity);
            await _personContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> UpdateRange(List<TEntity> entity)
        {
            _personContext.UpdateRange(entity);
            await _personContext.SaveChangesAsync();
            return entity;
        }
    }
}
