namespace exception_handling;

public class exception_demo
{
    static void Main(string[] args)
    {
       /* Console.WriteLine("testing the exceptions");
        Console.WriteLine("enter the first number");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the second number");
        int y = int.Parse(Console.ReadLine());

        int z = x / y;
        Console.WriteLine("the result is "+ z);
        Console.WriteLine("thank you");
        
        
        
       /* testing the exceptions 
            enter the first number
        10
        enter the second number
        0
        Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            at exception_handling.exception_demo.Main(String[] args) in /home/faheem/PRACTICE/exception_handling/exception_demo.cs:line 13
*/  //if we are not handling the exception this error will terminate the program abnormally
       //using try catch 
       try
       {
           Console.WriteLine("enter the first number");
           int x = int.Parse(Console.ReadLine());
           Console.WriteLine("enter the second number");
           int y = int.Parse(Console.ReadLine());
           if (y % 2 != 0)
               throw new custom_and_throw();
           int z = x / y;
           Console.WriteLine("the result is " + z);

       }
       catch (DivideByZeroException ex)
       {
           Console.WriteLine("second number must be non zero");
           Console.WriteLine(ex.Message);

       }
       catch (FormatException fe)
       {
           Console.WriteLine("give only numbers as input");
           //Console.WriteLine(fe.StackTrace);
           Console.WriteLine(fe.Message);
       }
       finally
       {
           Console.WriteLine("this is the finally block executed at any cast ,you can not escape from this");
           //generally the code like closing database connection
           //closing network connection
           //closing files etc are put into this finally block even something may go wrong even in the abnormal 
           //termination of the application these statements are executed
           
       }
       Console.WriteLine("thank you");  //we can write as many catch blocks 
       //when exception i handeled the catch block varaible is aasiagned with the instance of the related exception class and becomes reference of that
       
    }
}