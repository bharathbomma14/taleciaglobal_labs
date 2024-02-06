class Student
{
    string name;
    int age;
    int stdId;

    static int nextId = 1;
    public Student(string name, int age)
    {
        this.name = name;   
        this.age = age;
        this.stdId = nextId;
        nextId= nextId + 1;
    }
    static void Main(string[] args)
    {
        Student s1 = new Student("Bharath", 21);
        Student s2 = new Student("Revant", 22);
        Console.WriteLine(s1.name + " " + s1.age + " " + s1.stdId);
        Console.WriteLine(nextId);
        Console.WriteLine(s2.name + " " + s2.age + " " + s2.stdId);
    }
}