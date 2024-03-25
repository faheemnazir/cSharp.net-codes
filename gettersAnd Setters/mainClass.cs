
namespace gettersAnd_Setters;
using System;
using System.Collections.Generic;

public class mainClass
{
    
    public static void Main(string[] args)
    {
        List<getterAndSetter> newlist = new List<getterAndSetter>();
        getterAndSetter gse = new getterAndSetter();
        gse.fname = "faheem";
        gse.lname = "nazir";
        gse.city = "sopore";
        gse.age = 20;
        Console.WriteLine(gse.fname + " " + gse.lname + " " + gse.city + " " + gse.age);
        getterAndSetter gs = new getterAndSetter();
        Console.WriteLine("enter the first name");
        gs.fname= Console.ReadLine();
        
        Console.WriteLine("enter the last name");
        gs.lname= Console.ReadLine();
        
        Console.WriteLine("enter the city name");
        gs.city = Console.ReadLine();
        
        Console.WriteLine("enter the age of person");
        gs.age= int.Parse(Console.ReadLine());
        newlist.Add(gs);
        Console.WriteLine("details of the person are as follows");
        Console.WriteLine("------------------------------------------------------------------");
        foreach (var item in newlist)
        {
            Console.WriteLine("first name is "+item.fname+"lastname is "+item.lname+"city is "+item.city+"age is "+item.age);
        }
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine("enter the first name to search");
        string name = Console.ReadLine();
        var personToRemove = newlist.Find(getterAndSetter => getterAndSetter.fname.Equals(name,
            StringComparison.OrdinalIgnoreCase));
        if (personToRemove!=null)
        {
            newlist.Remove(personToRemove);
            Console.WriteLine("deleted sucessesfully");
        }


    }

}