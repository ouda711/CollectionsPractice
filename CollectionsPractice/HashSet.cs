/*
 * C# hashset class can be used to store, remove or view elements. It does not store duplicate elements
 * It is recommended when there is need to store unique elements
 * Found in the System.Collections.Generic namespace
 */


using System;
using System.Collections.Generic;
namespace CollectionsPractice
{
    public class HashSet
    {
        public void operations()
        {
            var names = new HashSet<string>();
            names.Add("Lethal Ouda");
            names.Add("Duncan");
            names.Add("Caltex");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}