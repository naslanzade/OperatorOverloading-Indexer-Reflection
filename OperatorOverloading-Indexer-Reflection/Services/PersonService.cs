using OperatorOverloading_Indexer_Reflection.Models;
using OperatorOverloading_Indexer_Reflection.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading_Indexer_Reflection.Services
{
    public class PersonService : IPersonService
    {
        public int GetFilteredDatasCount(Predicate<Person> predicate)
        {
            var datas = GetData();
            var filteredDatas = datas.FindAll(predicate);
            var result = Math.Pow(filteredDatas.Count,2);

            return (int)result;

        }

        public List<string> GetFullData(Predicate<Person> predicate)
        {

            var people = GetAll();
            var result = people.FindAll(predicate);
           
            
            return GetPersonDetails(result);

            
        }



        private List<Person> GetData()
        {
            List<Person> people = new List<Person>();

            Person person1 = new()
            {
                Name = "Resul"                
            };                    

            Person person2 = new()
            {
                Name = "Cavid"                
            };

            Person person3 = new()
            {
                Name = "Gultac",                
            };

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            
            return people;

        }




        private List<Person> GetAll()
        {
            List<Person> people = new List<Person>();

            Person person1 = new()
            {
                Name = "Resul",
                Surname = "Hesenov",
                Address = "Xalqlar",
                Salary = 400
            };

            Person person2 = new()
            {
                Name = "Novrasta",
                Surname = "Aslanzade",
                Address = "Azadliq",
                Salary = 700
            };

            Person person3 = new()
            {
                Name = "Qoshqar",
                Surname = "Nerimanli",
                Address = "Ehmedli",
                Salary = 8000
            };

            Person person4 = new()
            {
                Name = "Lale",
                Surname = "Quliyeva",
                Address = "Nesimi",
                Salary = 2000
            };

            Person person5 = new()
            {
                Name = "Gultac",
                Surname = "Ceferova",
                Address = "Tbilisi",
                Salary = 10000
            };

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            return people;
        }


        private List<string> GetPersonDetails(List<Person> people )
        {
            List<string> fullDatas = new();

            foreach (var item in people)
            {
                string data = $"{item.Name + "-" + item.Surname + "-" + item.Address}";
                fullDatas.Add(data);
            }

            return fullDatas;
        }

         
    }
}
