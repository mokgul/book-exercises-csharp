namespace Chapter22;

public static class Exercise03
{
    public static void FindStudents(Student[] students)
    {
        List<Student> studentList = new List<Student>();
        studentList = students.Where(s => String.Compare(s.Name, s.Surname, StringComparison.Ordinal) < 0).ToList();
        foreach (var student in studentList)
        {
            Console.WriteLine($"{student.Name} {student.Surname}");
        }
    }
}
