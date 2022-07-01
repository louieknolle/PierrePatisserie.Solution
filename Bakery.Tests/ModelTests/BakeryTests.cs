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
      BreadOrder newBreadOrder = new BreadOrder();
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnNumberOfLoaves_Int()
    {
      int loavesTotal = 3;
      BreadOrder newBreadOrder = new BreadOrder(loavesTotal);
      int total = newBreadOrder.TotalLoaves
      Assert.AreEqual(loavesTotal, total);
    }
  }

  // [TestClass]
  // public class PastryTests
  // {
    
  // }

}



 //     [TestMethod]
 // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
 // {
 //   // any necessary logic to prep for test; instantiating new classes, etc.
 //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
 // }