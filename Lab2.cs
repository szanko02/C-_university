using System;
public class MyClass
{
    protected decimal a;
    protected decimal b;

    public MyClass()
    {
        a = 12.323528;
        b = 7.182057003;
    }
    public float A1
    {
        get { return a / b; }
    }
    public float getSetB1
    {
        get { return a; }
        set { a = value; }
    }
    public float getSetC1
    {
        get { return b; }
        set { b = value; }
    }
}

public class MyClass2: MyClass
{
    private const bool f = true;
    protected decimal d;
    
    public MyClass2(decimal a, decimal b, decimal d) : base(a, b)
    {
        this.d = d;
    }

    public MyClass2(): this(12.323528, 7.182057003, 20.2323)
    {    
        this.d = 20.2323;
    }
    public decimal getSetC2
    {
        get 
        {
            if (f == false) 
            {
                return b += d;
            }
            else
            {
                return b -= d;
            }
        }
    }

}
public class Program
{
    private static void Main()
    {
        MyClass MyObj = new MyClass();
        MyClass2 MyObj2 = new MyClass2();
        Console.WriteLine(MyObj2.getSetC2);
        Console.WriteLine(MyObj.A1);
    }
}

