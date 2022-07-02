using System.Collections.Generic;
using System;
using Bakery.Models;
using Pastry.Models;

namespace Bread.Models {

  public class BreadOrder
  {
    public int TotalLoaves { get; set; }

    public BreadOrder(int totalLoaves)
    {
      TotalLoaves = totalLoaves;

      // _instances.Add(this);
    }
    
    public int FindBreadOrderTotal()
    {
      int orderTotal = 0;
      int total = TotalLoaves;
      if (total == 1) 
      {
        orderTotal = 5;
      }
      return orderTotal;
    }
  }
}