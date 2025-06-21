namespace Chapter09;

public static class Exercise13
{
    public static void MultiplyPolynomials(int[] poly1, int[] poly2)
    {
        int[] result = new int[poly1.Length + poly2.Length - 1];

        for (int i = 0; i < poly1.Length; i++)
        {
            for (int j = 0; j < poly2.Length; j++)
            {
                result[i + j] += poly1[i] * poly2[j];
            }
        }

       PrintPolynomial(result);
    }

    public static void PrintPolynomial(int[] poly)
    {
        for (int i = poly.Length - 1; i >= 0; i--)
        {
            int coeff = poly[i];
            if (coeff == 0) continue;

            string sign = coeff > 0 && i != poly.Length - 1 ? " + " : coeff < 0 ? " - " : "";
            coeff = Math.Abs(coeff);

            string term = i == 0 ? $"{coeff}" :
                i == 1 ? $"{coeff}x" :
                $"{coeff}x^{i}";

            Console.Write(sign + term);
        }
        Console.WriteLine();
    }

}