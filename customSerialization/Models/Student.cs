namespace models
{
    public class Student{
        private int id;
        private string name;

        private int grade;

        private int age;

        private string addressDetailstreet;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Grade { get => grade; set => grade = value; }
        public int Age { get => age; set => age = value; }
        public string AddressDetailStreet { get => addressDetailstreet; set => addressDetailstreet = value; }
    }
}