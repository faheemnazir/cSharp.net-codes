namespace extension_Methods;

public class test_extension_methods
{
    static void Main(string[] args)
    {
        class_to_WHICH_ADD add = new class_to_WHICH_ADD();
        add.test1();
        add.test2();
        Console.WriteLine("now extension methods are called from here");
        //extension methods are decleared as static once bounded to a class they will converted into non staic 
        add.test3();
        add.test4(1, 3);
    }
}