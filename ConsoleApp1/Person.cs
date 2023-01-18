
namespace ConsoleApp1
{
    internal class Person
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
