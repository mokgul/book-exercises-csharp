namespace Chapter20;

public static class Exercise03
{
    public static void CompareStudents()
    {
        Student[] students = new Student[]
        {
            new Student("Anna", 5.50),
            new Student("Ivan", 4.20),
            new Student("Maria", 6.00),
            new Student("Petar", 3.80),
            new Student("Elena", 5.00),
            new Student("Nikolay", 4.70),
            new Student("Georgi", 5.80),
            new Student("Tanya", 3.50),
            new Student("Rosen", 4.30),
            new Student("Viktor", 5.20)
        };

        Array.Sort(students);

        Console.WriteLine("Sorted students by grade (ascending):");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }
        
        public int CompareTo(Student? other)
        {
            if (other == null) return 1;
            return Grade.CompareTo(other.Grade); // ascending order
        }

        public override string ToString()
        {
            return $"{Name} - {Grade:F2}";
        }
    }
}