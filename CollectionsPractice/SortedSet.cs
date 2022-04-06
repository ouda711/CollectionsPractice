/*
 * C# SortedSet class can be used to store, remove or view elements.
 * It maintains ascending order and does not store duplicate elements.
 * It is suggested toto use SortedSet class if you have to store unique elements and maintain ascending order. It is found in System.Collections.Generic namespace
 */

using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    public class SortedSet
    {
        public void operations()
        {
            var names = new SortedSet<string>();
            names.Add("C++");
            names.Add("C#");
            names.Add("JavaScript");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}