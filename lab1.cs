/*namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // accept two int numbers and find the maximum then display
            int fno;
            int sno;
            int max;
            Console.Write("Enter First Number: ");
            fno = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number: ");
            sno = int.Parse(Console.ReadLine());

            if (fno > sno)
                max = fno;
            else
                max = sno;
            Console.WriteLine($"The max of {fno} and {sno} is {max}");

        }
    }
}*/

// lab1
/*
 * Goals: 
• Experiment with console input and output. 
• Declare and use variables. 
• Practice with language control constructs. 
• Create and manipulate arrays. 
• Perform environment interaction.
*/
using System;
using System.Numerics;

namespace ConsoleApp1
{
    internal class lab1
    {
       // static void Main(string[] args)
        //{
            // lab1-1 basic output
            /*
            int n1 = 12;
            double n2 = 3.56;
            char ch = 'A';
            float f = 12f;
            string s = "bharath";
            bool b = true;
            Console.WriteLine(n1 + " " + n1 + " "+ch);
            Console.Write(f + " " + s);
            Console.Write(b);
            Console.WriteLine();
            */


            //lab1-2 formatted output
            /*
            int first = 12;
            int second = 19;
            int max = first > second ? first : second;
            Console.WriteLine($"the max value is{first} and {second} is {max}");
            Console.WriteLine($"the value of {f} {s} {b}");

            */




            // lab1- 3 Input
            /*
            Console.WriteLine();
            Console.Write("please enter a int or double: ");
            string s1 = Console.ReadLine();
            int i1 = Convert.ToInt32(s1);
            double d1 = Convert.ToDouble(s1);
            Console.WriteLine($"The valuees  and {d1}");

            Console.WriteLine();

            */




            /*
            // lab1-part2-loops and conditionals
            double sum = 0;
            for(int i=0; i<=1000; i++)
            {
                float f2 = 1f;
                //Console.Write(f2 + "/" +((2*i)+1)+ " ");
                f2 /= ((2 * i) + 1);
                if (i % 2 == 1)
                    sum -= f2;
                else
                    sum += f2;
            }
             Console.WriteLine(sum);

            
            */
            /*
            // lab1 part3 switch calculator;
            Console.Write("Enter the first value: ");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second Value: ");
            double d3 = Convert.ToDouble(Console.ReadLine());
            String s3 = Console.ReadLine();
            char ch1 = Convert.ToChar(s3);
            switch(ch1)
            {
                case '+':  Console.WriteLine(d2 + d3); break;
                case '-': Console.WriteLine(d2 - d3); break;
                case '*': Console.WriteLine(d2 * d3); break;
                case '/': Console.WriteLine(d2 / d3); break;
                case '%': Console.WriteLine(d2 % d3); break;
                default: Console.WriteLine("sorry Invalid operator");
                    break;
            }
            */


            /*
            // lab-1 part 4 arrays

            int[] arr = new int[10];

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int t = arr[0];
            foreach(int i in arr)
            {
                Console.Write(i + " ");
                if(t>i)
                {
                    t = i;
                }
            }
            Console.WriteLine("The minimum digit in the array is: " + t);
            */



/*
            // lab1-part5 Multidimensional array

            double[,] a = new double[2, 5];
            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("The total no of elements are: " + a.Length);
            Console.WriteLine("The no of row: "+a.GetLength(0));
            Console.WriteLine("The no of columsn: " + a.GetLength(1));
            foreach(double i in a)
            {
                Console.WriteLine(i);
            }
        */
        }
    }
//}