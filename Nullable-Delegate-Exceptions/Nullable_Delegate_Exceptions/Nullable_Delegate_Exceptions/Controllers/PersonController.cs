using DomainLayer.Models;
using ServiceLayer.Service;
using ServiceLayer.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Delegate_Exceptions.Controllers
{
    public class PersonController
    {
        private readonly IPersonService _service;

        public PersonController()
        {
            _service = new PersonService();
        }

        public void ShowPersonByFiltered()
        {
            _service.ShowPersonByFiltered();
        }

     
    }



}
