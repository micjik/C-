// See https://aka.ms/new-console-template for more information
Random random = new Random();
int dayUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine(dayUntilExpiration);

if (dayUntilExpiration <= 10 && dayUntilExpiration > 5)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (dayUntilExpiration <= 5 && dayUntilExpiration > 1 )
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in 5 days.\r\nRenew now and save {discountPercentage}%!");
}
else if (dayUntilExpiration <= 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!\r\nRenew now and save {discountPercentage}%!");
}
else
{
    Console.WriteLine("Your subscription has expired.");
}
