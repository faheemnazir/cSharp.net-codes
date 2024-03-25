namespace interfaces;

public class classTest:interface2
{
    public int add(int a, int b)
    {
        return a+ b;
    }
    public int sub(int a, int b)
    {
        return a-b;
    }

    public double mul(int a, int b)
    {
        return a * b;
    }
    public double div(int a,int b){
        return a/b;
        }

    static void Main(string[] args)
    {
        classTest test = new classTest();
       Console.WriteLine(test.add(20, 19));
        Console.Write(test.sub(90, 45));
       
        Console.Write(test.div(90,45));
    }
}