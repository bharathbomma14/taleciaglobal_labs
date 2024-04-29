using System;
using System.ComponentModel;
/*
class parameterTest
{
    public void Value(int x)
    {
        x += 10;
        Console.WriteLine(x);
    }
    public void Swap(ref int a, ref int b)
    {
        a = a + b - (b = a);
        Console.WriteLine(a);
        Console.WriteLine(b);
    } 
    public void MinMax(int[] a, out int min, out int max)
    {
        min = max = a[0];
        for(int i=1; i<a.Length; i++)
        {
            if (min > a[i])
            {
                min = a[i];
            }
            if (max < a[i])
            {
                max = a[i];
            }
        }
    }

}
class Driver
{
   static void Main(string[] arr)
    {
       
        parameterTest test = new parameterTest();
        int max, min;
        int[] args = { 12, 54, 98, 54, 98, 43, 5, 7, 11, 48, 99, 32, 16 };
        test.MinMax(args, out min, out max);
        Console.WriteLine(min);
        Console.WriteLine(max);
    
    }
}
*/
class Variable
{
    public int Sum(string prefix, params int[] Values)
    {
        Console.WriteLine(prefix);
        int sum = 0;
        for(int i=0; i<Values.Length; i++)
        {
            sum += Values[i];
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Variable var = new Variable();
        Console.WriteLine("The sum is: "+var.Sum("sum", 98, 495, 495, 894, 994, 99, 33, 46));
    }
}