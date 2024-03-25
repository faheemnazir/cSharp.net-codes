namespace extension_Methods;

public static class extension_class   //here a class must be static classs and all the methods must be defined as static
{
    //extension methods are decleared as static once bounded to a class they will converted into non staic 
    //if extenison method is definned with same name and same signature with the original method will be callwd not extension method
    public static void test3(this class_to_WHICH_ADD add)
    {
        Console.WriteLine("adding new method to existing class ");
        
    }

    public static void test4(this class_to_WHICH_ADD add,int a,int b)  // this is the process of binding the methods to exisiting class
    {
        Console.WriteLine("adding one more method to existing class");
        Console.WriteLine("addition is also possible "+(a+b));
    }
}