namespace customClassList;
using System;
using System.Collections.Generic;
public class person
{
    public string name { get; set; }
    public string city { get; set; }
    public int age{ get; set; }
    public string college { get; set; }
    public float height { get; set; }
    public person()
    {
        Console.WriteLine("my object has been created sucessesfully");
    }
}