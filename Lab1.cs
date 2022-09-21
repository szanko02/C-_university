public class MyClass{
    private decimal a = 12.323528;
    private decimal b = 7.182057003;
    
    public decimal C{
        get{
            return a += b;
        }
    }
    public decimal A1{
        get{return a;}
        set{a = value;}
    }
    public decimal B1{
        get{return b;}
        set{b = value;}
    }
}


public class Program{
    void Main(){
        MyClass myObj = new MyClass();
        Console.WriteLine(myObj.C)
    }

}