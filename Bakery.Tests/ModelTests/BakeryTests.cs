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
  }
}