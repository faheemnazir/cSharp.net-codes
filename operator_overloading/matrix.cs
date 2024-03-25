namespace operator_overloading;

public class matrix
{
    public int a, b, c, d;

    public matrix(int a,int b,int c,int d)
    {
        this.a = a;this.b= b;this.c = c;this.d = d;

    }

    public override string ToString()
    {
        return a + " " + b + "\n" + c + " " + d + " \n";
    }

    public static matrix operator +(matrix m1, matrix m2)
    {
        return new matrix(m1.a + m2.a, m1.b + m2.b, m1.c + m2.c, m1.d + m2.d);
    }

    public static matrix operator -(matrix m1, matrix m2)
    {
        return new matrix(m1.a - m2.a, m1.b - m2.b, m1.c - m2.c, m1.d - m2.d);
    }

}

