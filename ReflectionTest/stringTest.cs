using System;
using System.Collections.Generic;
using System.Linq;

namespace ReflectionTest
{
    public static class StringTest{
        
        /* 
            内插字符串
         */
        public static void stringTest(){
            
            System.Console.WriteLine($"The Value of pi is {Math.PI.ToString("F2")}");
            System.Console.WriteLine($"The Value of pi is {Math.PI:F2}");
            System.Console.WriteLine($"The Value of pi is {Math.PI:F2}");

            string result = default(string);
            Dictionary<string, string> records = new Dictionary<string, string>();
            string index = "11";
            List<int> lists = new List<int>();
            for (int i = 10; i >= 0 ; i--)
            {
                records.Add(i.ToString(), (i+1).ToString());
                lists.Add(i);
            }
            //3 mesh expression
            System.Console.WriteLine($@"Record is {(records.TryGetValue(index, out result) ? result :
                $"No record found at index {index} ")}");
            
            //linq expression
            System.Console.WriteLine($@"The First five item are: {lists.Take(5).Select(
                n => $@"Item: {n.ToString()}").Aggregate(
                    (c, a)=>$@"{c}{Environment.NewLine}{a}")}"); 

            System.Console.WriteLine($@"The item more than 6 are: {
                string.Join(", ", lists.Where(item => item > 5).ToList())
            }");   
        }
    }
}