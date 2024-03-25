namespace multiple_inheritance;

interface interface1
{
    void test(string name);

}

interface interface2
{
    void test();

}

public class test_multiple_inheritance
{
    public void test()
    {
        Console.WriteLine("implemeted in class ");
    }

    public void test(string name)
    {
        Console.WriteLine("your name is "+name);
    }
    static void Main()
    {
        test_multiple_inheritance t = new test_multiple_inheritance();
        t.test();
        Console.WriteLine("enter your name here");
        t.test(Console.ReadLine());

    }
    
}