using System.Collections;

namespace genericDemo;

public class generics
{
    private static void printArrays<T>(T[] arr){
        foreach (var ele in arr)
        {
            Console.Write(ele+" ");
            
        }
        
    }

    public static void Main(string[] args)
    {
        int[] arr = new[] { 1, 2, 3, 4 };
        string[] sArray= new[] { "fah", "eem", "naz" };
        printArrays(arr);
        Console.WriteLine();
        printArrays(sArray);
        Hashtable ht = new Hashtable();
        ht.Add("name","faheem");
        ht.Add("age", 23);
        Console.WriteLine();
        Console.WriteLine("engete the key to find");
        string mykey = Console.ReadLine();
        if(ht.Contains(mykey))
            Console.WriteLine("the key value pair is "+mykey+" : "+ht[mykey]);
        foreach (var key in ht.Keys)
        {
            Console.WriteLine(key+" : "+ht[key]);
            
        }

        var newtable = (Hashtable)ht.Clone();
        foreach (var key in newtable.Keys)
        {
            Console.WriteLine(key+" : "+newtable[key]);
            
        }
        
    }
}