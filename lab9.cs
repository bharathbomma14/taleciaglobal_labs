abstract class Pet
{
    public string Name;
    protected Pet(string Name)
    {
        this.Name = Name;
    }
    public virtual void Move(bool fast)
    {
        if(fast)
        {
            Console.WriteLine($"{Name} is running");
        }
        else
        {
            Console.WriteLine($"{Name} is Walking");
        }
    }
    public abstract void Speak();
}
class Cat : Pet
{
    public bool IsPicky;
    public Cat(string name, bool isPicky)
        :base(name)
    {
        this.IsPicky=isPicky;
    }
    public override void Move(bool fast)
    {
        if(fast)
        {
            Console.WriteLine("cat pounce when moving fast");
        }
        else
        {
            Console.WriteLine("cat slink when moving slow.");
        }
    }
    public override void Speak()
    {
        Console.WriteLine($"{Name} say meows");
    }
}
class Dog:Pet
{
    public bool CanFetch;
    public Dog(string name, bool canFetch)
        :base(name)
    {
        this.CanFetch=canFetch;
    }
    public override void Move(bool fast)
    {
        if(fast)
        {
            Console.WriteLine("dogs bound when moving fast");
        }
        else
        {
            Console.WriteLine("string When moving slow");
        }
    }
    public override void Speak()
    {
        Console.WriteLine($"{Name} barks");
    }
}
class Household
{ 
    static void Exercise(Pet p, int duration)
    {
        p.Speak();
        for(int i=0; i<duration; i++)
        {
            p.Move(true);
        }
    }
    static void Exercise(Pet[] pets)
    {
        foreach(Pet p in pets)
        {
            p.Move(true);
            p.Speak();
        }
    }
    static void Play(Pet p)
    {
        if(p is Cat)
        {
            Cat c = (Cat)p ;
            if(c.IsPicky)
            {
                Console.WriteLine($"{p.Name} is picky to play");
            }
            else
            {
                Console.WriteLine($"{p.Name} is playing with cats");
            }

        }
        else if(p is Dog)
        {
            Dog d = (Dog)p;
            if(d.CanFetch)
            {
                Console.WriteLine($"{d.Name} is playing fetching");
            }
            else
            {
                Console.WriteLine($"{d.Name} can't fetch or should n't played with");
            }
        }
 
    }
    static void Main()
    {
        Cat cats = new Cat("ceaser", true);
        Dog dogs = new Dog("tommy", false);
        Exercise(cats, 3);
        Exercise(dogs, 4);

        Pet[] pets = new Pet[]
        {
             new Cat("killer", true),
             new Dog("Mansion", false)
        };
        Exercise(pets);

        Play(cats);
        Play(dogs);
    }
}
