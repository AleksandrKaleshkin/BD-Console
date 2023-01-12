using System;
using System.Data.Entity;

namespace BDConsole
{
    public class BDContext: DbContext
    {
        public BDContext(): base ("DBConnectionString")
        {

        }

        public DbSet<Person> Persons { get; set; }


    }
}
