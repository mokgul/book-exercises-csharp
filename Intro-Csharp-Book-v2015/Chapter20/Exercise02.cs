namespace Chapter20;

public static class Exercise02
{
    public class Human
    {
        private string name;
        private string lastName;

        public Human(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        
        public string Name => name;
        public string LastName => lastName;
    }

    public class Student : Human
    {
        private double _grade;
        
        public Student(string name, string lastName) : base(name, lastName) { }
        
        public double Grade => _grade;
    }

    public class Worker : Human
    {
        private double _salary;
        private double _hoursWorked;
        
        public Worker(string name, string lastName) : base(name, lastName) { }
        
        public double Salary => _salary;
        public double HoursWorked => _hoursWorked;

        public double RatePerHour => _salary / _hoursWorked;
    }
}