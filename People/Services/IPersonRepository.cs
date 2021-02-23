using People.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace People.Services
{
    public interface IPersonRepository : IAsyncRepository<Person>
    {
        Task<IEnumerable<Person>> GetPeopleAsync();
        bool PersonExists(int id);
        bool Any(int id);
    }
}