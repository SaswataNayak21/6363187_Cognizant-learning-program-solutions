using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("This is the first log message.");
            logger2.Log("This is the second log message.");

            if (object.ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("Both logger instances are the same, Hence Singleton works!");
            }
            else
            {
                Console.WriteLine("Logger instances are different. Singleton failed.");
            }
            Console.ReadLine(); 
        }
    }
}
