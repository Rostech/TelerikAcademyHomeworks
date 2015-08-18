

namespace _64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray : IEnumerable<int>, IComparable
    {
        private ulong number;

        public BitArray(ulong num)
        {
            this.Number = num;
        }

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int this[int position]
        {
            get
            {
                if (position < 0 || position >= 64)
                {
                    throw new IndexOutOfRangeException("Postition must be between 0 and 64");
                }

                return ((int)(this.Number >> position) & 1);
            }
            set
            {
                if (position < 0 || position >= 64)
                {
                    throw new IndexOutOfRangeException("Postition must be between 0 and 64");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("The value must be 0 or 1");
                }

                if (((int)(this.Number >> position) & 1) != value)
                {
                    this.Number ^= (1ul << position);
                }
            }
        }
        public static bool operator ==(BitArray ba1, BitArray ba2)
        {
            return (ba1.Equals(ba2));
        }

        public static bool operator !=(BitArray ba1, BitArray ba2)
        {
            return !(ba1.Equals(ba2));
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray).Number);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            return this.Number.CompareTo((obj as BitArray).Number);
        }
    }
}

