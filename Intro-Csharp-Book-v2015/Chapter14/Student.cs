using System.Text;

namespace Chapter14;

public class Student
{
    private string _fullName;

    private int _degree;

    private Specialty _specialty;

    private University _university;

    private string _email;

    private string _number;
    
    private static int _objectsCount = 0;

    public Student(string fullName)
    {
        _fullName = fullName;
        _objectsCount++;
    }

    public Student(string fullName, Specialty specialty) : this(fullName)
    {
        _specialty = specialty;
    }

    public Student(string fullName, University university) : this(fullName)
    {
        _university = university;
    }
    
    public int GetObjectsCount() => _objectsCount;

    public string FullName
    {
        get => _fullName;
        set => _fullName = value;
    }

    public int Degree
    {
        get => _degree;
        set => _degree = value;
    }

    public Specialty Specialty
    {
        get => _specialty;
        set => _specialty = value;
    }

    public University University
    {
        get => _university;
        set => _university = value;
    }

    public string Email
    {
        get => _email;
        set => _email = value;
    }

    public string Number
    {
        get => _number;
        set => _number = value;
    }

    public void PrintStudentInformation()
    {
        StringBuilder info = new StringBuilder();
        info.AppendLine($"Full Name: {_fullName}");
        info.AppendLine($"Degree: {_degree}");
        info.AppendLine($"Specialty: {_specialty}");
        info.AppendLine($"University: {_university}");
        info.AppendLine($"Email: {_email}");
        info.AppendLine($"Number: {_number}");
        Console.WriteLine(info.ToString());
    }
}