interface IPromoteable
{
    void Promote();
}
interface IGoodStudent
{
    void Promote();
}
abstract class Employee
{
    protected string name;
    protected double salary;
    protected Employee(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }
    public virtual void Print()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Salary: {0}", salary);
    }
  
}
class Programmer: Employee, IPromoteable
{
    protected double averageOT;
    public Programmer(string name, double salary, double averageOT)
        :base(name, salary)
    {
        this.averageOT = averageOT;
    }
    public override void Print()
    {
        Console.WriteLine("programmer");
        base.Print();
        Console.WriteLine("Average OT:{0}", averageOT);
    }
    public void Promote()
    {
        salary *= 1.1;
        Console.WriteLine($"Programmer received {salary} after promotion");
    }
}
class Manager: Employee,IPromoteable,IGoodStudent
{
    protected string secretaryName;
    public Manager(string name, double salary, string secretaryName)
           :base(name, salary)
    {
        this.secretaryName = secretaryName;
    }
    public override void Print()
    {
        Console.WriteLine("Manager");
        base.Print();
        Console.WriteLine("Secretary: {0}", secretaryName);
    }
     void IPromoteable.Promote()
    {
        salary *= 1.5;
        Console.WriteLine($"Manager received {salary} after promotion");
    }
    void IGoodStudent.Promote()
    {
        Console.WriteLine($"{name} is a good student commanding to be delight");
    }
}
class Intern: Employee
{
    protected int lengthOfInternship;
    public Intern(string name, double salary, int lengthOfInternship)
        :base(name, salary)
    {
        this.lengthOfInternship = lengthOfInternship;
    }
    public override void Print()
    {
        Console.WriteLine("Intern");
        base.Print();
        Console.WriteLine("Length of internship(months): {0}", lengthOfInternship);

    }
}
class InterfaceTest
{
    static void Main()
    {
        Employee[] emp = new Employee[]
        {
            new Programmer("Bharath",12000, 3),
            new Manager("Harsha", 1500, "alexa"),
            new Intern("chintu", 9000, 6)
        };
        Console.WriteLine("Looping through the array");
        foreach(var employee in emp)
        {
            employee.Print();
            Console.WriteLine();
        }
        foreach(var employee in emp)
        {
            if (employee is Manager m)
            {
                ((IGoodStudent)m).Promote();
                ((IPromoteable)m).Promote();
            }

        }
        foreach (var employee in emp)
        {
            employee.Print();
            Console.WriteLine();
        }
    }
}