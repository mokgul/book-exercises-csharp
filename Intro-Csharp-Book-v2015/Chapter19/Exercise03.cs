namespace Chapter19;

public static class Exercise03
{
    public static void ExtractStudents()
    {
        string filePath = "students.txt";
        var specialties = new SortedDictionary<string, List<string>>();

        foreach (var line in File.ReadLines(filePath))
        {
            var parts = line.Split('|');
            if (parts.Length != 2) continue;

            string student = parts[0].Trim();
            string specialty = parts[1].Trim();

            if (!specialties.ContainsKey(specialty))
            {
                specialties[specialty] = new List<string>();
            }

            specialties[specialty].Add(student);
        }

        foreach (var entry in specialties)
        {
            var sortedStudents = entry.Value
                .OrderBy(s => s.Split(' ').Last()) // фамилия
                .ThenBy(s => s.Split(' ').First()) // име
                .ToList();

            Console.WriteLine($"{entry.Key}: {string.Join(", ", sortedStudents)}");
        }
    }
}