namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Reflection;

    /*
     5. Generic class

        Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
        Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
        Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
        Check all input parameters to avoid accessing elements at invalid positions.

    */

    /*
     6. Auto-grow

        Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

    */

    public class GenericList<T> where T : IComparable
    {
        private T[] arr;
        private int capacity;
        private int Index;
        private readonly int firstCapacity;

        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            arr = new T[Capacity];
            Index = 0;
            firstCapacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }

        public void Add(T element)
        {
            try
            {
                if(Index >= Capacity)
                {
                    Capacity *= 2;
                    T[] newArr = new T[Capacity];
                    for(int i = 0; i < Index; i++)
                    {
                        newArr[i] = arr[i];
                    }
                    arr = newArr;
                }
                arr[Index] = element;
                Index++;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The list is full!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Value {0} is invalid!", element);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops, something went wrong!");
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > Index)
                    throw new IndexOutOfRangeException("Index out of range!");
                return this.arr[index];
            }
            set
            {
                if (index < 0 || index > Index)
                    throw new IndexOutOfRangeException("Index out of range!");
                this.arr[index] = value;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > Index)
                throw new IndexOutOfRangeException("Index out of range!");
            if (Index == 0)
                throw new IndexOutOfRangeException("The list is empty!");
            T[] newArr = new T[Capacity];
            int minusIndex = 0;
            for(int i = 0; i < Capacity; i++)
            {
                if (i == index)
                {
                    minusIndex = 1;
                    continue;
                }
                newArr[i - minusIndex] = arr[i];
            }
            arr = newArr;
            Index--;
        }

        public void InsertAt(int position, T element)
        {
            if (position < 0 || position > Index)
                throw new IndexOutOfRangeException("Position out of range!");
            try
            {
                if(Index >= Capacity)
                {
                    Capacity *= 2;
                    T[] newArr2 = new T[Capacity];
                    for(int i = 0; i < Index; i++)
                    {
                        newArr2[i] = arr[i];
                    }
                    arr = newArr2;
                }
                T[] newArr = new T[Capacity]; 
                int minusIndex = 0;
                for (int i = 0; i <= Index; i++)
                {
                    if (i == position)
                    {
                        minusIndex = 1;
                        newArr[i] = element;
                        continue;
                    }
                    newArr[i] = arr[i - minusIndex];
                }
                arr = newArr;
                Index++;
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Not valid argument!");
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Index is out of borders!");
            }
            catch(Exception)
            {
                Console.WriteLine("Oops. Something is wrong!");
            }

        }

        public void Clear()
        {
            arr = new T[firstCapacity];
            Index = 0;
        }

        public int FindElement(T element)
        {
            for(int i = 0; i < Index; i++)
            {
                if(element.Equals(arr[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        /*
         7. Min and Max

            Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
            You may need to add a generic constraints for the type T.

        */

        public T Min() 
        {
            T min = this.arr[0];
            for(int i = 0; i < Index; i++)
            {
                if(min.CompareTo(arr[i]) >= 0)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.arr[0];
            for (int i = 0; i < Index; i++)
            {
                if (max.CompareTo(arr[i]) <= 0)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        
        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();
            for (int i = 0; i < Index; i++)
            {
                strB.Append(arr[i]);
                if(i < Index -1)
                {
                    strB.Append(", ");
                }
            }
            return strB.ToString();
        }
    }
}
