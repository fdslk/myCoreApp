using System;

namespace SingletonFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetInstance();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }

        }
    }
}
