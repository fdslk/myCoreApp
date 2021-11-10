using System;
using System.Collections.Generic;

namespace SingletonFunc
{
    public class LoadBalancer
    {
        private static LoadBalancer instance;
        private List<string> servers = new List<string>();
        private Random _random = new Random();
        
        private static object locker = new object();

        protected LoadBalancer()
        {
            // List of available servers
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public static LoadBalancer GetInstance()
        {
            if (instance != null) return instance;
            lock (locker)
            {
                instance ??= new LoadBalancer();
            }

            return instance;
        }
        
        public string Server
        {
            get
            {
                var r = _random.Next(servers.Count);
                return servers[r];
            }
        }
    }
}