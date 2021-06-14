namespace TestCast
{
    public class TestDelegate{
        public delegate void Del(string str);

        public static void DelMethod(string str){
            System.Console.WriteLine(str);
        }
        public void DelMethod2(string str){
            System.Console.WriteLine(str+str);
        }
        public void DelMethod3(string str){
            System.Console.WriteLine(str+str+str);
        }

        public static void MethodWithCallBack(int param1, int param2, Del callback){
            callback($"----------{(param1+param2).ToString()}-----------");
        }
    }
}