using System.Text.RegularExpressions;
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.Write("Please enter start number: ");
int userInput = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter end number: ");
int userInput2 = Convert.ToInt32(Console.ReadLine());

IEnumerable<int> numbers = Enumerable.Range(userInput, userInput2 - userInput + 1);
foreach (int num in numbers)
{
    string output = "";
    string output2 = "";
    object finalOutput;
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
        {finalOutput = num;}
        else
        {finalOutput = output;}
    }
    else
    {
        if (output.IndexOf("F") == -1)
        {finalOutput = output + output2;}
        else 
        {finalOutput = output.Insert(output.IndexOf('F'), output2);}
    }
    if (num % 17 != 0)
    {
        Console.WriteLine(finalOutput);
        }
    else
    {
        if (finalOutput is int)
        {Console.WriteLine(finalOutput);}
        else if (finalOutput is string str)
        {
            var words = Regex.Split(str, @"(?=[A-Z])");
            var reversedOutput = string.Concat(words.Reverse());
            Console.WriteLine(reversedOutput);
        } 
    }

}
