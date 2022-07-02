using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;
using Bread.Models;
using Pastry.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadOrderConstructor_CreateInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrder = new BreadOrder(3);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnNumberOfLoaves_Int()
    {
      int totalLoaves = 3;
      BreadOrder newBreadOrder = new BreadOrder(totalLoaves);
      int resultTotal = newBreadOrder.TotalLoaves;
      Assert.AreEqual(totalLoaves, resultTotal);
    }

    [TestMethod]
    public void SetTotalLoaves_SetTotalLoaves_Int()
    {
      int totalLoaves = 3;
      BreadOrder newBreadOrder = new BreadOrder(totalLoaves);
      int updatedTotal = 5;
      newBreadOrder.TotalLoaves = updatedTotal;
      int resultTotal = newBreadOrder.TotalLoaves;
      Assert.AreEqual(updatedTotal, resultTotal);
    }

    [TestMethod]
    public void FindBreadOrderTotal_CalculatePriceOfOneLoaf_Int()
    {
      BreadOrder newBreadOrder = new BreadOrder(1);
      Assert.AreEqual(5, newBreadOrder.FindBreadOrderTotal());
    }

    [TestMethod]
    public void FindBreadOrderTotal_CalculatePriceOfTwoLoaves_Int()
    {
      BreadOrder newBreadOrder = new BreadOrder(2);
      Assert.AreEqual(10, newBreadOrder.FindBreadOrderTotal());
    }

    [TestMethod]
    public void FindBreadOrderTotal_CalculatePriceOfThreeLoaves_Int()
    {
      BreadOrder newBreadOrder = new BreadOrder(3);
      Assert.AreEqual(10, newBreadOrder.FindBreadOrderTotal());
    }

    [TestMethod]
    public void FindBreadOrderTotal_CalculatePriceOfMoreThan3Loaves_Int()
    {
      BreadOrder newBreadOrder = new BreadOrder(5);
      Assert.AreEqual(20, newBreadOrder.FindBreadOrderTotal());
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryOrderConstructor_CreateInstanceOfPastryOrder_PastryOrder()
    {
      PastryOrder newPastryOrder = new PastryOrder(3);
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnNumberOfPastry_Int()
    {
      int totalPastry = 3;
      PastryOrder newPastryOrder = new PastryOrder(totalPastry);
      int resultTotal = newPastryOrder.TotalPastry;
      Assert.AreEqual(totalPastry, resultTotal);
    }

    [TestMethod]
    public void SetTotalPastry_SetTotalPastry_Int()
    {
      int totalPastry = 3;
      PastryOrder newPastryOrder = new PastryOrder(totalPastry);
      int updatedTotal = 5;
      newPastryOrder.TotalPastry = updatedTotal;
      int resultTotal = newPastryOrder.TotalPastry;
      Assert.AreEqual(updatedTotal, resultTotal);
    }

    [TestMethod]
    public void FindPastryOrderTotal_CalculatePriceOfOnePastry_Int()
    {
      PastryOrder newPastryOrder = new PastryOrder(1);
      Assert.AreEqual(2, newPastryOrder.FindPastryOrderTotal());
    }

    [TestMethod]
    public void FindPastryOrderTotal_CalculatePriceOfOTwoPastry_Int()
    {
      PastryOrder newPastryOrder = new PastryOrder(2);
      Assert.AreEqual(4, newPastryOrder.FindPastryOrderTotal());
    }

    [TestMethod]
    public void FindPastryOrderTotal_CalculatePriceOfOThreePastry_Int()
    {
      PastryOrder newPastryOrder = new PastryOrder(3);
      Assert.AreEqual(5, newPastryOrder.FindPastryOrderTotal());
    }

    [TestMethod]
    public void FindPastryOrderTotal_CalculatePriceOfOFourPastry_Int()
    {
      PastryOrder newPastryOrder = new PastryOrder(4);
      Assert.AreEqual(7, newPastryOrder.FindPastryOrderTotal());
    }

    [TestMethod]
    public void FindPastryOrderTotal_CalculatePriceOfOFivePastry_Int()
    {
      PastryOrder newPastryOrder = new PastryOrder(5);
      Assert.AreEqual(9, newPastryOrder.FindPastryOrderTotal());
    }

    [TestMethod]
    public void FindPastryOrderTotal_CalculatePriceOfOSixPastry_Int()
    {
      PastryOrder newPastryOrder = new PastryOrder(6);
      Assert.AreEqual(10, newPastryOrder.FindPastryOrderTotal());
    }
  }
}