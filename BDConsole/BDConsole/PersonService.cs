using System;
using System.Collections.Generic;
using System.Linq;

namespace BDConsole
{
    public class PersonService
    {
        public Person AddPerson(string name, int age)
        {
            using (var context = new DbCContext())
            {


                var person = new Person()
                {
                    Name = name,
                    Age = age
                };
                context.Persons.Add(person);
                context.SaveChanges();
                return person;

            }
        }

        public Person ChangePerson(int? idNum, string newName, int newAge)
        {
            using (var db = new DbCContext())
            {
                var person = db.Persons.FirstOrDefault(y => y.ID == idNum);
                if (person != null)
                {
                    person.Name = newName;
                    person.Age = newAge;
                    db.SaveChanges();
                    return person;
                }
                else
                {
                    return null;
                }
            }
        }

        public Person DelPerson(int? idNum)
        {
            using (var db = new DbCContext())
            {
                var person = db.Persons.FirstOrDefault(u => u.ID == idNum);
                if (person != null)
                {
                    db.Persons.Remove(person);
                    db.SaveChanges();
                }
                return null;
                

            }
        }

        public List<Person> ShowPerson()
        {
            using (var context = new DbCContext())
            {
                var persons = context.Persons.ToList();
                return persons;
            }
        }

        public Person DeleteAll()
        {
            using (var db = new DbCContext())
            {
                db.Persons.RemoveRange(db.Persons);
                db.SaveChanges();
                return null;

            }

        }
    }
}
