using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Stack
{
    public class CustomStack<T>
    {
        private T[] stack;
        private int capacity;
        private int top;
        public CustomStack(int size)
        {
            capacity = size;
            stack = new T[capacity];
            top = -1;
        }
        public void push(T item)
        {
            if (IsFull())
            {
                throw new StackOverflowException("Stack is Full");
            }
            top++;
            stack[top] = item;
          
        }
        public T pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is Empty");
            return stack[top--];
        }
        public T peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is Empty");
            return stack[top];
        }
        public bool IsFull()
        {
            if (top == capacity - 1) return true;
            else return false;
        }
        public bool IsEmpty()
        {
            if (top == -1) return true;
            else return false;
        }
        public int Count()
        {
            return top + 1;
        }

    }
}
