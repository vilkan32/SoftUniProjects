using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class Box<T> 
    {
        public  List<T> element;
        
        public Box()
        {
            this.element = new List<T>();
        }

        public void Add(T element)
        {
            this.element.Add(element);
        }

        public int CompareTo(T element) 
        {
            int result = 0;
            foreach (var item in this.element)
            {
                if (Comparer<T>.Default.Compare(item, element) > 0)
                {
                    result++;
                }
            }

            return result;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var firstElement = this.element[firstIndex];
            this.element[firstIndex] = this.element[secondIndex];
            this.element[secondIndex] = firstElement;
        }

    }
}
