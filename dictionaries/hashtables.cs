namespace dictionaries;
using System;
using System.Collections.Generic;
public class hashtables
{
    public void addDictionary()
    {
        Dictionary<int, customDictionaryClass> cd = new Dictionary<int, customDictionaryClass>();
        Console.WriteLine("enter the keys and values of the dictionary");
        customDictionaryClass cls = new customDictionaryClass();
        
        Console.WriteLine("enter the key here");
        int key = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the values here");
        Console.WriteLine("enter the name");
        cls.name = Console.ReadLine();
        Console.WriteLine("enter the city");
        cls.city = Console.ReadLine();
        Console.WriteLine("enter the age here");
        cls.age = int.Parse(Console.ReadLine());
        /*Console.WriteLine("enter the city here");
        cls.city = Console.ReadLine();
        Console.WriteLine("the baisic details are");
        Console.WriteLine(cls);*/

        cd.Add(key,cls);
        Console.WriteLine("the dictionary formant is");
        foreach (var item in cd.Keys)
        {
            Console.WriteLine(cd[item]);
            
        }
        

    }
    
    static void Main(string[] args)
    {
        hashtables ht = new hashtables();
        ht.addDictionary();
        ht.addDictionary();
        ht.addDictionary();
        /*Dictionary<string, object> dt = new Dictionary<string, object>();
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("enter the key value pair");
            string key = Console.ReadLine();
            object val = Console.ReadLine();
            dt.Add(key,val);
        }
        Console.WriteLine("details are");
        foreach (var key in dt.Keys)
        {
            Console.WriteLine(key + ":" + dt[key]);
        }
        Console.WriteLine("enter the size of the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());

        }

        foreach (var ele in arr)
        {
            Console.WriteLine(ele);
        }*/
    }
    
}