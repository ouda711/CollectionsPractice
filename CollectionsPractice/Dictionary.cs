/*
 * C# Dictionary <TKey, TValue> class uses the concept of hashtables. It stores valiuies on the basis of key.
 * It contains unique keys only.
 * By the help of key, we can easily search or remove elements.
 * It is found in System.Collections.Generic namespace
 * 
 */

using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    public class Dictionary
    {
        public void operations()
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1","Sonoo");  
            names.Add("2","Peter");  
            names.Add("3","James");  
            names.Add("4","Ratan");  
            names.Add("5","Irfan");  
            
            foreach (KeyValuePair<string, string> kv in names)  
            {  
                Console.WriteLine(kv.Key+" "+kv.Value);  
            }  
        }
    }
}