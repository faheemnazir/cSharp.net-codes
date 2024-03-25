using System.Text.RegularExpressions;

namespace checkCustom;

public class NotAMynumberException : ApplicationException
{
    public override string Message
    {
        get
        {
            return "please enter a number instead";
        }
    }
}
public class chech
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("enter the number");
            string x = Console.ReadLine();
            Regex regex = new Regex(@"^\d+$");
            if (!(regex.IsMatch(x)))
                throw new NotAMynumberException();
            Console.WriteLine("you entered " + x);


        }
        finally
        {
            Console.WriteLine("end of main");

        }

    }
    
}