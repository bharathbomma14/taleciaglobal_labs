using System;
class MathUtils
{
    public static int Min(int a, int b)
    {
        return a < b ? a : b;
    }
    public static int Max(int a, int b)
    {
        return b < a ? a : b;
    }
    static void Main()
    {
        int t1 = Convert.ToInt32(Console.ReadLine());
        int t2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the mininum value is "+Min(t1, t2));
        Console.WriteLine("the maximum value is "+ MathUtils.Max(t1, t2));
    }
}