using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernekar.SingletonPattern
{
    class Program
    {
        public static int TB1Value = -1;
        public static int TB2Value = -1;

        static void Main(string[] args)
        {
            // By using - SingletonLoggerLegacy
            List<int> hashData1 = new List<int>();
            for (int i = 0; i < 5; i++)
                hashData1.Add(SingletonLoggerLegacy.Instance.GetHashCode());

            if (hashData1.Distinct().Count() == 1)
                Console.WriteLine("I am Singleton!");
            else
                Console.WriteLine("I am not Singleton!");


            // By using - SingletonLogger
            List<int> hashData = new List<int>();
            for (int i = 0; i < 5; i++)
                hashData.Add(SingletonLogger.SingletonLoggerInstance.GetHashCode());

            if (hashData.Distinct().Count() == 1)
                Console.WriteLine("I am Singleton!");
            else
                Console.WriteLine("I am not Singleton!");


            // By using - SingletonLoggerThreadSafe
            Task<int> task1 = Task.Run(ThreadBatch1);
            Task<int> task2 = Task.Run(ThreadBatch2);

            if (task1.Result == task2.Result && task1.Result != -1)
                Console.WriteLine("I am Singleton!");
            else
                Console.WriteLine("I am not Singleton!");

            Console.ReadLine();
        }

        public static int ThreadBatch1()
        {
            int val = -1;
            List<int> hashData = new List<int>();
            for (int i = 0; i < 50000000; i++)
                hashData.Add(SingletonLoggerThreadSafe.Instance.GetHashCode());

            var res = hashData.Distinct();
            if (res.Count() == 1)
            {
                Console.WriteLine("ThreadBatch1 - I am Singleton!");
                val = res.First();
            }
            else
                Console.WriteLine("ThreadBatch1 - I am not Singleton!");
            return val;
        }

        public static int ThreadBatch2()
        {
            int val = -1;
            List<int> hashData = new List<int>();
            for (int i = 0; i < 50000000; i++)
                hashData.Add(SingletonLoggerThreadSafe.Instance.GetHashCode());

            var res = hashData.Distinct();
            if (res.Count() == 1)
            {
                Console.WriteLine("ThreadBatch2 - I am Singleton!");
                val = res.First();
            }
            else
                Console.WriteLine("ThreadBatch2 - I am not Singleton!");
            return val;
        }
    }
}
