using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryApp
{
    public class MyDictionary<K,V>
    {
        K[] _key;
        V[] _value;
        K[] _tKey;
        V[] _tValue;
        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];
        }
        public void Add(K key, V value)
        {
            _tKey = _key;
            _tValue = _value;

            _key = new K[_key.Length + 1];
            _value = new V[_value.Length + 1];

            for (int i = 0; i < _tKey.Length; i++)
            {
                _key[i] = _tKey[i];
            }
            for (int i = 0; i < _tValue.Length; i++)
            {
                _value[i] = _tValue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }
        public int Count
        {
            get { return _value.Length; }
        }
        public K[] Key
        {
            get { return _key; }
        }

        public V[] Value
        {
            get { return _value; }
        }

    }
}
