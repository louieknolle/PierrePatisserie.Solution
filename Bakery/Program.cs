using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using Bakery.Models;
using Bread.Models;
using Pastry.Models;

namespace Bakery
{
  public class Program
  {
   public static void Main() 
   {
    Console.WriteLine("_____________________________________________________________________ \n"); 
    Console.WriteLine("Welcome to Pierre's Patisserie! Home of fine bread and fine pastries.", Color.DeepSkyBlue);
    Console.WriteLine("_____________________________________________________________________\n"); 

    Console.WriteLine("Pricing for bread: Buy 2 loaves, get one free! Single loaf = $5, two loaves = $10 and three loaves = $10! \n \n Pricing for pastry: 1 or 2 pastries = $2 each, 3 pastries = $5, 4 pastries = $7, 5 pastries = $9, 6 pastries = $10! \n");
    Console.WriteLine("Press 'Enter' to begin ordering some scrumptiousness... \n", Color.Green);
    string enterSite = Console.ReadLine();

    Console.WriteLine("How many loaves of bread would you like to order? Since we're a small business, current limit is three loaves.");
    BreadOrder newBreadOrder = new BreadOrder(Int32.Parse(Console.ReadLine()));

    if (newBreadOrder.TotalLoaves > 3 || newBreadOrder.TotalLoaves < 0 )
    {
      Console.WriteLine("Please enter 1, 2, or 3 loaves to buy.");

      Main();
    }
    else 
    {
      int breadTotal = newBreadOrder.FindBreadOrderTotal();
      Console.WriteLine("Your bread order comes to $" + breadTotal + ".");
    }

    Console.WriteLine("How many pastries would you like to order? Current max pastry order is 6 pastries, thanks for understanding!");
    PastryOrder newPastryOrder = new PastryOrder(Int32.Parse(Console.ReadLine()));

    if (newPastryOrder.TotalPastry > 6 || newPastryOrder.TotalPastry < 0 )
    {
      Console.WriteLine("Please enter between 1 and 6 pastries to buy.");

      Main();
    }
    else 
    {
      int pastryTotal = newPastryOrder.FindPastryOrderTotal();
      Console.WriteLine("Your pastry order comes to $" + pastryTotal + ".");
    }
    int orderTotal = newBreadOrder.FindBreadOrderTotal() + newPastryOrder.FindPastryOrderTotal(); 

    Console.WriteLine("Your entire order comes to $" + orderTotal + ". Thanks for supporting us and enjoy your treats!");
    }

   }
  }
