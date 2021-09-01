using System;
using System.Globalization;

namespace FactoryDesignPattern
{
    public interface DateTimeFactory{
        DateTime ConvertLocalDatetime(int yyyyMMdd); 

        static DateTimeFactory GetFactory(){
            return factory;
        }

        static DateTimeFactory factory = new DateTimeFactoryImp();
    }

    public class DateTimeFactoryImp : DateTimeFactory
    {
        public DateTime ConvertLocalDatetime(int yyyyMMdd)
        {
            DateTime dateTime;
            DateTime.TryParseExact(yyyyMMdd.ToString(), "yyyyMMdd", 
                          CultureInfo.InvariantCulture,
                          DateTimeStyles.None, out dateTime);
            return dateTime;
        }
    }
}