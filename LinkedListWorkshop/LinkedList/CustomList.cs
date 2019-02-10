using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class CustomList
    {
        private const int InitialCapacity = 2;

        private int[] items;

        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= this.Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index >= this.Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                items[index] = value;

            }
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            if (index >= this.Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            int returnValue = this.items[index];

            this.items[index] = default(int);
           
            this.Shift(index);
            this.Count--;
            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return returnValue;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count + 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {

                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public void Insert(int index, int element)
        {
            if (index <0 || index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            ShiftToRight(index);

            this.items[index] = element;
            this.Count++;
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
            this.items[index] = default(int);
        }

        public bool Contains(int element)
        {
            var returnValue = false;
            for (int i = 0; i < Count; i++)
            {
                if (this.items[i] == element)
                {
                    returnValue = true;
                    break;

                }
            }

            return returnValue;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex <0 || firstIndex >= this.Count || secondIndex < 0 || secondIndex >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            var firstNum = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = firstNum;
        }

    }
}
