using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    internal class Asda<TKey,TValue>
    {
        private Contact[] _contacts = { };
        public Contact[] Contacts = { };
        private TKey[] _keys = { };
        public TKey[] Keys => _keys;

        private TValue[] _values = { };
        public TValue[] Values => _values;

        public void AddMember(Contact newContact)
        {
            Array.Resize(ref _contacts, _contacts.Length + 1);
            _contacts[_contacts.Length - 1] = newContact;
            
        }
        public Contact Add(TKey key, TValue value)
        { 
            if (HasKey(key))
                throw new FormatException();

            Array.Resize(ref _keys, _keys.Length + 1);
            _keys[_keys.Length - 1] = key;


            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;

            Contact newContact = new Contact ();
            newContact.Name = key.ToString();
            newContact.No = value.ToString();

            return newContact;
        }

        public bool HasKey(TKey key)
        {
            int i = Array.IndexOf(_keys, key);

            return i != -1;
        }

        public TValue GetValue(TKey key)
        {
            var wantedIndex = Array.IndexOf(_keys, key);

            if (wantedIndex < 0) 
                throw new IndexOutOfRangeException();

            return _values[wantedIndex];
        }


    }
}
