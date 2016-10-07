using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{

    /*
     * Singleton pattern is one of the simplest design patterns in Java.
     *  This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
     *  
     *  This pattern involves a single class which is responsible to create an object while making sure that 
     *  only single object gets created. This class provides a way to access its only object which can be accessed
     *   directly without need to instantiate the object of the class.
     *   
     *   The Logger class is one of the example where we have to restrict the number of object instantiation to 1.
     */
    class SingletonCompare
    {
        static SingletonCompare scompare = null;
        private SingletonCompare()
        {
            Console.WriteLine("New SingletonCompare instance created");
        }
        public static SingletonCompare getCompareInstance() //Design Pattern : Singleton Pattern
        {
            if (scompare == null) //Checks if the instance is created already
            {
                scompare = new SingletonCompare();
            }
            else
                Console.WriteLine("Already created instace is returned");
            return scompare;
        }
        public bool ComapreString(string s1, string s2)
        {
            return s1.Equals(s2);
        }
    }
}
