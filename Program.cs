// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, C#! This is my first .NET Application.");


Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);
Console.WriteLine(roll1);
Console.WriteLine(roll2);
Console.WriteLine(roll3);