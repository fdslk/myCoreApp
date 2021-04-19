using System.Collections.Generic;

namespace mylib1
{
    public class Class1
    {
        private int id;
        private string name;
        private int age;

        public Class1(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        private IEnumerable<string> seq = new string[] {"111"};

        public int getId() {
            return this.id;
        }

        public void setId(int id) {
            this.id = id;
        }

        public string getName() {
            return this.name;
        }

        public void setName(string name) {
            this.name = name;
        }

        public int getAge() {
            return this.age;
        }

        public void setAge(int age) {
            this.age = age;
        }
    }
}
