namespace ReflectionTest
{
    internal class Car
    {
        public string Color;
        
        private int _speed;

        public int Speed{
            get { return _speed; }
        }

        public void Accelerate(int accelerateBy)  
        {  
            _speed += accelerateBy;  
        }  
  
        public bool IsMoving()  
        {  
            if (Speed == 0)  
            {  
                return false;  
            }  
            else  
            {  
                return true;  
            }  
        }  
        internal Car()  
        {  
            Color = "White";  
            _speed = 0;  
        }  

        public double calculateMPG(int startMiles, int endMiles, double gallons)  
        {  
            return (endMiles - startMiles) / gallons;  
        }      
    }
}