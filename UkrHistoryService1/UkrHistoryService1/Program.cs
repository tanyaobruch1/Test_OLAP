using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace UkrHistoryService1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(UkrHistoryService));
            sh.Open();
            Console.WriteLine("up and running");
            Console.ReadLine();

            sh.Close();
            Console.WriteLine("closed");
        }
    }
}
