using System.Collections;

namespace Chapter18;

public static class Exercise09
{
    public class HashedSet<T> : IEnumerable<T>
    {
        private readonly Exercise08.HashTable<T, T> table;

        public HashedSet()
        {
            table = new Exercise08.HashTable<T, T>();
        }

        public int Count => table.Count;

        public void Add(T item)
        {
            if (!table.ContainsKey(item))
            {
                table.Add(item, item);
            }
        }

        public bool Find(T item)
        {
            return table.ContainsKey(item);
        }

        public bool Remove(T item)
        {
            return table.Remove(item);
        }

        public void Clear()
        {
            table.Clear();
        }

        public HashedSet<T> UnionWith(HashedSet<T> other)
        {
            var result = new HashedSet<T>();

            foreach (var item in this)
                result.Add(item);

            foreach (var item in other)
                result.Add(item);

            return result;
        }

        public HashedSet<T> IntersectWith(HashedSet<T> other)
        {
            var result = new HashedSet<T>();

            foreach (var item in this)
            {
                if (other.Find(item))
                    result.Add(item);
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var kv in table)
                yield return kv.Key;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}