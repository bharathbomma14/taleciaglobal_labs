using System.ComponentModel;

class Hive
{
    public int[] Cells;
    public const int Empty = 0;
    public const int Full = 1;
    public Hive(int size)
    {
        Cells= new int[size];
        for(int i=0; i<size; i++)
        {
            Cells[i] = Empty;
        }
    }
}
class Bee
{
    private Random random = new Random();
    private const int Searching=0;
    public const int Gathering=1;
    public const int Returning=2;
    public const int Depositing=3;
    private int Cur_state;
    

    private Hive hive;
    public Bee(Hive hive)
    {
        this.hive = hive;
        Cur_state = Searching;
    }
    public void Work()
    {
        switch(Cur_state)
        {
            case Searching:
                {
                    Console.Write("S");
                    if (random.Next(5) == 0)
                        Cur_state = Gathering;
                    break;
                }
            case Gathering:
                {
                    Console.Write("G");
                    Cur_state = Returning;
                    break;
                }
            case Returning:
                {
                    Console.Write("R");
                    Cur_state = Depositing;
                    break;
                }
            case Depositing:
                {
                    Console.Write("D");
                    int i = random.Next(hive.Cells.Length);
                    if (hive.Cells[i] == Hive.Empty)
                    {
                        hive.Cells[i] = Hive.Full;
                        Cur_state = Searching;
                    }
                    break;
                }
        }
    }
}
class Keeper
{
    public int Collect(Hive hive)
    {
        int cellcount = 0;
        for(int i=0; i<hive.Cells.Length; i++)
        {
            if (hive.Cells[i] == Hive.Full)
            {
                cellcount++;
            }
            hive.Cells[i] = Hive.Empty;
        }
        return cellcount;
    }
    public void Run()
    {
        Hive hive = new Hive(20);
        Bee[] bees = new Bee[5];
        for(int i=0; i<5; i++)
        {
            bees[i] = new Bee(hive);
        }
        while(true)
        {
            for(int i=0; i<20; i++)
            {
                for(int j=0; j<bees.Length; j++)
                {
                    bees[j].Work();
                }
            }
            Console.WriteLine("Collect{0}", Collect(hive));
        }
    }
}
class Driver
{
    static void Main()
    {
        Keeper keeper = new Keeper();
        keeper.Run();
    }
}