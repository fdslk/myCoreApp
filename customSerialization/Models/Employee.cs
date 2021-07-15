namespace Model
{
    public class Employee{
        public string Name {get; set;}
        public Employee Manager {get; set;}
    }
}