using People.Core.Entities;
using People.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Infrastructure
{
    public class PersonRepository : IPersonRepository
    {
        public Person GetById(int id)
        {
            return new Person { Id = id, Name = "Rukshan" };
        }
    }
}
