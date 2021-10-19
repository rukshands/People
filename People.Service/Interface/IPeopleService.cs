using People.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Service.Interface
{
    public interface IPeopleService
    {
        Person GetById(int id);
        List<Person> GetAll();
    }
}
