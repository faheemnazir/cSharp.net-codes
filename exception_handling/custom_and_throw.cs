namespace exception_handling;

public class custom_and_throw:ApplicationException
{
    public override string Message
    {
        get
        {
            return "custom exception occurs we dont want to divide by odd number";
        }
    }
}