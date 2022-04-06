/*
 *C# LinkedList<T> class uses the concept of linked list.
 * It allows us to insert and delete elements faster.
 * It can have duplicate elements.
 * It is found in the System.Collections.Generic namespace
 * 
 */
using System;
using System.Collections.Generic;


namespace CollectionsPractice
{
    public class LinkedList
    {
        public void operations()
        {
            var names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");  
            names.AddLast("Ankit");  
            names.AddLast("Peter");  
            names.AddLast("Irfan");  
            names.AddFirst("John");//added to first index  
            
            foreach (var name in names)  
            {  
                Console.WriteLine(name);  
            }  
            
            //insert new element before "Peter"  
            LinkedListNode<String> node=names.Find("Peter");  
            names.AddBefore(node, "John");  
            names.AddAfter(node, "Lucy");  
            
            // Iterate list element using foreach loop  
            foreach (var name in names)  
            {  
                Console.WriteLine(name);  
            }  
        }
    }
}