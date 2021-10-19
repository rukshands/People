using People.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Core.Interfaces
{
    public interface IPersonRepository
    {
        Person GetById(int id);
    }
}
