using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Pierre's Bakery!");
      Console.WriteLine("Would you like to buy bread or pastry?[bread/pastry]");
      string order = Console.ReadLine();
      Console.WriteLine("-----------------");
      Console.WriteLine("How many would you like to buy?");
      string quantity = Console.ReadLine();
      if (order == "bread")
      {
        Bread newBread = new Bread(quantity);
        int breadCost = newBread.BreadCost();
        Console.WriteLine($"Total :  ${breadCost}");
      }
      else if (order == "pastry")
      {
        Pastry newPastry = new Pastry(quantity);
        int pastryCost = newPastry.PastryCost();
        Console.WriteLine($"Total : ${pastryCost}");
      }
      else
      {
        Main();
      }
      Main();
    }
  }
}