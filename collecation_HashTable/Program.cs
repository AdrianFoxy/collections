using System.Collections;

namespace collections_HashTable
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Student))
                return false;

            Student other = (Student)obj;
            return this.Name.Equals(other.Name) && this.Age == other.Age;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable students = new Hashtable();

            students.Add(new Student("John", 20), "Math");
            students.Add(new Student("Alice", 22), "Physics");
            students.Add(new Student("Bob", 21), "Chemistry");

            Student alice = new Student("Alice", 22);
            if (students.ContainsKey(alice))
            {
                Console.WriteLine($"Information for {alice}: {students[alice]}");
            }
            else
            {
                Console.WriteLine($"Student with name {alice.Name} not found.");
            }

            students.Remove(new Student("Bob", 21));

            Console.WriteLine("\nList of students:");
            foreach (DictionaryEntry entry in students)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

        }
    }
}