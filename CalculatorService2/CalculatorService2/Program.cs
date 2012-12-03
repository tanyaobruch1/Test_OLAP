using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace CalculatorService2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(CalculatorService));
            sh.Open();
            Console.WriteLine("up an running");
            Console.ReadLine();
            sh.Close();
            Console.WriteLine("closed");
        }
    }
}
