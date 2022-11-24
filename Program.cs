using System;
class B
{
    private int val;

    public B(int value)
    {
        this.val = value;
    }

    public static bool operator true(B obj)
    {
        return obj.val > 0;
    }

    public static bool operator false(B obj)
    {
        return obj.val < 0;
    }

    public static bool operator &(B obj, int value)
    {
        if (obj.val == value)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        B obj = new B(10);
        Console.WriteLine("More than zero?");
        if (obj)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

        bool result = obj & 10;
        Console.WriteLine($"Is equal?\n{result}");
    }
}