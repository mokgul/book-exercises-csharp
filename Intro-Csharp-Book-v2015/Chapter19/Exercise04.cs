namespace Chapter19;

public static class Exercise04
{
    public class BiDictionary<K1, K2, T>
    {
        private readonly Dictionary<K1, List<T>> byKey1 = new();
        private readonly Dictionary<K2, List<T>> byKey2 = new();
        private readonly Dictionary<(K1, K2), List<T>> byBothKeys = new();

        public void Add(K1 key1, K2 key2, T value)
        {
            if (!byKey1.ContainsKey(key1))
                byKey1[key1] = new List<T>();
            byKey1[key1].Add(value);

            if (!byKey2.ContainsKey(key2))
                byKey2[key2] = new List<T>();
            byKey2[key2].Add(value);

            var keyPair = (key1, key2);
            if (!byBothKeys.ContainsKey(keyPair))
                byBothKeys[keyPair] = new List<T>();
            byBothKeys[keyPair].Add(value);
        }

        public IEnumerable<T> FindByKey1(K1 key1)
        {
            return byKey1.TryGetValue(key1, out var values) ? values : Enumerable.Empty<T>();
        }

        public IEnumerable<T> FindByKey2(K2 key2)
        {
            return byKey2.TryGetValue(key2, out var values) ? values : Enumerable.Empty<T>();
        }

        public IEnumerable<T> FindByBothKeys(K1 key1, K2 key2)
        {
            var keyPair = (key1, key2);
            return byBothKeys.TryGetValue(keyPair, out var values) ? values : Enumerable.Empty<T>();
        }

        public bool Remove(K1 key1, K2 key2, T value)
        {
            bool removed = false;
        
            if (byKey1.TryGetValue(key1, out var list1))
                removed |= list1.Remove(value);
            if (byKey2.TryGetValue(key2, out var list2))
                removed |= list2.Remove(value);
            if (byBothKeys.TryGetValue((key1, key2), out var listBoth))
                removed |= listBoth.Remove(value);

            return removed;
        }
    }
}