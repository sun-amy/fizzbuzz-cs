// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

IEnumerable<int> numbers = Enumerable.Range(1, 100);
foreach (int num in numbers)
{
    if (num % 3 == 0 && num % 5 == 0)
    {Console.WriteLine("FizzBuzz");}
    else if (num % 3 == 0)
    {Console.WriteLine("Fizz");}
    else if (num % 5 == 0)
    {Console.WriteLine("Buzz");}
    else
    {Console.WriteLine(num);}
}
