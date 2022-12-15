using Shared.Models;

namespace SwitchPatternMatching;

public static class WithPatternMatching
{
    public static void Print(Product randomProduct)
    {
        // Check which product we have and then cast it to make some checks within the case
        switch (randomProduct)
        {
            // Following case: Object is from type House and Kitchen != null && Kitchen.Width == Kitchen.Length
            // same as house.Kitchen != null && h.Kitchen.Width == h.Kitchen.Length
            case House { Kitchen: not null } h when h.Kitchen.Width == h.Kitchen.Length: Console.WriteLine($"House with a squared kitchen of {h.Kitchen.Width * h.Kitchen.Length}m²"); break;
            // Following case: Object is from type House and Kitchen != null && Kitchen.Width <= 2 && Kitchen.Length <= 2
            // same as house.Kitchen != null && h.Kitchen.Width == h.Kitchen.Length
            case House { Kitchen.Width: <= 2, Kitchen.Length: <= 2 } h: Console.WriteLine("House with a small kitchen"); break;
            // Following case: Object is from type car and Brand is equal to "BMW"
            // same as car.Brand == "BMW"
            case Car c when c.Brand == "BMW": Console.WriteLine("Its a BMW"); break;
            // or
            case Car { Brand: "BMW" } c: Console.WriteLine("Its a BMW"); break;
            // Following case: Object is from type car and Brand is from a german company
            // same as car != null && !c.IsGermanBrand()
            case Car c when !c.IsGermanBrand(): Console.WriteLine("Its not a German Brand"); break;
            // Following case: Object is from type car
            // same as car != null && !c.IsGermanBrand().
            case Car c: Console.WriteLine($"Its a Car from {c.Brand}"); break;
            // same as above, but for a different type
            case House: Console.WriteLine("Its a house"); break;
            default: Console.WriteLine("No Match"); break;
        }
    }
}
