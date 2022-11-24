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
    private decimal[,] twoDimArray = { { 11.11m, 22.22m, 33.33m }, { 44.44m, 55.55m, 66.66m } };

    public decimal this[int ind1, int ind2]
    {
        get { return twoDimArray[ind1, ind2]; }
        set { twoDimArray[ind1, ind2] = value; }
    }
    public decimal this[int ind1]
    {
        get { return arr[ind1]; }
        set { arr[ind1] = value; }
    }
    public MyClass2(decimal d) : base()
    {
        this.d = d;
    }
    public MyClass2(decimal d, int something) : this(d)
    {

        arr = new decimal[(int)a];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = C2 * i;
        }   
    }

    public void PrintArray()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Член номер [{i + 1}]: {arr[i]} ");
        }
        for (int i = 0; i < twoDimArray.GetLength(0); i++)
        {
            for (int j = 0; j < twoDimArray.GetLength(1); j++)
            {
                Console.WriteLine($"Член номер [{i + 1}, {j + 1}]: {twoDimArray[i, j]} ");
            }
            
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
public class C<T>
{
    public static string smth;
}
public class Program
{
    private static void Main()
    {
        MyClass MyObj = new MyClass();
        MyClass2 MyObj2 = new MyClass2(20.2323m, 1);
        Console.WriteLine($"\n{MyObj2.C2}");
        Console.WriteLine(MyObj2.A1);
        MyObj2.PrintArray();

        C<string>.smth = "some string";
        C<int>.smth = "another string";
        Console.WriteLine($"\n{C<string>.smth}, {C<int>.smth}");
    }
}