/*
 *C# Stack<T> class is used to push and pop elements. It uses the concept of Stack that arranges elements in LIFO
 * (Last In First Out) order.
 * It can have duplicate elements.
 * It is found int the System.Collections.Generic namespace
 * 
 */

using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    public class Stack
    {
        public void operations()
        {
            Stack<string> names = new Stack<string>();
            
            names.Push("Tovuti Grouo");
            names.Push("Paytreee Group");
            names.Push("Anzili Group");
            names.Push("Quatrix");

            Console.WriteLine("Initial stack");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            
            Console.WriteLine();
            
            Console.WriteLine("Peeking in Stack: "+ names.Peek());
            Console.WriteLine("Popping from Stack: " + names.Pop());
            Console.WriteLine("After Popping: "+ names.Peek());
        }
    }
}