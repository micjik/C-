// See https://aka.ms/new-console-template for more information
//the term state is used to describe the condition of the execution environment at a specific moment in time. As your code executes line by line, values are stored in variables. At any moment during execution, 
//the current state of the application is the collection of all values stored in memory.
//stateless methods are implemented so that they can work without referencing or changing any values already stored in memory.
//Stateless methods are also known as static methods.
//stateful methods are built in such a way that they rely on values stored
  //in memory by previous lines of code that have already been execu
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

int firstValue = 500;
int secondValue = 600;

int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine($" larger value: {largerValue}");
