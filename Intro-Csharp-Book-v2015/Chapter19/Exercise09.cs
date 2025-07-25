namespace Chapter19;

public static class Exercise09
{
    public static void GetCarAds()
    {
        var index = new CarAdIndex();

        index.Add(new CarAd(1, "BMW", "X5", "Black", 2015, 20000m));
        index.Add(new CarAd(2, "BMW", "X3", "White", 2013, 15000m));
        index.Add(new CarAd(3, "Audi", "A4", "Black", 2016, 22000m));
        index.Add(new CarAd(4, "Toyota", "Corolla", "Red", 2012, 9000m));
        index.Add(new CarAd(5, "BMW", "X5", "Black", 2014, 18000m));
        
        var results = index.Search(brand: "BMW", yearMin: 2013, yearMax: 2015, priceMin: 15000m, priceMax: 21000m);

        foreach (var ad in results)
        {
            Console.WriteLine($"{ad.Brand} {ad.Model} {ad.Color} {ad.Year} {ad.Price}");
        }

    }
    
    class CarAd
    {
        public int Id;
        public string Brand;
        public string Model;
        public string Color;
        public int Year;
        public decimal Price;

        public CarAd(int id, string brand, string model, string color, int year, decimal price)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Color = color;
            Year = year;
            Price = price;
        }
    }

    class CarAdIndex
    {
        private List<CarAd> ads = new List<CarAd>();

        private Dictionary<string, HashSet<int>> brandIndex =
            new Dictionary<string, HashSet<int>>(StringComparer.OrdinalIgnoreCase);

        private Dictionary<string, HashSet<int>> modelIndex =
            new Dictionary<string, HashSet<int>>(StringComparer.OrdinalIgnoreCase);

        private Dictionary<string, HashSet<int>> colorIndex =
            new Dictionary<string, HashSet<int>>(StringComparer.OrdinalIgnoreCase);

        private SortedDictionary<int, HashSet<int>> yearIndex = new SortedDictionary<int, HashSet<int>>();
        private SortedDictionary<decimal, HashSet<int>> priceIndex = new SortedDictionary<decimal, HashSet<int>>();

        public void Add(CarAd ad)
        {
            ads.Add(ad);

            AddToIndex(brandIndex, ad.Brand, ad.Id);
            AddToIndex(modelIndex, ad.Model, ad.Id);
            AddToIndex(colorIndex, ad.Color, ad.Id);

            AddToIndex(yearIndex, ad.Year, ad.Id);
            AddToIndex(priceIndex, ad.Price, ad.Id);
        }

        private void AddToIndex<TKey>(IDictionary<TKey, HashSet<int>> index, TKey key, int id)
        {
            if (!index.TryGetValue(key, out var set))
            {
                set = new HashSet<int>();
                index[key] = set;
            }

            set.Add(id);
        }

        public List<CarAd> Search(
            string brand = null,
            string model = null,
            string color = null,
            int? yearMin = null,
            int? yearMax = null,
            decimal? priceMin = null,
            decimal? priceMax = null)
        {
            List<HashSet<int>> setsToIntersect = new List<HashSet<int>>();

            if (!string.IsNullOrEmpty(brand) && brandIndex.TryGetValue(brand, out var brandSet))
                setsToIntersect.Add(brandSet);

            if (!string.IsNullOrEmpty(model) && modelIndex.TryGetValue(model, out var modelSet))
                setsToIntersect.Add(modelSet);

            if (!string.IsNullOrEmpty(color) && colorIndex.TryGetValue(color, out var colorSet))
                setsToIntersect.Add(colorSet);

            if (yearMin.HasValue || yearMax.HasValue)
            {
                int from = yearMin ?? int.MinValue;
                int to = yearMax ?? int.MaxValue;
                var yearSet = GetRangeFromSortedIndex(yearIndex, from, to);
                setsToIntersect.Add(yearSet);
            }

            if (priceMin.HasValue || priceMax.HasValue)
            {
                decimal from = priceMin ?? decimal.MinValue;
                decimal to = priceMax ?? decimal.MaxValue;
                var priceSet = GetRangeFromSortedIndex(priceIndex, from, to);
                setsToIntersect.Add(priceSet);
            }

            // Ако няма филтри, връщаме всички
            if (setsToIntersect.Count == 0)
                return new List<CarAd>(ads);

            // Пресичаме множествата
            HashSet<int> resultSet = new HashSet<int>(setsToIntersect[0]);
            for (int i = 1; i < setsToIntersect.Count; i++)
            {
                resultSet.IntersectWith(setsToIntersect[i]);
                if (resultSet.Count == 0)
                    break;
            }

            // Връщаме пълните обяви
            return ads.Where(ad => resultSet.Contains(ad.Id)).ToList();
        }

        private HashSet<int> GetRangeFromSortedIndex<TKey>(SortedDictionary<TKey, HashSet<int>> index, TKey from,
            TKey to) where TKey : IComparable<TKey>
        {
            var result = new HashSet<int>();

            foreach (var kvp in index)
            {
                if (kvp.Key.CompareTo(from) >= 0 && kvp.Key.CompareTo(to) <= 0)
                {
                    foreach (var id in kvp.Value)
                        result.Add(id);
                }
                else if (kvp.Key.CompareTo(to) > 0)
                {
                    break;
                }
            }

            return result;
        }
    }
}