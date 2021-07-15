using System;

namespace Models
{
    public class Order{
        private int id;
        private string name;

        private string note;

        private DateTime orderedDate;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Note { get => note; set => note = value; }
        public DateTime OrderedDate { get => orderedDate; set => orderedDate = value; }
    }
}