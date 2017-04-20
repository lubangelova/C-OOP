using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
        where T : IComparable
    {
        private const int currentCount = 0;
        private int capacity;
        private T[] arr;
        private int count;

        public GenericList(int currentCapacity)
        {
            this.Capacity = currentCapacity;
            this.arr = new T[this.Capacity];
            this.Count = currentCount;
        }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value > 0 && value < int.MaxValue)
                {
                    this.capacity = value;
                }
                else
                {
                    throw new ArgumentException("Not a valid capacity");
                }
            }
        }
        public int Count
        {
            get
            {
                return this.count;
            }

            set
            {

                this.count = value;

            }

        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.count)
                {
                    throw new ArgumentOutOfRangeException($"Index must be between 0 and {this.count - 1}.");
                }
                else
                {
                    return this.arr[index];
                }
            }
            set
            {
                if (index < 0 || index >= this.count)
                {
                    throw new ArgumentOutOfRangeException($"Index must be between 0 and {this.count - 1}.");
                }
                else
                {
                    this.arr[index] = value;
                }
            }

        }

        public void Add(T element)
        {
            if (this.Count == this.capacity)
            {
                this.Capacity *= 2;
                var oldArr = this.arr;
                this.arr = new T[this.Capacity];
                Array.Copy(oldArr, this.arr, this.Count);
            }
            this.arr[this.Count] = element;
            this.Count++;
        }

        public int IndexOf(int element)
        {
            int index = -1;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.arr[i].CompareTo(element) == 0)
                {
                    index = i;
                }
            }
            return index;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= this.Count)
            { 
                throw new ArgumentOutOfRangeException($"Index should be between 0 and {this.Count - 1}.");
            }
            else
            {
                var oldArr = this.arr;
                this.Count = 0;
                this.arr = new T[this.Capacity];
                for (int i = 0; i < index; i++)
                {
                    this.Add(oldArr[i]);
                }
                for (int i = index; i <= oldArr.Length - index; i++)
                {
                    this.Add(oldArr[i + 1]);
                }
            }
        }

        public void Insert(int index, T element)
        {
            var oldArr = this.arr;
            this.Count = 0;
            this.arr = new T[this.Capacity];
            for (int i = 0; i < index; i++)
            {
                this.Add(oldArr[i]);
            }
            this.Add(element);
            for (int i = index + 1; i < oldArr.Length - index - 1; i++)
            {
                this.Add(oldArr[i - 1]);
            }
        }

        public void Clear()
        {
            this.Count = currentCount;
            this.arr = new T[this.Capacity];
        }

        public T[] Sort()
        {
            for (int i = 0; i < this.Count; i++)
            {
                for (int j = i + 1; j < this.Count; j++)
                {
                    if (this.arr[j].CompareTo(this.arr[i]) < 0)
                    {
                        var temp = this.arr[j];
                        this.arr[j] = this.arr[i];
                        this.arr[i] = temp;
                    }
                }
            }

            return this.arr;
        }

        public T Min()
        {
            var minElement = default(T);

            if (this.count > 0)
            {
                this.arr = this.Sort();
                minElement = this.arr[0];
            }

            return minElement;
        }

        public T Max()
        {
            var maxElement = default(T);

            if (this.count > 0)
            {
                this.arr = this.Sort();
                maxElement = this.arr[this.Count - 1];
            }

            return maxElement;
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                builder.Append(this.arr[i] + ",");
            }

            return builder.ToString().Trim(new char[] { ',', ' ' });
        }
    }
}
