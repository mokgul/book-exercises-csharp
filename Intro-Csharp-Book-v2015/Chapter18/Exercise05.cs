namespace Chapter18;

public static class Exercise05
{
    public class DoubleKeyDictionary<TKey1, TKey2, TValue>
    {
        private readonly Dictionary<TKey1, Dictionary<TKey2, TValue>> _dict;

        public DoubleKeyDictionary()
        {
            _dict = new Dictionary<TKey1, Dictionary<TKey2, TValue>>();
        }

        public void Add(TKey1 key1, TKey2 key2, TValue value)
        {
            if (!_dict.TryGetValue(key1, out var innerDict))
            {
                innerDict = new Dictionary<TKey2, TValue>();
                _dict[key1] = innerDict;
            }

            if (innerDict.ContainsKey(key2))
                throw new ArgumentException($"Duplicate key pair: ({key1}, {key2})");

            innerDict[key2] = value;
        }

        public bool TryGetValue(TKey1 key1, TKey2 key2, out TValue value)
        {
            value = default;
            if (_dict.TryGetValue(key1, out var innerDict))
            {
                return innerDict.TryGetValue(key2, out value);
            }

            return false;
        }

        public bool ContainsKeys(TKey1 key1, TKey2 key2)
        {
            return _dict.TryGetValue(key1, out var innerDict) && innerDict.ContainsKey(key2);
        }

        public bool Remove(TKey1 key1, TKey2 key2)
        {
            if (_dict.TryGetValue(key1, out var innerDict))
            {
                bool removed = innerDict.Remove(key2);
                if (innerDict.Count == 0)
                    _dict.Remove(key1);
                return removed;
            }

            return false;
        }

        public TValue this[TKey1 key1, TKey2 key2]
        {
            get
            {
                if (!_dict.TryGetValue(key1, out var innerDict) || !innerDict.TryGetValue(key2, out var value))
                    throw new KeyNotFoundException($"Key pair ({key1}, {key2}) not found.");
                return value;
            }
            set
            {
                if (!_dict.TryGetValue(key1, out var innerDict))
                {
                    innerDict = new Dictionary<TKey2, TValue>();
                    _dict[key1] = innerDict;
                }

                innerDict[key2] = value;
            }
        }

        public IEnumerable<(TKey1, TKey2, TValue)> GetAllEntries()
        {
            foreach (var outer in _dict)
            {
                foreach (var inner in outer.Value)
                {
                    yield return (outer.Key, inner.Key, inner.Value);
                }
            }
        }
    }
}