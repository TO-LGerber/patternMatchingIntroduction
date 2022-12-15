object o = 2;

// Check if an object is from a specific type. 
// If so, create a variable called "i" and print its value
if (o is int i)
{
    Console.WriteLine($"Its an int {i}");
}
else
{
    Console.WriteLine("Its not an int");
}