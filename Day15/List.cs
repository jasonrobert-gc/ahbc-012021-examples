using System;
using System.Collections.Generic;
using System.Text;

namespace Day15
{
    public class List
    {
        private int _count = 0;
        private readonly string[] _array;

        public List(int maxLength)
        {
            _array = new string[maxLength];
        }

        public int Count()
        {
            return _count;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _array.Length;
        }

        public bool Insert(string value)
        {
            if (IsFull())
            {
                return false;
            }

            _array[_count] = value;
            _count++;
            return true;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _count; i++)
            {
                _array[i] = _array[i + 1];
            }

            _count--;
        }
    }
}
