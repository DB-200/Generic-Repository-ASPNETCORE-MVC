using People.Data;
using People.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Services
{
    public class PersonRepository : EFRepository<Person>, IPersonRepository
    {
        public PersonRepository(PersonContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<Person>> GetPeopleAsync()
        {
            return await GetAllAsync();
        }

        public bool PersonExists(int id)
        {
            return PersonContext.People.Any(e => e.Id == id);
        }

        public bool Any(int id)
        {
            return PersonContext.People.Any(e => e.Id == id);
        }

        public PersonContext PersonContext
        {
            get
            {
                return DataDbContext as PersonContext;
            }
        }


    }
}
