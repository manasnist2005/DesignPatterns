using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeDesignPattern;

namespace TestDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Facade design pattern demo
            ShoppingItem shopItem = new ShoppingItem(); //As this class is deeclared as public
            shopItem.GetItemDetails(); // This function calls the functions of the Stock and ItemCost class functions internally

            Console.ReadKey();
        }
    }
}
