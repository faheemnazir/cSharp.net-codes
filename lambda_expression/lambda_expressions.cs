namespace lambda_expression
{
    public delegate string greet_delegate(string name);

    public class lambda_expressions
    {

        //func delegeta is used when a method is returning a value
        private static Func<int, float, double, double> add = (x, y, z) =>
        {
            return x + y + z;

        };
        //to concatinate two string use like this
        private static Func<string,string,string> concat=(str1,str2)=>str1+str2;
        
        //Action is used when a method is not returning anything
        //just pring the greeting message

        public static Action<string> greet = (name) =>
        {
            Console.WriteLine("hello "+name);

        };//here it can also take any number of parameters nut non returning
        
        
        //using predicate :it is uswd when a method is returning the boolean value
        //return true if a string lemgth is >5

        private static Predicate<string> greaterthen5 = (str) =>
        {
            return str.Length > 5;
        };
        
        public string greeting(string name)
        {
            return "hello " + name + " welcom to lambda and delegated";
        }

        static void Main(string[] args)
        {
            lambda_expressions le = new lambda_expressions();
            greet_delegate gd = le.greeting;
            Console.WriteLine(gd.Invoke("faheem"));
            //lambda operator => and use it here as
            greet_delegate greet = (name) =>
            {
                return "hello " + name;
            };
            Console.WriteLine(greet.Invoke("faheem"));

            Action fah = () =>
            {
                Console.Write("hellow faheem nazir");

            };
            fah();
            //there are three predefined deleggates to use to simplify the work by uisng the lambda 
            //func,Action and predicate
            
            //if we want to add three numbers of different types we can use
            
            Console.WriteLine("calling add using lambda and delegate and the sum is "+ add(12,12f,12.0));
            Console.WriteLine("calling concat using lambda to concatinate the string and result is  "+ concat("faheem ","nazir"));

            greet("faheem nazir");
            Console.WriteLine("the value retured by the predicate is "+greaterthen5("faheem"));


        }
    }
}