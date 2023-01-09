using ServiceLayer.Exceptions;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class Factorial : IFactorial
    {
     
        public void GetNumFactorial(int num)
        {
            int multiple = 1;

            try
            {
                if (num > 0)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        multiple = multiple * i;

                    }
                    Console.WriteLine(multiple);
                }
                else
                {
                    throw new InvalidNumberException(ExceptionsMessage.InvalidNumber);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
        }
    }
}
