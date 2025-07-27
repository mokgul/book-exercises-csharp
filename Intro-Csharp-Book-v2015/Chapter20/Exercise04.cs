namespace Chapter20;

public static class Exercise04
{
    public static void CompareWorkers()
    {
        Worker[] workers = new Worker[]
        {
            new Worker("Anna", 5120.50),
            new Worker("Ivan", 4340.20),
            new Worker("Maria", 6610.00),
            new Worker("Petar", 3630.80),
            new Worker("Elena", 5120.00),
            new Worker("Nikolay", 4360.70),
            new Worker("Georgi", 5310.80),
            new Worker("Tanya", 3110.50),
            new Worker("Rosen", 4870.30),
            new Worker("Viktor", 5940.20)
        };
        
        Array.Sort(workers);
        
        Console.WriteLine("Sorted workers by salary (ascending):");
        foreach (Worker worker in workers)
        {
            Console.WriteLine(worker.ToString());
        }
    }

    public class Worker : IComparable<Worker>
    {
        public string Name { get; set; }
        
        public double Salary { get; set; }

        public Worker(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public int CompareTo(Worker? other)
        {
           if (other == null) return 1;
           return Salary.CompareTo(other.Salary);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}";
        }
    }
}