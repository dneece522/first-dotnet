// See https://aka.ms/new-console-template for more information

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// Your code goes here

// if (daysUntilExpiration > 1)
// {
//   discountPercentage = 10;
// }
// else
// {
//   discountPercentage = 20;
// }

// if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
// {
//   Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
// {
//   Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
// }
// if (daysUntilExpiration == 1)
// {
//   Console.WriteLine($"Your subscription expires within a day.\nRenew now and save {discountPercentage}%!");
// }
// if (daysUntilExpiration == 0)
// {
//   Console.WriteLine($"Your subscription has expired.");
// }

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}