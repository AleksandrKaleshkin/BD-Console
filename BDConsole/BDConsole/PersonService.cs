using System;
using System.Collections.Generic;
using System.Linq;

namespace BDConsole
{
    public class PersonService
    {
        public void AddPerson(string name, int age)
        {
            using (var context = new BDContext())
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
            using (var db = new BDContext())
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
            using (var db = new BDContext())
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
            using (var context = new BDContext())
            {
                var persons = context.Persons.ToList();
                return persons;
            }
        }

        public void DeleteAll()
        {
            using (var db = new BDContext())
            {
                db.Persons.RemoveRange(db.Persons);
                db.SaveChanges();
            }

        }
    }
}
