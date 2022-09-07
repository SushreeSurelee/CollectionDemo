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
    }
}
