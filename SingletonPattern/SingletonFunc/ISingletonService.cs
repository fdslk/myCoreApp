using System;

namespace SingletonFunc
{
    public class ISingletonService
    {
        static ISingletonService instance;
        private ISingletonService() { }
        public static ISingletonService GetInstance()
        {
            return instance ??= new SingletonFunc.ISingletonService();
        }
    }
}
