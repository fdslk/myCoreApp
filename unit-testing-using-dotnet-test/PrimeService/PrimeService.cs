using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Prime.Services
{
    public class PrimeService
    {
        private int number;

        public PrimeService(int number)
        {
            this.number = number;
        }


        public bool IsPrime(int candidate)
        {
            if(candidate < 2){
                return false;
            }
            return true;
        }

        public string getPrintWords()
        {
            //TODO: use linq to refactor
            if(this.number%(3*5*7) == 0){
                return "FizzBuzzWhizz";
            }
            if(this.number%(3*5) == 0){
                return "FizzBuzz";
            }
            if(this.number%(3*7) == 0){
                return "FizzWhizz";
            }
            if(this.number%(5*7) == 0){
                return "BuzzWhizz";
            }
            if(this.number%3 == 0){
                return "Fizz";
            }
            if(this.number%5 == 0){
                return "Buzz";
            }
            if(this.number%7 == 0){
                return "Whizz";
            }
            return containNumber2Word();
        }

        private string containNumber2Word()
        {
            var checkNumDict = new Dictionary<int, string>(){
                {3, "Fizz"},
                {5, "Buzzz"},
                {7, "Whizz"},
            };
            foreach (var key in checkNumDict.Keys)
            {
                if(this.number.ToString().Contains(key.ToString())){
                    return checkNumDict[key];
                }
            }
            return this.number.ToString();
        }

        public Task<string> GetHtmlAsync()
        {
            // Execution is synchronous here
            var client = new HttpClient();

            return client.GetStringAsync("https://www.dotnetfoundation.org");
        }
    }
}