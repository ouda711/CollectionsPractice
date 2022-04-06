using System;

/*
 *Collection represents a group of objects and with their help, we can perform various operations on objects such as
 * -store object
 * -update object
 * -delete object
 * -retrieve object
 * -search object
 * sort objects
 *
 * Array has size limit but collections have sizes that grow dynamically
 *
 * Types of collections in C#
 * 1. system.Collections.Generic classes
 * The System.Collections.Generic namespace has the following classes:
 * -List, Stack, Queue, LinkedList, HashSet, SortedSet, Dictionary, SortedDictionary, SortedList
 * 2. System.Collections classes (Deprecated)
 * -ArrayList, Stack, Queue, Hashtable
 * 3. System.Collections.Concurrent
 *-BlockingCollection, ConcurrentBag, ConcurrentQueue, ConcurrentDictionary, Partitioner, OrderablePartitioner
 *
 * List initialization can also happen during declaration
 * var names = new List<string>(){"Ouda Wycliffe", "Caroline Wangari", "Adam Wanyama"};
 */

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("From List Class");
            var lister = new List();
            lister.addOperation();
            
            Console.WriteLine();
            
            Console.WriteLine("From HashSet");
            var hasset = new HashSet();
            hasset.operations();
            
            Console.WriteLine();
            
            Console.WriteLine("From SortedSet");
            var sortedSet = new SortedSet();
            sortedSet.operations();
            
            Console.WriteLine("From Stack: ");
            var stack = new Stack();
            stack.operations();
            
            Console.WriteLine();
            
            Console.WriteLine("From Queue");
            var queue = new Queue();
            queue.operations();
            
            Console.WriteLine();
            
            Console.WriteLine("From LinkedList");
            var linkedList = new LinkedList();
            linkedList.operations();
            
            Console.WriteLine();
            var dictionary = new Dictionary();
            dictionary.operations();

        }
    }
}