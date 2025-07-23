namespace Chapter18;

public static class Exercise07
{
    public class CuckooHashTable<TKey, TValue>
    {
        private class Entry
        {
            public TKey Key;
            public TValue Value;

            public Entry(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }

        private Entry[] table;
        private int size;
        private const int MaxKickSteps = 500;
        private readonly int capacity;
        private readonly Func<TKey, int>[] hashFunctions;

        public CuckooHashTable(int capacity = 101)
        {
            this.capacity = NextPowerOfTwo(capacity);
            table = new Entry[this.capacity];
            hashFunctions = new Func<TKey, int>[3]
            {
                key => Math.Abs((key.GetHashCode()) % this.capacity),
                key => Math.Abs((key.GetHashCode() * 17 + 31) % this.capacity),
                key => Math.Abs((key.GetHashCode() * 31 + 47) % this.capacity)
            };
        }

        public void Add(TKey key, TValue value)
        {
            if (ContainsKey(key))
            {
                Update(key, value);
                return;
            }

            var newEntry = new Entry(key, value);

            for (int kick = 0; kick < MaxKickSteps; kick++)
            {
                for (int i = 0; i < 3; i++)
                {
                    int pos = hashFunctions[i](newEntry.Key);
                    if (table[pos] == null)
                    {
                        table[pos] = newEntry;
                        size++;
                        return;
                    }
                }
                
                int chosen = new Random().Next(3);
                int kickPos = hashFunctions[chosen](newEntry.Key);
                
                (table[kickPos], newEntry) = (newEntry, table[kickPos]);
            }

            Rehash();
            Add(newEntry.Key, newEntry.Value);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            for (int i = 0; i < 3; i++)
            {
                int pos = hashFunctions[i](key);
                if (table[pos] != null && table[pos].Key.Equals(key))
                {
                    value = table[pos].Value;
                    return true;
                }
            }

            value = default;
            return false;
        }
        
        public bool ContainsKey(TKey key)
        {
            return TryGetValue(key, out _);
        }
        
        public bool Remove(TKey key)
        {
            for (int i = 0; i < 3; i++)
            {
                int pos = hashFunctions[i](key);
                if (table[pos] != null && table[pos].Key.Equals(key))
                {
                    table[pos] = null;
                    size--;
                    return true;
                }
            }
            return false;
        }
        
        private void Update(TKey key, TValue value)
        {
            for (int i = 0; i < 3; i++)
            {
                int pos = hashFunctions[i](key);
                if (table[pos] != null && table[pos].Key.Equals(key))
                {
                    table[pos].Value = value;
                    return;
                }
            }
        }

        private void Rehash()
        {
            var oldEntries = new List<Entry>();
            foreach (var entry in table)
            {
                if (entry != null)
                    oldEntries.Add(entry);
            }

            int newCapacity = this.capacity * 2;
            table = new Entry[newCapacity];

            for (int i = 0; i < 3; i++)
            {
                int salt = 31 + i * 17;
                hashFunctions[i] = key => Math.Abs((key.GetHashCode() * salt + salt) % newCapacity);
            }

            size = 0;
            foreach (var entry in oldEntries)
            {
                Add(entry.Key, entry.Value);
            }
        }

        public int Count => size;

        private int NextPowerOfTwo(int n)
        {
            int power = 1;
            while (power < n) power <<= 1;
            return power;
        }
    }
}