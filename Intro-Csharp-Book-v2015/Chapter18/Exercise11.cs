using System.Collections;

namespace Chapter18;

public static class Exercise11
{
    public class TreeMultiSet<T> : IEnumerable<T>
    {
        private readonly SortedDictionary<T, int> _dict;
        private int _count;

        public TreeMultiSet() : this(null)
        {
        }

        public TreeMultiSet(IComparer<T> comparer)
        {
            _dict = new SortedDictionary<T, int>(comparer);
            _count = 0;
        }
        
        public int Count => _count;
        
        public void Add(T item)
        {
            if (_dict.ContainsKey(item))
                _dict[item]++;
            else
                _dict[item] = 1;

            _count++;
        }
        
        public int CountOf(T item)
        {
            return _dict.TryGetValue(item, out int cnt) ? cnt : 0;
        }
        
        public bool Remove(T item)
        {
            if (_dict.TryGetValue(item, out int cnt))
            {
                if (cnt > 1)
                    _dict[item] = cnt - 1;
                else
                    _dict.Remove(item);

                _count--;
                return true;
            }

            return false;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var kv in _dict)
            {
                for (int i = 0; i < kv.Value; i++)
                    yield return kv.Key;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        public T Min
        {
            get
            {
                if (_dict.Count == 0)
                    throw new InvalidOperationException("Set is empty.");
                using var enumerator = _dict.GetEnumerator();
                enumerator.MoveNext();
                return enumerator.Current.Key;
            }
        }
        
        public T Max
        {
            get
            {
                if (_dict.Count == 0)
                    throw new InvalidOperationException("Set is empty.");
                using var enumerator = _dict.GetEnumerator();
                T last = default;
                while (enumerator.MoveNext())
                    last = enumerator.Current.Key;
                return last;
            }
        }
        
        public bool RemoveMin()
        {
            if (_dict.Count == 0) return false;
            T min = Min;
            return Remove(min);
        }
        
        public bool RemoveMax()
        {
            if (_dict.Count == 0) return false;
            T max = Max;
            return Remove(max);
        }
        
        public bool RemoveAll(T item)
        {
            if (_dict.TryGetValue(item, out int cnt))
            {
                _dict.Remove(item);
                _count -= cnt;
                return true;
            }

            return false;
        }
        
        public bool Contains(T item) => _dict.ContainsKey(item);
        
        public void Clear()
        {
            _dict.Clear();
            _count = 0;
        }
    }
}