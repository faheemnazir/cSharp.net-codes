
namespace RegularExpressions;
using System.Text.RegularExpressions;
public class valid_name
{
    public bool is_valid_fname(string name)
    {
        string pattern = "[A-Z]{1}[a-z]{3}";

        return(Regex.IsMatch(name, pattern));
    }
    public bool is_valid_lname(string name)
    {
        string pattern = "[A-Z]{1}[a-z]{3}";

        return(Regex.IsMatch(name, pattern));
    }

    public bool is_valid_phonenumber(string number)
    {
        string patten = @"^\+\d{2}\s\d{10}";
        return (Regex.IsMatch(number, patten));
    }

    internal bool is_valid_passwd(string passwd)
    {
        string pass = @"^(?=.*[A-Z])(?=.*[\w_]).{8,}&";
        return (Regex.IsMatch(passwd, pass));
    }
    
    
}