using System.Security.Cryptography;

class Point
{
    private int a;
    private int b;
    public void Initialize(int x, int y)
    {
        this.a = x;
        this.b = y;
    }
    public void Seta(int x) {
        this.a = x; 
    }
    public void Setb(int y) {  
        this.b = y; 
    }
    public int geta() {
        return a;
     }
    public int getb()
    {
        return b;
    }
    public void Translate(int aOffset, int bOffset)
    {
        this.a += aOffset;
        this.b += bOffset;
    }
    public void Scale(int a)
    {
        this.a *= a;
        this.b *= a;
    }
    public double Distance(Point p)
    {
        //Console.WriteLine(p.a);
        //Console.WriteLine(this.a);
        //Console.WriteLine(geta());
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        double distance = Math.Sqrt(((this.a - p.geta()) * (this.a - p.geta())) + ((this.b - p.getb()) * (this.b - p.getb())));
        return distance;
    }
    static void Main(String[] args)
    {
        Point p1 = new Point();
        p1.Initialize(2, 5);
        p1.Seta(12);
        p1.Setb(14);
        p1.Translate(10, 12); p1.Scale(10);


        Point p2 = new Point();
        p2.Initialize(2, 5);
        Console.WriteLine(p1.Distance(p2));




    }
}