
using System;
using System.Collections.Generic;
public class customDictionaryClass
{
    public string name { get; set; }
    public string city { get; set; }
    public int age { get; set; }

    public customDictionaryClass()
    {
	    Console.WriteLine("constor created");
    }

    public override string ToString()
    {
	    return name + " " + age + " " + city;
    }
}