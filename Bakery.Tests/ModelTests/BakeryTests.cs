using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void
    BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      string bread = "5";
      Bread newBread = new Bread(bread);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
      
    }
    [TestMethod]
    public void
    BreadCost_CalculatesTheCost_Int()
    {
      string bread = "5";
      int expected = 20;
      Bread newBread = new Bread(bread);
      int result = newBread.BreadCost();
      Assert.AreEqual(expected, result);
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void
    PastyConstructor_CreatesInstanceOfPastry_Pastry()
    {
      string bread = "5";
      Bread newBread = new Bread(bread);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void    
    PastryCost_CalculatesTheCost_Int()
    {
      string pastry = "5";
      int expected = 9;
      Pastry newPastry = new Pastry(pastry);
      int result = newPastry.PastryCost();
      Assert.AreEqual(expected, result);
    }
  }
}