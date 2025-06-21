using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExample
{
    internal class Logger
    {
        // Private static variable to hold the single instance
        private static Logger _instance;

        // Lock object for thread safety
        private static readonly object _lock = new object();

        // Private constructor to prevent external instantiation
        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        // Public static method to get the single instance
        public static Logger GetInstance()
        {
            // Double-checked locking for thread safety
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }

        // Example method to demonstrate logging
        public void Log(string message)
        {
            Console.WriteLine($"Log Entry: {message}");
        }
    }
}
