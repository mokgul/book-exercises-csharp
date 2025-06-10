namespace Chapter02;

public static class Exercise12
{
    public static void GetWorkersTable()
    {
        List<Worker> workers = new()
        {
            new Worker("Dean", "Winchester", 28, "M", 1007153),
            new Worker("Sam", "Winchester", 25, "M", 1007151),
            new Worker("Mary", "Winchester", 45, "F", 1007157),
            new Worker("John", "Winchester", 49, "M", 1007159),
        };

        Console.WriteLine("{0,-10} {1,-12} {2,-5} {3,-6} {4,-8}", "FirstName", "LastName", "Age", "Gender", "ID");
        Console.WriteLine(new string('-', 45));

        foreach (var w in workers)
        {
            Console.WriteLine("{0,-10} {1,-12} {2,-5} {3,-6} {4,-8}",
                w.FirstName, w.LastName, w.Age, w.Gender, w.Id);
        }
    }

    private class Worker
    {
        public Worker(string firstName, string lastName, int age, string sex, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = sex;
            Id = id;
        }
        public string FirstName;
        public string LastName;
        public int Age;
        public string Gender;
        public int Id;
    }
}