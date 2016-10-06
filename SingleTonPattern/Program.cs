using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Compare cp = new Compare();
            Console.WriteLine("Is strings equal :: "+cp.ComapreString("1", "2"));
            Console.WriteLine("Is strings equal :: " + cp.ComapreString("2", "2"));

            //Singleton pattern use
            SingletonCompare scomapre = SingletonCompare.getCompareInstance();
            Console.WriteLine("Is strings equal :: " + scomapre.ComapreString("1", "2"));
            Console.WriteLine("Is strings equal :: " + scomapre.ComapreString("2", "2"));
            Console.ReadLine();
            AnotherComparision();


        }
        private static void AnotherComparision()
        {
            Compare cp = new Compare();
            Console.WriteLine("Is strings equal :: " + cp.ComapreString("3", "3"));
            Console.WriteLine("Is strings equal :: " + cp.ComapreString("4", "3"));
            //No further instance of Singleton class was created
            SingletonCompare scomapre = SingletonCompare.getCompareInstance();
            Console.WriteLine("Is strings equal :: " + scomapre.ComapreString("3", "3"));
            Console.WriteLine("Is strings equal :: " + scomapre.ComapreString("4", "3"));
            Console.ReadLine();
        }
    }
}
