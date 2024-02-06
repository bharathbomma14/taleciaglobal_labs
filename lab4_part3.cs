// Random Number Generator
using System;
class RandomNumberGenerator
{
    // private Random random = new Random((int)DateTime.Now.Ticks);
    static Random random;
    static RandomNumberGenerator()
    {
        int seed = (int)DateTime.Now.Ticks;
        random = new Random(seed);
    }
    public static int Next(int bound)
    {
       return random.Next(bound);
    }
}
class Driver
{
    static void Main()
    {
        for(int i=0; i<10; i++)
        {
           Console.WriteLine(RandomNumberGenerator.Next(5));
        }
    }
}