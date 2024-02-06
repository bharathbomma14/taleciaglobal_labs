
public delegate int HistogramSource();
class Histogram
{
    public event HistogramSource histogram;
    public void Draw()
    {
        if(histogram !=null)
        {
            foreach(HistogramSource source in histogram.GetInvocationList())
            {
                int magnitude = source();
               for(int i=0; i<magnitude; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }    
    }
}
class RandomSource
{
    private int max;
    private Random r;
    public RandomSource(int max)
    {
        this.max = max;
        r = new Random();

    }
    public int Magnitude()
    {
        return r.Next(max);
    }
}
class Driver
{
    static void Main()
    {
        Histogram histogram = new Histogram();
        RandomSource rs1 = new RandomSource(15);
        RandomSource rs2 = new RandomSource(20);

        histogram.histogram += rs1.Magnitude;
        histogram.histogram += rs2.Magnitude;

        histogram.Draw();
    }
}
