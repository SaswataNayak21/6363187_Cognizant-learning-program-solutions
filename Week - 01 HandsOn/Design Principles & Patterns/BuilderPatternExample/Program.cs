using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamingPC = new Computer.Builder()
                .SetCPU("Intel i9")
                .SetRAM("32GB")
                .SetStorage("1TB SSD")
                .SetGraphicsCard("NVIDIA RTX 4090")
                .Build();

            var officePC = new Computer.Builder()
                .SetCPU("Intel i3")
                .SetRAM("8GB")
                .SetStorage("512GB SSD")
                .Build();

            Console.WriteLine("Gaming PC: " + gamingPC);
            Console.WriteLine("Office PC: " + officePC);

            Console.ReadLine();
        }
    }
}
