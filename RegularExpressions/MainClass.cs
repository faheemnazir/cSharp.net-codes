using System.Text.RegularExpressions;

namespace RegularExpressions;

public class MainClass
{
    static void Main(string[] args)
    {
        valid_name valid = new valid_name();
        Console.WriteLine("enter the first name to check");
        string fname = Console.ReadLine();
        if(valid.is_valid_fname(fname))
            Console.WriteLine($"name {fname} is valid name");
        else
        {
            Console.WriteLine($"name {fname} is invalid name");
        }
        Console.WriteLine("enter the last name to check");
        string lname = Console.ReadLine();
        if(valid.is_valid_lname(lname))
            Console.WriteLine($"name {lname} is valid name");
        else
        {
            Console.WriteLine($"name {lname} is invalid name");
        }
        Console.WriteLine("enter the phone number to check");
        string number = Console.ReadLine();
        if(valid.is_valid_phonenumber(number))
            Console.WriteLine($"phone number {number} is valid");
        else
        {
            Console.WriteLine($"phone number {number} is invalid");
        }
        
        Console.WriteLine("enter the password to check");
        string passwd = Console.ReadLine();
        if(valid.is_valid_passwd(passwd))
            Console.WriteLine($"the passwd {passwd} is valid");
        else
        {
            Console.WriteLine($"the passwd {passwd} is invalid");
        }

        // string name= "abc 12";
        // string patt = @"[a-f]{3}\s\d{2}";
        // if(Regex.IsMatch(name,patt))
        //     Console.WriteLine("true");
        // else
        // {
        //     Console.WriteLine("fale");
        // }
    }
}