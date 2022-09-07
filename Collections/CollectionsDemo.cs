using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class CollectionsDemo
    {
        public static void ListCollection()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(40);
            list.Add(30);
            list.Add(20);
            Console.WriteLine("Size of list At position 4: " + list.Capacity);
            list.Add(50);
            Console.WriteLine("Size of list At position 5: " + list.Capacity);
            list.Add(30);
            Console.WriteLine("Number of elements present " + list.Count);
            Console.WriteLine("\nDisplaying all elements from list");
            IterateOverCollection(list);

            Console.WriteLine("\n\nRemoving items from list");
            bool isRemove = list.Remove(30);
            Console.WriteLine("\nNumber of elements present " + list.Count);
            if (isRemove)
            {
                Console.WriteLine("\nAfter remove Displaying all elements from list");
                IterateOverCollection(list);
            }
            Console.WriteLine("\n\nSorting");
            list.Sort();
            Console.WriteLine("\nAfter sorting Displaying all elements from list");
            IterateOverCollection(list);
        }
        public static void IterateOverCollection(List<int> list)
        {
            foreach (var element in list)
            {
                Console.Write(" " + element + " ");
            }
        }
        public static void ArrayListCollection()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("abc");
            arrayList.Add(12.45);
            foreach (var element in arrayList)//var becuase taken different datatype above
            {
                Console.Write(" " + element + " ");
            }
            //Will be same like List
        }
        public static void DictionaryCollection()
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            foreach (KeyValuePair<int, string> kvp in numberNames)
            {
                Console.WriteLine("Key : {0}, Value : {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("Fetching value using 3 key : " + numberNames[3]);
        }
        public static void StackDemo()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Sachin");
            stack.Push("Virat");
            stack.Push("Mahi");
            stack.Push("Yuvi");
            foreach(var element in stack)
            {
                Console.WriteLine(element);
            }
            string pop = stack.Pop();
            Console.WriteLine("\npopped element is : " +pop);
        }
        public static void SetCollection()
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(10);
            set.Add(40);
            set.Add(30);
            set.Add(20);

            HashSet<int>.Enumerator enumerator = set.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            //foreach(var element in set)
            //{
            //    Console.WriteLine(element);
            //}
        }
        public static void QueueDemo()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(50);
            foreach(int element in queue)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Head is : " + queue.Peek());
            int dequeue=queue.Dequeue();
            Console.WriteLine("Dequeue element "+dequeue);

            Console.WriteLine("Iterating queue elements after the dequeue of one element");
            Queue<int>.Enumerator enumerator=queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
