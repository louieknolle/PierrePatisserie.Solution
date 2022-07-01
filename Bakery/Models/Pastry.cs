using System.Collections.Generic;
using System;
using Bakery.Models;
using Bread.Models;

namespace Pastry.Models {

  public class PastryOrder
  {
    public int TotalPastry { get; }

    public PastryOrder(int totalPastry)
    {
      TotalPastry = totalPastry;

      // _instances.Add(this);
    }
  }
}