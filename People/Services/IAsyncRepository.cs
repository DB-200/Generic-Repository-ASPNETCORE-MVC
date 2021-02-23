using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Services
{
    public interface IAsyncRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        void Delete(int id);
        void Update(T entity);

        //read side (could be in separate Readonly Generic Repository)
        T GetById(int id);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        //separate method SaveChanges can be helpful when using this pattern with UnitOfWork
        void SaveChanges();

        Task SaveChangesAsync();
    }
}
