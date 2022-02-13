using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Pierre's Bakery!");
      Console.WriteLine("How many bread would you like?");
      string breadOrder = Console.ReadLine();
      Console.WriteLine("-------------------------------");
      Console.WriteLine("How many pastry would you like?");
      string pastryOrder = Console.ReadLine();
      Console.WriteLine("-------------------------------");
      Bread newBread = new Bread(breadOrder);
      Pastry newPastry = new Pastry(pastryOrder);
      int totalCost = newBread.BreadCost() + newPastry.PastryCost();
      Console.WriteLine($"{breadOrder} X Bread : ${newBread.BreadCost()}");
      Console.WriteLine($"{pastryOrder} X Pastry : ${newPastry.PastryCost()}");
      Console.WriteLine($"Total :  ${totalCost}");
      Console.WriteLine("-------------------------------");
      Console.WriteLine("-------------------------------"); 
      Main();
    }
  }
}