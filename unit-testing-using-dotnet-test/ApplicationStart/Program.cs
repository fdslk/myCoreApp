using System;
using Prime.Services;

namespace ApplicationStart
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 120; i ++){
                Console.WriteLine(new PrimeService(i).getPrintWords());
            }
        }
    }
}