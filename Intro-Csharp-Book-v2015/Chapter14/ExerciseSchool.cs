namespace Chapter14;

public static class ExerciseSchool
{
    // Ученик
    public class Student
    {
        public string Name { get; set; }
        public int ClassNumber { get; set; }

        public Student(string name, int classNumber)
        {
            Name = name;
            ClassNumber = classNumber;
        }

        public override string ToString()
        {
            return $"{Name} (№{ClassNumber})";
        }
    }

// Дисциплина
    public class Discipline
    {
        public string Name { get; set; }
        public int LessonCount { get; set; }
        public int ExerciseCount { get; set; }

        public Discipline(string name, int lessons, int exercises)
        {
            Name = name;
            LessonCount = lessons;
            ExerciseCount = exercises;
        }

        public override string ToString()
        {
            return $"{Name} - {LessonCount} урока, {ExerciseCount} упражнения";
        }
    }

// Преподавател
    public class Teacher
    {
        public string Name { get; set; }
        public List<Discipline> Disciplines { get; private set; }

        public Teacher(string name)
        {
            Name = name;
            Disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            Disciplines.Add(discipline);
        }

        public override string ToString()
        {
            string disc = string.Join("; ", Disciplines);
            return $"{Name} преподава: {disc}";
        }
    }

// Клас
    public class SchoolClass
    {
        public string Identifier { get; set; } // напр. "10А"
        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }

        public SchoolClass(string identifier)
        {
            Identifier = identifier;
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public override string ToString()
        {
            return $"Клас: {Identifier} - Ученици: {Students.Count}, Преподаватели: {Teachers.Count}";
        }
    }

// Училище
    public class School
    {
        public string Name { get; set; }
        public List<SchoolClass> Classes { get; private set; }

        public School(string name)
        {
            Name = name;
            Classes = new List<SchoolClass>();
        }

        public void AddClass(SchoolClass schoolClass)
        {
            Classes.Add(schoolClass);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Училище: {Name}");
            foreach (var schoolClass in Classes)
            {
                Console.WriteLine(schoolClass);
                Console.WriteLine(" Ученици:");
                foreach (var student in schoolClass.Students)
                    Console.WriteLine($"  - {student}");

                Console.WriteLine(" Преподаватели:");
                foreach (var teacher in schoolClass.Teachers)
                    Console.WriteLine($"  - {teacher}");

                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var school = new School("СУ 'Св. Паисий Хилендарски'");

            var class10A = new SchoolClass("10А");
            class10A.AddStudent(new Student("Иван Петров", 1));
            class10A.AddStudent(new Student("Мария Георгиева", 2));

            var math = new Discipline("Математика", 50, 25);
            var info = new Discipline("Информатика", 40, 30);

            var teacherIvanov = new Teacher("Г-н Иванов");
            teacherIvanov.AddDiscipline(math);
            teacherIvanov.AddDiscipline(info);

            class10A.AddTeacher(teacherIvanov);

            school.AddClass(class10A);

            school.PrintInfo();
        }
    }
}