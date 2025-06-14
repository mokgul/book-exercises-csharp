namespace Chapter05;

public static class Exercise09
{
    public static void PrintSubsetsEqualToZero(int[] nums)
    {
        bool found = false;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == 0)
                {
                    Console.WriteLine($"Pair: {{ {nums[i]}, {nums[j]} }}");
                    found = true;
                }

                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        Console.WriteLine($"Triplet: {{ {nums[i]}, {nums[j]}, {nums[k]} }}");
                        found = true;
                    }

                    for (int l = k + 1; l < nums.Length; l++)
                    {
                        if (nums[i] + nums[j] + nums[k] + nums[l] == 0)
                        {
                            Console.WriteLine($"Quadruple: {{ {nums[i]}, {nums[j]}, {nums[k]}, {nums[l]} }}");
                            found = true;
                        }

                        for (int m = l + 1; m < nums.Length; m++)
                        {
                            if (nums[i] + nums[j] + nums[k] + nums[l] + nums[m] == 0)
                            {
                                Console.WriteLine($"Full set: {{ {nums[i]}, {nums[j]}, {nums[k]}, {nums[l]}, {nums[m]} }}");
                                found = true;
                            }
                        }
                    }
                }
            }
        }

        if (!found)
            Console.WriteLine("No subsets found with sum 0.");
    }
}