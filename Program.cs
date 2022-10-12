using System;
public class MyClass
{
    protected decimal a;
    protected decimal b;

    public MyClass()
    {
        a = 12.323528m;
        b = 7.182057003m;
    }
    public decimal A1
    {
        get { return a / b; }
    }
    public decimal getSetB1
    {
        get { return a; }
        set { a = value; }
    }
    public decimal getSetC1
    {
        get { return b; }
        set { b = value; }
    }
}

public class MyClass2 : MyClass
{
    protected decimal d;
    private decimal[] arr;

    public MyClass2(decimal d) : base()
    {
        this.d = d;
    }
    public MyClass2(decimal d, int something) : this(d)
    {

        arr = new decimal[(int)a * something];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = C2 * i;
        }
    }

    public void printArray()
    {
        int k = 0;
        foreach (int i in arr)
        {
            Console.Write($"\nЧлен номер [{k++}]: {i} ");
        }
    }
    public decimal C2
    {
        get
        {
            if (b > d)
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
        MyClass2 MyObj2 = new MyClass2(20.2323m, 1);
        MyObj2.printArray();
        Console.WriteLine($"\n{MyObj2.C2}" );
        Console.WriteLine(MyObj2.A1);
    }
}