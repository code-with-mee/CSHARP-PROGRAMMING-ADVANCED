using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_GenericCustomDictionary
{
    public class MyDictionary<TKey,TValue> : IEnumerable<KeyValuePair<TKey,TValue>>
    {
        private int index = 0;
        private KeyValuePair<TKey, TValue>[] values;

        public MyDictionary()
        {
            values = new KeyValuePair<TKey, TValue>[0];
        }

        public TValue this[TKey key]
        {
            get
            {
                foreach (var pair in values)
                {
                    if (pair.Key.Equals(key))
                        return pair.Value;
                }
                return default(TValue);
            }
        }

        public void Add(TKey key, TValue value)
        {
            Array.Resize(ref values, index+1);
            values[index++] = new KeyValuePair<TKey, TValue>(key, value);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach(KeyValuePair<TKey, TValue> pair in values)  
                yield return new KeyValuePair<TKey, TValue>(pair.Key, pair.Value);
        }

        public int Size()
        {
            return values.Length;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
