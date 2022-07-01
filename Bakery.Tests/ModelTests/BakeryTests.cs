using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;
using Bread.Models;
using Pastry.Models;

namespace Bakery.Tests
{
  // [TestClass]
  // public class BakeryTests
  // {

  // }
  
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

      [TestMethod]
      public void FindBreadOrderTotal_CalculatePriceOfOneLoad_Int();
      {
        int totalLoaves = 1;
        int orderTotal = FindBreadOrderTotal(totalLoaves);
        Assert.AreEqual(5, orderTotal);
      }
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
  }

}



 //     [TestMethod]
 // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
 // {
 //   // any necessary logic to prep for test; instantiating new classes, etc.
 //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
 // }