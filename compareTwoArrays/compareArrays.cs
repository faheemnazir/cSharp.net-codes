namespace compareTwoArrays;
using System;
public class compareArrays
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("enter the size of the first array");
        int n1 = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n1];
        Console.WriteLine("enter the size of the second array");
        int n2= int.Parse(Console.ReadLine());
        int[] arr2 = new int[n2];
        Console.WriteLine("enter the elements of the first array");
        for (int i = 0; i < n1; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("enter the elements of the second array");
        for (int i = 0; i < n2; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        
        List<int> arr3 = new List<int>();
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j< n2; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    arr3.Add(arr1[i]);
                }
            }
        }
        Console.WriteLine("common elements are");
        
        foreach (var ele in arr3)
        {
            Console.WriteLine(ele+" ");
        }
        
        Console.WriteLine("enter the input string");
        string input = Console.ReadLine();
        Console.WriteLine("enter the replacement");
        string pat = Console.ReadLine();
        string[] newstr = input.Split();
        newstr[newstr.Length-1] = pat;
        foreach (var s in newstr)
        {
            Console.Write(s+" ");
            
        }

    }
}