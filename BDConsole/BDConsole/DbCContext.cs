using System;
using System.Data.Entity;

namespace BDConsole
{
    public class DbCContext: DbContext
    {
        public DbCContext(): base ("DBConnectionString")
        {

        }

        public DbSet<Person> Persons { get; set; }


    }
}
