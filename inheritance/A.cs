namespace inheritance;

public class A
{
    public void test()
    {
        Console.WriteLine("im method of parent class");
    }
}

class C:A
{
    public void test1()
    {
        Console.WriteLine("im method of child class");
        
    }
    
}

