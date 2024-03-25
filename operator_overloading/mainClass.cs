namespace operator_overloading;

public class mainClass
{
    public static void Main(string[] args)
    {
        matrix m1 = new matrix(1, 2, 3, 4);
        matrix m2 = new matrix(5, 6, 7, 8);
        Console.Write("the sum of the matrix is \n"+(m1+m2));
        Console.Write("the subtraction of the matrix is \n"+(m2-m1));
    }
}