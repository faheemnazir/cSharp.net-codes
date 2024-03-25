namespace Enumerations;

public enum days
{
    MON,TUE,WED,THU,FRI
}
public class enumeration_test
{
    //autoatic property for meeing date
    public static days meeting_date { get; set; } = days.MON;
    public static void Main(string[] args)
    {
        days d = 0;
        // Console.BackgroundColor =ConsoleColor.DarkRed; this BackgroundColor is also an enum so we can not assiagn any other values appart from these
        Console.WriteLine(d);
        Console.WriteLine(days.FRI);
        Console.WriteLine((int)days.FRI);
        foreach (var cosntant in Enum.GetNames(typeof(days)))
        {
            Console.WriteLine(cosntant);
            
        }
        Console.WriteLine("the meeting date is "+meeting_date);
        //chnage the meeting date like this 
        //meeting_date = "saturday"; will give an error becuase meeting_date is type of enum so we can not aasiagn string
        meeting_date = days.WED;
        Console.WriteLine("the new mwwting date is "+meeting_date);

    }
}