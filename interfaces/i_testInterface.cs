namespace interfaces;

public interface i_testInterface
{
    public const double p1 = 3.14;
    public int add(int a, int b);
    public int sub(int ab, int b);
}

public interface interface2 : i_testInterface
{
    public double mul(int a, int b);
    public double div(int ab,int b);
}