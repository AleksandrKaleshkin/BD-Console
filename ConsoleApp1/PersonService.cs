using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PersonService
    {
        public void AddPerson(string name, int age)
        {
            using (var context = new ApplicationContext())
            {


                var person = new Person()
                {
                    Name = name,
                    Age = age
                };
                context.Persons.Add(person);
                context.SaveChanges();
            }
        }

        public void ChangePerson(int? idNum, string newName, int newAge)
        {
            using (var db = new ApplicationContext())
            {
                var person = db.Persons.FirstOrDefault(y => y.ID == idNum);
                if (person != null)
                {
                    person.Name = newName;
                    person.Age = newAge;
                    db.SaveChanges();
                }

            }
        }

        public void DelPerson(int? idNum)
        {
            using (var db = new ApplicationContext())
            {
                var person = db.Persons.FirstOrDefault(u => u.ID == idNum);
                if (person != null)
                {
                    db.Persons.Remove(person);
                    db.SaveChanges();
                }

            }
        }

        public List<Person> ShowPerson()
        {
            using (var context = new ApplicationContext())
            {
                var persons = context.Persons.ToList();
                return persons;
            }
        }

        public void DeleteAll()
        {
            using (var db = new ApplicationContext())
            {
                db.Persons.RemoveRange(db.Persons);
                db.SaveChanges();
            }

        }
    }
}

