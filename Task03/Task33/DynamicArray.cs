using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task33
{
    public class DynamicArray<T> : IEnumerable, ICloneable
    {
        protected T[] array;
        public T[] Array
        {
            get => array;
            set
            {
                array = value ?? throw new ArgumentNullException();
            }
        }
        public int Length { get; private set; }
        public int Capacity
        {
            get => array.Length;
            private set
            {
                if (value < array.Length)
                    throw new ArgumentOutOfRangeException("Capacity не может быть меньше длинны масива.");
                else
                {
                    T[] tempArray = new T[Capacity];
                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    array = tempArray;
                }
            }
        }

        public DynamicArray()
        {
            array = new T[8];
        }
        public DynamicArray(int capacity)
        {
            array = new T[capacity];
        }
        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException();

            int len = 0;
            foreach (T item in collection)
                len++;
            array = new T[len];

            int i = 0;
            foreach (T item in collection)
                array[i++] = item;
        }

        void Expand(int times = 2)
        {
            if (times < 2)
                throw new ArgumentException("Должно быть 2 или больше.");

            int newCap = Capacity < Length + times ? (Capacity + times) * 2 : Capacity * 2;
            var newArr = new T[newCap];
            for (int i = 0; i < Length; i++)
            {
                newArr[i] = array[i];
            }

            array = newArr;
            Capacity = newCap;
        }

        public void Add(T element)
        {
            if (Length == Capacity)
                Expand();
            array[Length++] = element;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            int collectionCount = 0;
            foreach (T item in collection)
            {
                collectionCount++;
            }
            if (collectionCount > Capacity - array.Length)
            {
                Expand(collectionCount);
            }
            int end = Length;
            foreach (T item in collection)
            {
                array[end++] = item;
            }

            Length += collectionCount;

        }

        public bool Remove(T element)
        {
            for (int i = 0; i < Length; i++)
            {
                if (array[i].Equals(element))
                {
                    for (int j = i; j < Length; j++)
                    {
                        array[j] = array[j + 1];
                    }

                    Length--;
                    return true;
                }
            }
            return false;
        }

        public bool Insert(T element, int index)
        {
            if (index < 0 || index > Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Length == Capacity)
                Expand();

            for (int i = Length + 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }

            array[index] = element;
            Length++;
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public object Clone()
        {
            return new DynamicArray<T> { array = array, Capacity = Capacity };
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Length)
                    return array[index];
                else
                    throw new ArgumentOutOfRangeException("Выход за границу массива");
            }
            set
            {
                if (index >= 0 && index < Length)
                    array[index] = value;
                else
                    throw new ArgumentOutOfRangeException("Выход за границу массива");
            }
        }
    }
}
