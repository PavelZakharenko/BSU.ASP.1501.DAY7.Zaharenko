using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public class CustomQueue<T>
    {
        private T[] array;
        private int capacity;
        private const int defaultCapacity = 15;
        private int size;
        private int head;
        private int tail;
        public int Count
        {
            get { return size; }
        }
        public CustomQueue()
        {
            array = new T[defaultCapacity];
            size = 0;
            head = -1;
            tail = 0;
            capacity = defaultCapacity;
        }

        public void Enqueue(T elem)
        {
            if (this.size == this.capacity)
            {
                T[] newQueue = new T[2 * capacity];
                Array.Copy(array, 0, newQueue, 0, array.Length);
                array = newQueue;
                capacity *= 2;
            }
            size++;
            array[tail++ % capacity] = elem;
        }
        public T Dequeue()
        {
            if (this.size == 0)
            {
                throw new InvalidOperationException();
            }
            size--;
            return array[++head % capacity];
        }

        public CustomIterator GetEnumerator()//!!!
        {
            return new CustomIterator(array,head,size);
        }
        public T Peek()
        {
            if (this.size == 0)
            {
                throw new InvalidOperationException();
            }
            return array[head + 1 % capacity];
        }

        public struct CustomIterator
        {
            private readonly T[] collection;
            private int currentIndex;
            private int capacity;
            public CustomIterator(T[] collection,int head,int capacity)
            {
                this.currentIndex = head;
                this.collection = collection;
                this.capacity = capacity;
            }

            public T Current
            {
                get
                {
                    if (currentIndex == -1 || currentIndex == capacity) 
                    {
                        throw new InvalidOperationException();
                    }
                    return collection[currentIndex];
                }
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public bool MoveNext()
            {
                return ++currentIndex < capacity;
            }
        }
    }

}
