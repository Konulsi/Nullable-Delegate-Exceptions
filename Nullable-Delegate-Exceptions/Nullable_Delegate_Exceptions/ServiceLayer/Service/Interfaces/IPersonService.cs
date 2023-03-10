using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interfaces
{
    public interface IPersonService
    {
        List<Person> ShowPersonFullData(Predicate<Person> func, List<Person> person);
        void ShowPersonByFiltered();
    }
}
