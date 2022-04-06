/*
 *C#  Queue<T> class is used to enqueue and dequeue elements.
 * It uses the concept of Queue that arranges elements in FIFO (First In First Out)
 * It can have duplicate elements.
 * It is found in System.Collections.Generic namespace.
 *
 *
 * This is an example that shows how a queue class can store elements using enqueue method and remove using dequeue method
 */

using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    public class Queue
    {
        public void operations()
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Lethal");
            names.Enqueue("Ouda");
            names.Enqueue("Owuor");
            names.Enqueue("Richard");
            
            Console.WriteLine("Initial queue elements");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            
            Console.WriteLine("Peeking element " + names.Peek());
            Console.WriteLine("Dequeue " + names.Dequeue());
            Console.WriteLine("After dequeue, peek element " + names.Peek());
        }
    }
}