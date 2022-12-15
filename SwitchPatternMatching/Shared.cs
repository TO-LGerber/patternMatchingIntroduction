using Shared.Models;

namespace Shared.Helpers
{
    public static class Helper
    {
        private static Random _random = new();
        private static readonly List<Product> _randomProducts = new()
        {
            new Car() { Brand = "Mercedes" },
            new House(),
            new Car() { Brand = "BMW" },
            new Car() { Brand = "Mazda" },
            new House() { Kitchen = new House.Room() { Length = 1d, Width = 1d } },
            new House() { Kitchen = new House.Room() { Length = 4, Width = 4 } }
        };

        public static Product GetRandomProduct()
        {
            var randomNumber = _random.Next(0, _randomProducts.Count);
            return _randomProducts[randomNumber];
        }
    }
}

namespace Shared.Models
{
    public class Product
    {
        public int Id { get; set; }
    }

    public class Car : Product
    {
        public string Brand { get; set; }

        private List<string> _germanBrands = new List<string>() { "BMW", "Mercedes" };

        public bool IsGermanBrand() => _germanBrands.Contains(Brand);
    }

    public class House : Product
    {
        public Room Kitchen { get; set; }

        public partial class Room
        {
            public double Length { get; set; }
            public double Width { get; set; }
        }
    }
}