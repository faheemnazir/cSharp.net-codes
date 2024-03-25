namespace delegeates
{
    public delegate int sumDelegate(int x, int y);

    public delegate string greet_delegate(string name);

    public delegate void rectangle(double a, double b);//this is multicast delegate used when we need to call the methods with same signiture and we call
    //them with the same values like rectangel to calculate the parameter and area we need to call method with same arguments length and width

    public class delegates_demo
    {

        public void getArea(double l, double w)
        {
            Console.WriteLine("the area is "+l * w);
        }

        public void getPeremeter(double l, double w)
        {
            Console.WriteLine("the parameter is "+ 2 * (l + w));
        }
        public int sum(int a, int b)
        {
            return a + b;
        }

        public static string greet(string name)
        {
            return "hello " + name;
        }

        static void Main(string[] args)
        {
            delegates_demo dl = new delegates_demo();
            Console.WriteLine("sum is " + dl.sum(2, 6));
            Console.WriteLine(greet("faheem"));
            sumDelegate sd = new sumDelegate(dl.sum);
            greet_delegate gd = new greet_delegate(greet);
            Console.WriteLine("invoking methods using delegates ");
            Console.WriteLine("the sum is "+sd.Invoke(2, 6));
            Console.WriteLine(gd.Invoke("faheem"));
            
            //instaintiate the mulricast delegate
            rectangle rec = dl.getArea;//one more way to instantiate delegate
            rec += dl.getPeremeter;//bind bothe the methods this is multicase delegate
            Console.WriteLine("calling rectangel methods using dleegates");
            rec.Invoke(4.0,5.0);
            
            //the advantage of the mlticast delegate is that we can bind multiple methods with the same delegste OBject and we call
            //the elegate.invoke just one with parameters and all the methods will be called/
            //but al methods should have same signature and should be called with same arguments or values
            
            //if methods are return typed the the value will be overidden and last methods value willl be returned
        }
    }
}