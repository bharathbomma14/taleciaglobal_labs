class Driver
{
    static void Main()
    {
        int[] arr = new int[10];
        try
        {
            arr[15] = 1;
        }
        catch(IndexOutOfRangeException IOE)
        {
            Console.WriteLine(IOE.Message);
        }
    }
}