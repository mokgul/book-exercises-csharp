namespace Chapter18;

public static class Exercise10
{
    public static void IntersectsAndUnions()
    {
        var f1 = GenerateF1(100000);
        var f2 = GenerateF2(100000);
        var f3 = GenerateF3(100000);
        
        var f1xf2 = f1.IntersectWith(f2);
        var f1xf3 = f1.IntersectWith(f3);
        var f2xf3 = f2.IntersectWith(f3);
        var allIntersect = f1xf2.IntersectWith(f3);
        
        var f1uf2 = f1.UnionWith(f2);
        var f1uf3 = f1.UnionWith(f3);
        var f2uf3 = f2.UnionWith(f3);
        var allUnion = f1uf2.UnionWith(f3);
        
        Console.WriteLine("f1 * f2 = " + string.Join(", ", f1xf2));
        Console.WriteLine("f1 * f3 = " + string.Join(", ", f1xf3));
        Console.WriteLine("f2 * f3 = " + string.Join(", ", f2xf3));
        Console.WriteLine("f1 * f2 * f3 = " + string.Join(", ", allIntersect));
        Console.WriteLine("f1 + f2 = " + string.Join(", ", f1uf2));
        Console.WriteLine("f1 + f3 = " + string.Join(", ", f1uf3));
        Console.WriteLine("f2 + f3 = " + string.Join(", ", f2uf3));
        Console.WriteLine("f1 + f2 + f3 = " + string.Join(", ", allUnion));
    }
    
    static Exercise09.HashedSet<int> GenerateF1(int max)
    {
        var set = new Exercise09.HashedSet<int>();
        int value = 1;
        while (value <= max)
        {
            set.Add(value);
            value = 2 * value + 3;
        }
        return set;
    }
    
    static Exercise09.HashedSet<int> GenerateF2(int max)
    {
        var set = new Exercise09.HashedSet<int>();
        int value = 2;
        while (value <= max)
        {
            set.Add(value);
            value = 3 * value + 1;
        }
        return set;
    }
    
    static Exercise09.HashedSet<int> GenerateF3(int max)
    {
        var set = new Exercise09.HashedSet<int>();
        int value = 2;
        while (value <= max)
        {
            set.Add(value);
            value = 2 * value - 1;
        }
        return set;
    }
}