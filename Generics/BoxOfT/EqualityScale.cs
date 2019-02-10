using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T First { get; }
        private T Second { get; }
        public  EqualityScale(T first, T second)
        {
            this.First = first;
            this.Second = second;
        }
        public bool AreEqual()
        {
            if (this.First.Equals(this.Second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
