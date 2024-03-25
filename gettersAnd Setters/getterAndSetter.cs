
namespace gettersAnd_Setters;
using System;
using System.Collections.Generic;

public class getterAndSetter
{
    public string fname { get; set; }
    public string lname { get; set; }
    public string city{ get; set; }
    public int age{ get; set; }

    public getterAndSetter()
    {
        Console.WriteLine("inside the getter setter class");
    }
}