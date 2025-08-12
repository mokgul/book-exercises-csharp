namespace Chapter22;

public static class Exercise04
{
    public static void FindStudentsInAgeRange(Student[] students)
    {
        Dictionary<string, string> studentsList = new Dictionary<string, string>();
        studentsList = students.Where(student => student.Age >= 18 && student.Age <= 24).ToDictionary(s => s.Name, s => s.Surname);

        foreach (KeyValuePair<string, string> student in studentsList)
        {
            Console.WriteLine($"{student.Key} {student.Value}");
        }
    }
}