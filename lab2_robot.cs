using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

class Robot
{
    private string? name;
    private int x;
    private int y;
    private int direction;
    public const int Size = 10;
    public const int North = 0;
    public const int East = 1;
    public const int South = 2;
    public const int West = 3;
    public const int Left = 4;
    public const int Right = 5;

    private Random random = new Random((int)DateTime.Now.Ticks);
    public void Initialize(string name, int x, int y, int direction)
    {
        this.name = name;   
        this.x = x;
        this.y = y;
        this.direction = direction;
    }
    public void Print()
    {
        Console.WriteLine("The name is: "+name);
        Console.WriteLine("The x position is: "+x);
        Console.WriteLine("The y position is: "+ y);
        Console.WriteLine("the direction is: "+ ToString(direction));
    }
    private string ToString(int direction)
    {
        string[] names = {"North", "East", "South", "West", "Left", "Right"};
        return names[direction];
    }
    public void Move()
    {
        if(this.direction == North)
        {
            y++;
        }
        else if (this.direction == South) {
            y--;
        }
        else if(this.direction == East) {
            x++;
        }
        else if (this.direction == West) {
            x--;
         }
        x = (x + Size) % Size;
        y = (y + Size) % Size;
    }
    public void Turn(int to)
    {
        direction = to;
    }
    public bool At(int x, int y)
    {
        if (this.x == x && this.y == y)
            return true;
        else
            return false;
    }
    public void Step()
    {
        int choice=2;
        choice += random.Next(4);
        //Console.WriteLine(choice);
        if (choice == Left)
            Turn((direction + 3) % 4);
        else if (choice == Right)
            Turn((direction + 1) % 4); 
        else
            Move();
    }

}
class World
{
    static void Main(string[] args)
    {
        Robot robot = new Robot();
        robot.Initialize("chitti", 0, 0, Robot.North);

        robot.Print();


        robot.Move();
        robot.Print();


        robot.Turn(Robot.Right);
        robot.Print();

        for (int i = 0; i < 5; i++)
        {
            robot.Step();
            robot.Print();
        }
        int goalx = 5;
        int goaly = 5;
        while(!robot.At(goalx, goaly))
        {
            robot.Step();
            robot.Print();
        }
         
        Console.WriteLine(robot.At(5, 5));
    }
}