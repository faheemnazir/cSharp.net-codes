namespace properties_in;

public class circle
{
    private double radius;
    public double setrad(double val){
	radius=val;
}

    public double getSet					
    {							//instead we can write like this which can as as a setter as well as getter at a same time
        get{ return radius; }
        set { radius = value; }
    }
}
