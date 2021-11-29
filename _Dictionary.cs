using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachCode
{
    public class _Dictionary<TKey, TValue>
    {



        private struct Entry
        {
            public int hashCode;
            public int next;
            public TKey key;
            public TValue value;
        }
        private int[] buckets;
        private Entry[] entries;
        private int count;
        private int version;
        private int freeList;
        private int freeCount;
        private IEqualityComparer<TKey> _comparer;

        public _Dictionary() : this(0, null) { }

        public _Dictionary(int capacity) : this(capacity, null) { }


        public _Dictionary(int capacity, IEqualityComparer<TKey> comparer)
        {
            if (capacity < 0) throw new Exception();
            if (capacity > 0) Initialize(capacity);
            _comparer = comparer ?? EqualityComparer<TKey>.Default;

        }
        public void Add(TKey key, TValue value)
        {
            Insert(key, value, true);
        }

        private void Insert(TKey key, TValue value, bool add)
        {
            if (key == null)
            {
                throw new Exception();
            }
        }
        private void Initialize(int capacity)
        {
            int size = HashHelper.GetPrime(capacity);
            buckets = new int[size];
            for (int i = 0; i < buckets.Length; i++) buckets[i] = -1;
            entries = new Entry[size];
            freeList = -1;
        }
       

    }
}
