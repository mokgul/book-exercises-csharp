namespace Chapter18;

public static class Exercise06
{
    public class MultiValueDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, List<TValue>> _dict;

        public MultiValueDictionary()
        {
            _dict = new Dictionary<TKey, List<TValue>>();
        }

        public void Add(TKey key, TValue value)
        {
            if (!_dict.TryGetValue(key, out var list))
            {
                list = new List<TValue>();
                _dict[key] = list;
            }

            list.Add(value);
        }
        
        public IReadOnlyList<TValue> GetValues(TKey key)
        {
            if (_dict.TryGetValue(key, out var list))
            {
                return list.AsReadOnly();
            }

            return Array.Empty<TValue>();
        }
        
        public bool Contains(TKey key, TValue value)
        {
            return _dict.TryGetValue(key, out var list) && list.Contains(value);
        }
        
        public bool Remove(TKey key, TValue value)
        {
            if (_dict.TryGetValue(key, out var list))
            {
                bool removed = list.Remove(value);
                if (list.Count == 0)
                    _dict.Remove(key);
                return removed;
            }

            return false;
        }
        
        public bool RemoveAll(TKey key)
        {
            return _dict.Remove(key);
        }

        public IEnumerable<TKey> Keys => _dict.Keys;

        public IEnumerable<TValue> AllValues
        {
            get
            {
                foreach (var list in _dict.Values)
                foreach (var value in list)
                    yield return value;
            }
        }

        public void Clear() => _dict.Clear();

        public int Count => _dict.Count;
    }
}