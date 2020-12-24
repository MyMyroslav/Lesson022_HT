using System;

namespace Lesson022_HT_Task2
{
    class MainClass
    { 
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            MyList<int> arrayList2 = new MyList<int>(arr);
            arrayList2.Add(1);
            arrayList2.Add(15);
            arrayList2.Add(2);
            arrayList2.Add(5);
            arrayList2.Add(8);
            arrayList2.Add(7);
            arrayList2.Add(25);
            arrayList2.Add(123);
            arrayList2.Add(55);
            arrayList2.Add(81);
            Console.WriteLine(" ");
            arrayList2.output();
            Console.WriteLine(" ");
            Console.WriteLine($"Count: {arrayList2.Count()}");
            Console.WriteLine(" ");
            Console.WriteLine(arrayList2.ToString());
            arrayList2.Clear();
            Console.WriteLine(" ");
            Console.WriteLine($"Count: {arrayList2.Count()}");
            Console.WriteLine(" ");
            arrayList2.Add(5);
            Console.WriteLine(arrayList2.Contains(5));
            
        }
    }
}
