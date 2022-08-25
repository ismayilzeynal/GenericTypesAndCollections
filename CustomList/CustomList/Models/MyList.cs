using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList.Models
{
    class MyList<T>
    {
        MyList(int capacity)
        {
            Capacity = capacity;
        }


        
        T[] _arr;
        int _counter;
        public int Capacity { get; set; } = 1;
        public int Count { get => _arr.Length - _counter; }
        public MyList()
        {
            _arr = new T[0];
        }



        public T this[int index]
        {
            get
            {
                if (index < _arr.Length)
                {
                    return _arr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }



        public void Add(T item)
        {
            if(_counter==0)
            {
                Array.Resize(ref _arr, _arr.Length + Capacity);
                _counter = Capacity;
            }

            _arr[Count] = item;
            _counter--;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(_arr[i], item))
                    return i;
            }
             return -1; 
        }

        public void Clear()
        {
            _counter = 0;
            _arr = new T[0];
        }

        public void Remove(T item)
        {
            if (IndexOf(item) == -1)
                return;                                             // ve ya exception vermek olar
            for (int i = IndexOf(item); i < _arr.Length-1; i++)
            {
                _arr[i]=_arr[i+1];
            }
            Array.Resize(ref _arr, _arr.Length - 1);
            _counter--;
        }

        public bool Exist(T item)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(item, _arr[i]))
                    return true;
            }
            
            return false;
        }

        public void Reverse()
        {
            int len = _arr.Length;
            for (int i = 0; i < len; i++)
            {
                T temp = _arr[i];
                _arr[i] = _arr[len - i-1];
                _arr[len - i - 1] = temp;
            }
        }

        public int LastIndexOf(T item)
        {
            for (int i = _arr.Length-1; i >=0 ; i--)
            {
                if (object.Equals(_arr[i], item))
                    return i;
            }
            throw new KeyNotFoundException();
        }

        //public static bool operator ==(T a, T b)
        //{
        //    return Object.Equals(a, b);
        //}

        //public static bool operator !=(T a, T b)
        //{
        //    return !Object.Equals(a, b);
        //}

    }
}
