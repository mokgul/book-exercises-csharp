namespace Chapter20;

public static class Exercise01
{
    public class School
    {
        private readonly List<SchoolClass> classes;

        public School()
        {
            classes = new List<SchoolClass>();
        }
       
        public List<SchoolClass> Classes => classes;
    }

    public class SchoolClass
    {
        private readonly List<Student> _students;
        private readonly List<Teacher> _teachers;
        private string id;
        

        public SchoolClass(string id)
        {
            _students = new List<Student>();
            _teachers = new List<Teacher>();
            this.id = id;
        }
        
        public List<Student> Students => _students;
        public List<Teacher> Teachers => _teachers;
        public string Id => id;
    }

    public class Student : Person
    {
        private int id;

        public Student(string name, int id)  : base(name)
        {
            this.id = id;
        }
        
        public int Id => id;
    }

    public class Teacher : Person
    {
        private readonly List<Subject> _subjects;

        public Teacher(string name) : base(name)
        {
            _subjects = new List<Subject>();
        }
        
        public List<Subject> Curriculas => _subjects;
    }

    public class Subject
    {
        private string name;
        private int hours;
        private int exercises;

        public Subject(string name, int hours, int exercises)
        {
            this.name = name;
            this.hours = hours;
            this.exercises = exercises;
        }
        
        public string Name => name;
        public int Hours => hours;
        public int Exercises => exercises;
    }

    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }
        
        public string Name => name;
    }
}