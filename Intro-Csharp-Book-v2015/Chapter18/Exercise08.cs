using System.Collections;

namespace Chapter18;

public static class Exercise08
{
    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private LinkedList<KeyValuePair<K, T>>[] buckets;
        private int count;
        private const float LoadFactor = 0.75f;

        public HashTable()
        {
            buckets = new LinkedList<KeyValuePair<K, T>>[16];
            count = 0;
        }

        public int Count => count;

        public void Add(K key, T value)
        {
            if (ContainsKey(key))
                throw new ArgumentException("Key already exists");

            if ((float)(count + 1) / buckets.Length > LoadFactor)
                Resize();

            int index = GetIndex(key);

            if (buckets[index] == null)
                buckets[index] = new LinkedList<KeyValuePair<K, T>>();

            buckets[index].AddLast(new KeyValuePair<K, T>(key, value));
            count++;
        }

        public T Find(K key)
        {
            int index = GetIndex(key);

            if (buckets[index] != null)
            {
                foreach (var pair in buckets[index])
                {
                    if (EqualityComparer<K>.Default.Equals(pair.Key, key))
                        return pair.Value;
                }
            }

            throw new KeyNotFoundException($"Key '{key}' not found.");
        }

        public bool Remove(K key)
        {
            int index = GetIndex(key);

            if (buckets[index] != null)
            {
                var node = buckets[index].First;
                while (node != null)
                {
                    if (EqualityComparer<K>.Default.Equals(node.Value.Key, key))
                    {
                        buckets[index].Remove(node);
                        count--;
                        return true;
                    }

                    node = node.Next;
                }
            }

            return false;
        }

        public void Clear()
        {
            buckets = new LinkedList<KeyValuePair<K, T>>[16];
            count = 0;
        }

        public T this[K key]
        {
            get => Find(key);
            set
            {
                int index = GetIndex(key);

                if (buckets[index] == null)
                    buckets[index] = new LinkedList<KeyValuePair<K, T>>();

                var node = buckets[index].First;
                while (node != null)
                {
                    if (EqualityComparer<K>.Default.Equals(node.Value.Key, key))
                    {
                        node.Value = new KeyValuePair<K, T>(key, value);
                        return;
                    }

                    node = node.Next;
                }

                // Key not found, add new
                buckets[index].AddLast(new KeyValuePair<K, T>(key, value));
                count++;

                if ((float)count / buckets.Length > LoadFactor)
                    Resize();
            }
        }

        public IEnumerable<K> Keys
        {
            get
            {
                foreach (var list in buckets)
                {
                    if (list != null)
                    {
                        foreach (var pair in list)
                            yield return pair.Key;
                    }
                }
            }
        }

        public bool ContainsKey(K key)
        {
            int index = GetIndex(key);

            if (buckets[index] != null)
            {
                foreach (var pair in buckets[index])
                {
                    if (EqualityComparer<K>.Default.Equals(pair.Key, key))
                        return true;
                }
            }

            return false;
        }

        private void Resize()
        {
            var oldBuckets = buckets;
            buckets = new LinkedList<KeyValuePair<K, T>>[oldBuckets.Length * 2];
            count = 0;

            foreach (var list in oldBuckets)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                    {
                        Add(pair.Key, pair.Value);
                    }
                }
            }
        }

        private int GetIndex(K key)
        {
            int hash = key == null ? 0 : key.GetHashCode();
            return Math.Abs(hash) % buckets.Length;
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var list in buckets)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                        yield return pair;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}