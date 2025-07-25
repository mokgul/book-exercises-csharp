namespace Chapter19;

public static class Exercise05
{
    public static void GetStudents()
    {
        SortedDictionary<decimal, List<Product>> productsByPrice = new();

        foreach (var pair in productsByPrice)
        {
            if (pair.Key >= 5 && pair.Key <= 10)
            {
                foreach (var product in pair.Value)
                    Console.WriteLine(product.Name);
            }
        }
    }
    
    public class Product
    {
        public string Barcode { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}