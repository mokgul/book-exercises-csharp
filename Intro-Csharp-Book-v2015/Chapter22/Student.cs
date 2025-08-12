namespace Chapter22;

public class Student
{
    public Student(string firstName, string lastName, int age)
    {
        Name = firstName;
        Surname = lastName;
        Age = age;
    }
    
    public string Name { get; set; }

    public string Surname { get; set; }

    public int Age { get; set; }
}