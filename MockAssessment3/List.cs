using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    public class List
    {
        private int _count = 0;
        private readonly Car[] _array;

        public List(int maxLength)
        {
            _array = new Car[maxLength];
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

        public bool Insert(Car value)
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

        public Car GetAt(int index)
        {
            return _array[index];
        }

        public bool InsertAt(int index, Car o)
        {
            if (index > _count)
            {
                return false;
            }

            _count++;
            _array[index] = o; 
            return true;
        }
    }
}
