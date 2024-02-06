/*class Program
{
    static void Main()
    {
        string s1 = "Hello! world";
        for(int i=0; i<s1.Length; i++)
        {
            char ch = s1[i];
            Console.WriteLine($"the character at index{i} is {ch}");
        }
        //s1[4] = 'b';
        Console.WriteLine(s1.Length);
    }
}
*/
// part-2 simple indexer- student grades
/*
class Student
{
    private double[] gpas = new double[4];
    public double this[int year]
    {
        get
        {
            if(year>=1 && year<=4)
            {
                return gpas[year - 1];
            }
            else
            {
                Console.WriteLine("Invalid year");
                return -1;
            }
        }
        set
        {
            if(year>=1 && year<=4)
            {
                gpas[year-1] = value;
            }
            else
            {
                Console.WriteLine("Invalid year option to store.");
            }
        }
    }
    static void Main()
    {
        Student std = new Student();
        std[1] = 8.0;
        std[2] = 9.45;
        std[3] = 7.5;
        std[4] = 7.7;
        Console.WriteLine(std[3]);
    }
}
*/

// part-3 Sophisticated indexer

using System.Net.Sockets;

class Photo
{
    private string title;
    public Photo(String title)
    {
        this.title = title;
    }
   public string Title
    {
        set
        {
            this.title = value;
        }
        get
        {
            return this.title;
        }
    }
}
class Album
{
    Photo[] photos;
    public Album(int capacity)
    {
        photos = new Photo[capacity];
    }
    public Photo this[int index]
    {
        get
        {
            if(index>=0 && index<photos.Length)
            {
                return photos[index];
            }
            else
            {
                Console.WriteLine("the index value are: ");
                return null;
            }
        }
        set
        {
            if(index>=0 && index<photos.Length)
            {
                photos[index] = value;
            }
            else
            {
                Console.WriteLine("not the valid index: ");
            }

        }
    }
    public Photo this[string title]
    {
        get
        {
            foreach(Photo photo in photos)
            {
                if (photo.Title == title && photo != null)
                {
                    return photo;
                }
            }
            return null;
        }
    }
}
class Driver
{
    static void Main()
    {
        Album al = new Album(5);
        al[0] = new Photo("Bharath");
        al[1] = new Photo("father");
        al[2] = new Photo("mother");
        al[3] = new Photo("sister");
        al[4] = new Photo("wife");
        Console.WriteLine("Accessing with index: "+ al[4].Title);
        Console.WriteLine("Accessing with string: " + al["wife"].Title);
    }
}