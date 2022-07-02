using System;
using System.Collections.Generic;
using Bread.Models;
using Pastry.Models;
using System.Drawing;
using Console = Colorful.Console;

namespace Bakery
{
  public class Program
  {
   public static void Main() 
   {
    Console.WriteLine("_____________________________________________________________________ \n", Color.Fuchsia); 
    Console.WriteLine("Welcome to Pierre's Patisserie! Home of fine bread and fine pastries.", Color.DeepSkyBlue);
    Console.WriteLine("_____________________________________________________________________ \n", Color.Fuchsia); 

    Console.WriteLine("Pricing for bread: Buy 2 loaves, get one free! Single loaf = $5, two loaves = $10 and three loaves = $10! \n \nPricing for pastry: 1 or 2 pastries = $2 each, 3 pastries = $5, 4 pastries = $7, 5 pastries = $9, 6 pastries = $10! \n", Color.Indigo);
    Console.WriteLine("Press 'Enter' to begin ordering some scrumptiousness... \n", Color.Green);
    Console.WriteLine("\n**Please enter numeric values, our website was built by a web development student and will crash otherwise**\n", Color.Red);

    string enterSite = Console.ReadLine();
  
    Console.WriteLine("How many loaves of bread would you like to order?\n", Color.DeepSkyBlue);
    
    BreadOrder newBreadOrder = new BreadOrder(Int32.Parse(Console.ReadLine()));

    if (newBreadOrder.TotalLoaves < 0 )
    {
      Console.WriteLine("Please enter 1, 2, or 3 loaves to buy.", Color.Red);

      Main();
    }
    else 
    {
      int breadTotal = newBreadOrder.FindBreadOrderTotal();
      Console.WriteLine("\nYour bread order comes to $" + breadTotal + ".\n", Color.Green);
      Console.WriteLine("_____________________________________________________________________ \n", Color.Fuchsia); 
    }

    Console.WriteLine("\nHow many pastries would you like to order? Current max pastry order is 6 pastries, thanks for understanding!\n", Color.DeepSkyBlue);
    PastryOrder newPastryOrder = new PastryOrder(Int32.Parse(Console.ReadLine()));

    if (newPastryOrder.TotalPastry > 6 || newPastryOrder.TotalPastry < 0 )
    {
      Console.WriteLine("\nPlease enter between 1 and 6 pastries to buy.\n", Color.Red);

      Main();
    }
    else 
    {
      int pastryTotal = newPastryOrder.FindPastryOrderTotal();
      Console.WriteLine("\nYour pastry order comes to $" + pastryTotal + ".\n", Color.Green);
      Console.WriteLine("_____________________________________________________________________ \n", Color.Fuchsia); 
    }
    int orderTotal = newBreadOrder.FindBreadOrderTotal() + newPastryOrder.FindPastryOrderTotal(); 

    Console.WriteLine("\nYour entire order comes to $" + orderTotal + ". Thanks for supporting us and enjoy your treats!\n", Color.DeepSkyBlue);
    Console.WriteLine("_____________________________________________________________________ \n", Color.Fuchsia); 
    Console.WriteLine("_____________________________________________________________________ \n", Color.Fuchsia); 

    int DA = 244;
    int V = 212;
    int ID = 255;
    for (int i = 0; i < 1; i++)
    {
      Console.WriteAscii("Goodbye :)", Color.FromArgb(DA, V, ID));

      DA -= 18;
      V -= 36;
    }

    Console.WriteLine("_____________________________________________________________________ \n", Color.Fuchsia); 
    Console.WriteLine("_____________________________________________________________________ \n", Color.Fuchsia); 
    }

   }
  }
