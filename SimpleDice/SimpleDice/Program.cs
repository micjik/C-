// See https://aka.ms/new-console-template for more information

int playerPoints = 0;
int enemyPoints = 0;

for (int i = 0; i <= 10; i++)
{
    int playerRandom;
    int enemyRandom;
    Random random = new Random();

    Console.WriteLine("Press any key to roll a dice");
    Console.ReadKey();

    playerRandom = random.Next(1, 7);
    Console.WriteLine($"You rolled a {playerRandom}");

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);

    enemyRandom = random.Next(1, 7);
    Console.WriteLine($"Enemy AI rolled a {enemyRandom}");

    if(playerRandom > enemyRandom)
    {
        playerPoints++;
    }
    else if ( playerRandom < enemyRandom)
    {
        enemyPoints++;
    }
    else
    {
        Console.WriteLine("Draw");
    }
    Console.WriteLine($"The Score is now - Player: {playerPoints}. Enemy: {enemyPoints} ");
    Console.WriteLine();

    
}

    if (playerPoints > enemyPoints)
{
    Console.WriteLine("playerRandom wins")
}
else if (playerPoints < enemyPoints)
{
    Console.WriteLine("enemyRandom wins");
}
else
{
    Console.WriteLine("No one wins");
}
