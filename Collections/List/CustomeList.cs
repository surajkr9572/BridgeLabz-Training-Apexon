using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.List
{
    public class CustomeList<T>
    {
        private T[] items;
        private int count;
        public CustomeList()
        {
            items = new T[4];
            count = 0;
        }
        public int Count
        {
            get {  return count; }
        }
        public void Add(T item)
        {
            if(count==items.Length)
            {
                Resize();
            }
            items[count] = item;
            count++;
        }
        private void Resize()
        {
            T[] newArray = new T[items.Length * 2];
            for(int i=0;i<items.Length;i++)
            {
                newArray[i] = items[i];

            }
            items = newArray;
        }
        public void print()
        {
            for(int i = 0; i < count; i++)
            {
                Console.Write(items[i]+" ");
            }
            Console.WriteLine();
        }

        public void Remove(int index)
        {
            if(index<0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for(int i =index;i<count-1 ; i++)
                {
                    items[i] = items[i + 1];
                }
                items[count-1] = default(T);
                count --;
            }

        }
    }
}
