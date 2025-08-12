namespace Chapter22;

public static class Exercise05
{
    public static void SortStudentList(Student[] students)
    {
        List<Student> sortedList = new List<Student>();
        sortedList = students.OrderBy(s => s.Name).ThenBy(s => s.Surname).ToList();

        foreach (Student student in sortedList)
        {
            Console.WriteLine($"{student.Name} {student.Surname}");
        }
    }
}