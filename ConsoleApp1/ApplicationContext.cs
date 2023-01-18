using Microsoft.EntityFrameworkCore;
using System;


namespace ConsoleApp1
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DbSet<Car> Cars { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Personsdb;Username=postgres;Password=12345");
        }
    }
}
