/*
 *C# List<T> class is used to store and fetch elements. It can have duplicate elements. It is found in System.Collections.Generic namespace
 * 
 * 
 */
using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    public class List
    {
        public void addOperation()
        {
            var names = new List<string>();
            names.Add("Ouda Wycliffe");
            names.Add("Adam Wanyama");
            names.Add("Kevin Marete");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}