using Shared.Models;

namespace SwitchPatternMatching;

public static class WithoutPatternMatching
{
    public static void Print(Product randomProduct)
    {
        // Check which product we have and then cast it to make some checks within the case
        switch (randomProduct)
        {
            case House:
                var house = (House)randomProduct;
                if (house.Kitchen == null)
                {
                    Console.WriteLine("Its a house");
                }
                else if (house.Kitchen.Width == house.Kitchen.Length)
                {
                    Console.WriteLine($"House with a squared kitchen of {house.Kitchen.Width * house.Kitchen.Length}m²");
                }
                else if (house.Kitchen.Length <= 2 && house.Kitchen.Length <= 2)
                {
                    Console.WriteLine("House with a small kitchen");
                }
                else
                {
                    Console.WriteLine("Its a house");
                }
                break;
            case Car:
                var car = (Car)randomProduct;
                if (car.Brand == "BMW") Console.WriteLine("Its a BMW");
                else if (!car.IsGermanBrand()) Console.WriteLine("Its not a german brand");
                else Console.WriteLine($"Its a Car from {car.Brand}");
                break;

        }
    }
}
