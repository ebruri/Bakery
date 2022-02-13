using System;

namespace Bakery.Models 
{
  public class Bread
  {
    public string Amount {get; set;}
    public Bread(string amount)
    {
      Amount = amount;
    }
    public int BreadCost() 
    {
      int dealPrice = int.Parse(this.Amount) / 3;
      int regularPrice = int.Parse(this.Amount) % 3;
      return dealPrice * 10 + regularPrice * 5;
    } 
  }
  public class Pastry
  {
    
  }
}