using System.Data.SqlTypes;

class ExceptionTest
{
    static void Write(string filename, string message)
    {
        StreamWriter sw = null;
        try
        {
            sw = new StreamWriter(filename);
            sw.WriteLine(message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.ToString());
        }
        finally
        {
            if (sw != null)
            {
                sw.Close();
                Console.WriteLine("file closed in final block");
            }
        }
    }
    static void Main()
    {
        Write("data.txt", "good day");
       /* try
        {
            int[] arr = new int[10];
            int arrayindex = int.Parse(Console.ReadLine());
            arr[arrayindex] = 19;
            
            int integer1= int.Parse(Console.ReadLine());
            int integer2=int.Parse(Console.ReadLine());
            int result=integer1/integer2;
            Console.WriteLine("The result of both the values {0}", result);
        }
        catch
        {
            Console.WriteLine("The genral catch clause");
        }*/
        /*catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }*/
        /*catch(IndexOutOfRangeException IOC)
        {
            Console.WriteLine("IOC exception" + IOC.Message);
            Console.WriteLine(IOC.StackTrace);
            Console.WriteLine(IOC.ToString());
        }
        catch(DivideByZeroException DZE)
        {
            Console.WriteLine(DZE.Message);
            Console.WriteLine(DZE.StackTrace);
            Console.WriteLine(DZE.ToString());
        }*/
        
    }
}