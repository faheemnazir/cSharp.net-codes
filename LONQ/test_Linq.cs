namespace LONQ;
using System.Linq;
using System;
public class test_Linq
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("entre the size of the array");
        // int n = int.Parse(Console.ReadLine());
        // int[] arr = new int[n];
        Console.WriteLine("entre the elements of the array");
        // for (int i = 0; i < n; i++)
        // {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);//take array as input in one line
        Console.WriteLine("elements of the array are");
        foreach (int ele in arr)
        {
            Console.Write(ele+" ");
            
        }
        Console.WriteLine();
        //print array elemnts using the linq  sort them
        var brr = from ele in arr select ele;
        Console.WriteLine("printihg using linq");
        foreach (var item in brr)
        {
            Console.Write(item+" ");
            
        }
        Console.WriteLine();
        Console.WriteLine("filtering elements greater than 10");
        var crr = from i in arr where i > 10 orderby i select i;
        foreach (var i in crr)
        {
            Console.Write(i+" ");
            
        }
        //if we are sorting the elemnts using traditional sorting algo we need to write the loop
        //here it makes it simple

    }
}