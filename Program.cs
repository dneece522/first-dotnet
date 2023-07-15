// See https://aka.ms/new-console-template for more information

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if (daysUntilExpiration > 1)
{
  discountPercentage = 10;
}
else
{
  discountPercentage = 20;
}

if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
{
  Console.WriteLine("Your subscription will expire soon. Renew now!");
}
if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
{
  Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
}
if (daysUntilExpiration == 1)
{
  Console.WriteLine($"Your subscription expires within a day.\nRenew now and save {discountPercentage}%!");
}
if (daysUntilExpiration == 0)
{
  Console.WriteLine($"Your subscription has expired.");
}