// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

IEnumerable<int> numbers = Enumerable.Range(1, 100);
foreach (int num in numbers)
{
    string output = "";
    string output2 = "";
    if (num % 3 == 0 )
    {output += "Fizz";}
    if (num % 5 == 0)
    {output += "Buzz";}
    if (num % 7 == 0)
    {output += "Bang";}
    if (num % 11 == 0)
    {output = "Bong";}
    if (num % 13 == 0)
    {output2 = "Fezz";}
    if (output2 == "")
    {
        if (output == "")
    {Console.WriteLine(num);}
    else
    {Console.WriteLine(output);}
    }
    else
    {
        pass
    }
    
    
}
