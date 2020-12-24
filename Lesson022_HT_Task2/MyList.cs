using System;
namespace Lesson022_HT_Task2
{
    public class MyList<T>
    {
        T[] array = null;
        int i = 0;
        int j = 0;
        int count = 0;
        public MyList(T[] array)
        {
            this.array = array;
        }
        public void Add(T el)
        {
            T[] arr = new T[array.Length + 1];
            array.CopyTo(arr, 0);
            if (i >= arr.Length)
            {
                Console.WriteLine("Max Length");
                return;
            }
            array[i] = el;
            Console.WriteLine(array[i]);
            i++;
        }

        public int Count()
        {
            return i;
        }

        public void Clear()
        {
            array = new T[array.Length];
            i = 0;
        }

        public bool Contains(T el)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(el))
                {
                    return true;
                }
            }
            return false;
        }

        string res;
        public override string ToString()
        {
            for (int k = 0; k < array.Length; k++)
            {
                res += " over: " + array[k];
            }
            return res;
        }

        public void output()
        {
            foreach (T element in array)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }
            Console.WriteLine($"Number of elements: {count}");
        }
        public T Element(int index)
        {
            return array[index];
        }
    }
}
