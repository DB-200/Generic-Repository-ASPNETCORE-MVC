using Microsoft.EntityFrameworkCore;
using People.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Services
{
    public class EFRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly DbContext DataDbContext;

        public EFRepository(DbContext dataContext)
        {
            DataDbContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }
        public void Add(T entity)
        {
            DataDbContext.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            DataDbContext.Set<T>().Remove(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return DataDbContext.Set<T>().Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await DataDbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DataDbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public void SaveChanges()
        {
            DataDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            DataDbContext.Entry<T>(entity).State = EntityState.Modified;
        }

        public async Task SaveChangesAsync()
        {
            await DataDbContext.SaveChangesAsync();
        }
    }
}
