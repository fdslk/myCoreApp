namespace TestCast
{
    public class SecondType{
        private MyType _value;

        public static implicit operator
        MyType(SecondType t){
            return t._value;
        }
    }
}