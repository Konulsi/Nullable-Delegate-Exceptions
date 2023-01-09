using ServiceLayer.Service;
using ServiceLayer.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Delegate_Exceptions.Controllers
{
    public class FactorialController
    {
        private readonly IFactorial _service;

        public FactorialController()
        {
            _service= new Factorial();
        }

        public void GetNumFactorial()
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            _service.GetNumFactorial(num); 
            
        }
    }
}
