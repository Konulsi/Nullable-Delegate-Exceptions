using DomainLayer.Models;
using ServiceLayer.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3) Person tipinden listimiz var. 
//   Maashi 1000-den cox olan personlarin ad, soyad ve addresini gosteren ve
//   parametr olaraq predicate qebul  eden method yazin.
namespace ServiceLayer.Service
{
    public class PersonService : IPersonService
    {
        public List<Person> ShowPersonFullData(Predicate<Person> func, List<Person> person)
        {
            var persons = GetAll();
            List<Person> persons1 = new();
            foreach (var item in person)
            {
                if (func(item))
                {
                    persons1.Add(item);
                }
            }
            return persons1;

        }

        public void ShowPersonByFiltered()
        {
            var persons = GetAll();
            var result = ShowPersonFullData(p => p.Salary > 1000, persons);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} {item.Surname} {item.Address}");
            }
        }


        public List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();

            Person person1 = new Person
            {
                Name = "Konul",
                Surname = "Ibrahimova",
                Address = "Neftchiler",
                Salary = 2500
            };

            Person person2 = new Person
            {
                Name = "Chinara",
                Surname = "Ibadova",
                Address = "Lokbatan",
                Salary = 2000
            };

            Person person3 = new Person
            {
                Name = "Zaur",
                Surname = "Aslanov",
                Address = "Suraxani",
                Salary = 1500
            };

            Person person4 = new Person
            {
                Name = "Tural",
                Surname = "Huseynov",
                Address = "Xetai",
                Salary = 900
            };

            Person person5 = new Person
            {
                Name = "Sabina",
                Surname = "Abbasova",
                Address = "Genclik",
                Salary = 1000
            };

            Person person6 = new Person
            {
                Name = "Lale",
                Surname = "Isayeva",
                Address = "Nerimanov",
                Salary = 1300
            };

            persons.Add(person1);
            persons.Add(person2);   
            persons.Add(person3);   
            persons.Add(person4);
            persons.Add(person5);   
            persons.Add(person6);   
            
            return persons; 
        }  
    }
    
}
