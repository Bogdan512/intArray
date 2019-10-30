using System;
using System.Collections;
using System.Collections.Generic;

namespace IntArrays
{
#pragma warning disable CA1710 // Identifiers should have correct suffix
    public class List<T> : IList<T>
#pragma warning restore CA1710 // Identifiers should have correct suffix
    {
        T[] array;

        public List()
        {
            Count = 0;
            const int initialLength = 4;
            array = new T[initialLength];
        }

        public int Count { get; private set; }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public virtual T this[int index]
        {
            get => this.array[index];
            set => this.array[index] = value;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            }
        }

        public virtual void Add(T item)
        {
            EnsureCapacity();
            this.array[Count] = item;
            Count++;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) >= 0;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public virtual void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentException("Invalid index");
            }

            Array.Resize(ref this.array, this.array.Length + 1);
            ShiftRight(index);
            array[index] = item;
        }

        public void Clear()
        {
            Array.Resize(ref this.array, 0);
            Count = 0;
        }

        public bool Remove(T item)
        {
            int indexOfElement = IndexOf(item);
            if (indexOfElement < 0)
            {
                return false;
            }

            RemoveAt(indexOfElement);
            return true;
        }

        public void RemoveAt(int index)
        {
            try
            {
                ShiftLeft(index);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Array.Resize(ref this.array, this.array.Length - 1);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            try
            {
                for (int i = 0; i < Count; i++)
                {
                    array.SetValue(this.array[i], arrayIndex++);
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Afis()
        {
            foreach (T i in array)
            {
                Console.Write(i);
            }
        }

        void EnsureCapacity()
        {
            if (Count != array.Length)
            {
                return;
            }

            const int doubleInSize = 2;
            Array.Resize(ref this.array, this.array.Length * doubleInSize);
        }

        void ShiftRight(object index)
        {
            for (int i = Count; i > (int)index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
        }

        void ShiftLeft(object index)
        {
            for (int i = (int)index; i < Count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }
    }
}
