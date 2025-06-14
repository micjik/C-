// See https://aka.ms/new-console-template for more information
//Arrays can be used to store multiple values of the same type in a single variable
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

string[] names = ["Bolaji", "Tunde", "Deji"];
foreach(string name in names )
{
    Console.WriteLine(name);

}
int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
foreach(int i in inventory )
{
    sum += i;
    Console.WriteLine(i);
    
}
Console.WriteLine(sum);

string[] fraudIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach(string i in fraudIds )
{
   

    if(i.StartsWith("B"))
    {
        Console.WriteLine(i);
    }
}

