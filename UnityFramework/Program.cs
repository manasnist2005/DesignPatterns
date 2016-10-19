using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer obj = Factory.CreateInstance();
            obj.PlayerName = " Sachin Tendulkar ";
            obj.TeamName = " India ";
            obj.DisplayDetails();
            IPlayer obj1 = Factory.CreateInstance();
            obj.PlayerName = " Shane warne";
            obj.TeamName = " Australia ";
            obj.JerseyColour = "Yellow";
            obj.DisplayDetails();
            Console.Read();
        }
    }
}
