namespace employeesWage;

public class chech_if_present
{
    public int checknumber;
    public void check()
    {
        int is_FULL_TIME = 1;
        Random rdm = new Random();
        int checknumber = rdm.Next(2);
        if (is_FULL_TIME == checknumber)
        {
            Console.WriteLine("employess is present");
           
        }
        else
        {
            Console.WriteLine("employess is absant");
            
            
        }
    }
}