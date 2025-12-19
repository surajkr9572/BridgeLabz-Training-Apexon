using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Queue
{
    public class CustomQueue<T>
    {
        private T[] Queue;
        private int front;
        private int rear;
        private int count;
        private int capacity;

        public CustomQueue(int size)
        {
            capacity = size;
            Queue=new T[capacity];
            front = 0;
            rear = -1;
            count = 0;
        }
        public void Enqueue(T item)
        {
            if (IsFull())

            {
                throw new InvalidOperationException("Queue is full");
            }
            rear = (rear + 1) % capacity;
            Queue[rear] = item;
            count++;
        }
       public T Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is Empty");
            T item= Queue[front];
            front = (front + 1) % capacity;
            count--;
            return item;
        }
        public T peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is Empty");
            return Queue[front];

        }
        public bool IsFull()
        {
            if(count==capacity) return true;
            return false;
        }
        public bool IsEmpty()
        {
            if(count==0) return true;
            return false;
        }
        public int Count()
        {
            return count;
        }
    }
}
