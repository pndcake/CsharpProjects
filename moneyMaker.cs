using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount in cents and I will give \nyour change in the fewest amount of coins: ");

      string amountAsString = Console.ReadLine();
      double amount = Convert.ToDouble(amountAsString);
      int quarterValue = 25;
      int dimeValue = 10;
      int nickelValue = 5;
      double quarters = Math.Floor(amount / quarterValue);
      double remainder = amount % quarterValue;
      double dimes = Math.Floor(remainder / dimeValue);
      remainder = remainder % dimeValue;
      double nickels = Math.Floor(remainder / nickelValue);
      remainder = remainder % nickelValue;

      Console.WriteLine($"{amount} cents is equal to...");
      Console.WriteLine($"Quarters: {quarters}");
      Console.WriteLine($"Dimes: {dimes}");
      Console.WriteLine($"Nickels: {nickels}");
      Console.WriteLine($"Pennies: {remainder}");
    }
  }
}