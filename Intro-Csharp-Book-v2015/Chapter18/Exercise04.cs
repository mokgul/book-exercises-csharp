using System.Collections;

namespace Chapter18;

public static class Exercise04
{
    public class DictHashSet<T> : ICollection<T>
    {
        private readonly Dictionary<T, object> _dict;
        private static readonly object _placeholder = new object();

        public DictHashSet()
        {
            _dict = new Dictionary<T, object>();
        }

        public DictHashSet(IEqualityComparer<T> comparer)
        {
            _dict = new Dictionary<T, object>(comparer);
        }
        
        public int Count => _dict.Count;
        
        public bool IsReadOnly => false;

        public bool Add(T item)
        {
            if (_dict.ContainsKey(item))
                return false;
            
            _dict[item] = _placeholder;
            return true;
        }
        
        void ICollection<T>.Add(T item) => Add(item);
        
        public bool Remove(T item) => _dict.Remove(item);
        
        public bool Contains(T item) => _dict.ContainsKey(item);
        
        public void Clear() => _dict.Clear();
        
        public void CopyTo(T[] array, int arrayIndex) => _dict.Keys.CopyTo(array, arrayIndex);
        
        public IEnumerator<T> GetEnumerator() => _dict.Keys.GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator() => _dict.Keys.GetEnumerator();
    }
}