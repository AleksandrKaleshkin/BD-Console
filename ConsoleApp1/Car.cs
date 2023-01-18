
namespace ConsoleApp1
{
    internal class Car
    {
        public int ID { get; set; }

        public string BrandCar { get; set; }

        public string ModelCar { get; set; }

        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
