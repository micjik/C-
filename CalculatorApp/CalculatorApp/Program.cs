// See https://aka.ms/new-console-template for more information
// In creating calculator App
// We need the following variables
using System.Threading.Channels;

int firstNumber;
int secondNumber;
string answer;
int result;

Console.WriteLine("Please enter the first number");
firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number");
secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What kind of calculation would you like to perform");
Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication and any other key for division");
answer = Console.ReadLine();

if (answer == "a")
{
    result = firstNumber + secondNumber;
}
else if (answer == "s")
{ 
    result = firstNumber - secondNumber;
}
else if (answer == "m")
{
    result = firstNumber * secondNumber;
}
else
{
    result = firstNumber / secondNumber;
}
Console.WriteLine($"The result: {result}");
Console.ReadKey();


