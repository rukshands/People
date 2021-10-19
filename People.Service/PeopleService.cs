using People.Core.Interfaces;
using People.Service.Interface;
using People.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Service
{
    public class PeopleService : IPeopleService
    {
        private readonly IPersonRepository _personRepository;

        public PeopleService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<Person> GetAll()
        {
            var people = new List<Person>();

            for (int i = 0; i < 5; i++)
            {
                people.Add(new Person { Id = i, Name = $"Person {i}" });
            }

            return people;
        }

        public Person GetById(int id)
        {
            var entity = _personRepository.GetById(id);

            if (id == 0)
                return null;

            if (id == 6)
                throw new ArgumentException("Invalid argument");

            return new Person
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}
