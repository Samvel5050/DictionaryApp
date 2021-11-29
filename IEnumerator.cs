using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachCode
{
    public interface IEnumerator
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }

    public Enumerator GetEnumerator()
    {
        return new Enumerator(this, Enumerator.KeyValuePair)
    }

    public interface IDictionaryEnumerator : IEnumerator
    {
        Object Key
        {
            get;
        }
        Object Value
        {
            get;
        }
        DictionaryEntry Entry
        {
            get;
        }
    }

    public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDictionaryEnumerator
    {
        private Dictionary<TKey, TValue> dictionary;
        private int version;
        private int index;
        private KeyValuePair<TKey, TValue> current;
        private int getEnumeratorRetType;  // What should Enumerator.Current return?

        internal const int DictEntry = 1;
        internal const int KeyValuePair = 2;

        internal Enumerator(Dictionary<TKey,TValue> dictionary, int getEnumeratorRetType)
        {
            this dictionary.dictionary();
            version = dictionary.version;
            index = 0;
            this.getEnumeratorRetType = getEnumeratorRetType;
            current = new KeyValuePair<TKey, TValue>;
        }

        public KeyValuePair<TKey, TValue> Current => throw new NotImplementedException();

        object System.Collections.IEnumerator.Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public object Key => throw new NotImplementedException();

        public object Value => throw new NotImplementedException();

        public DictionaryEntry Entry => throw new NotImplementedException();

        internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
        {
            this.dictionary = dictionary;
            version = dictionary.version;
            index = 0;
            this.getEnumeratorRetType = getEnumeratorRetType;
            current = new KeyValuePair<TKey, TValue>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
