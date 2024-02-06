class Asset
{
    private string name;
    private double cost;
    private int yearPurchased;
    public Asset(string name, double cost, int yearPurchased)
    {
        this.name = name;
        this.cost = cost;
        this.yearPurchased = yearPurchased;
        //Console.WriteLine("Assest success");
    }
    public double AmortizedCost(int currentYear)
    {
        return cost / (currentYear - yearPurchased);
    }
    public double ComputeValue()
    {
        return cost;
    }
    public void print()
    {
        Console.WriteLine("Assest: " + name + " " + cost + " " + yearPurchased);
    }

}
class Stock: Asset
{
   
    private string symbol;
    private int shares;
    private double price;
    public Stock(string name, double cost, int yearPurchased, string symbol, int shares, double price)
        :base(name, cost, yearPurchased)
    {
        this.symbol = symbol;
        this.shares = shares;
        this.price = price;
        //Console.WriteLine("Asset success");
    }
    public new double ComputeValue()
    {
        return price * shares;
    }
    public new void print()
    {
        base.print();
        Console.WriteLine("Stock" + symbol + " " + shares + " " + price);
    }
}
class Property:Asset
{
    private double assessment;
    private string address;

    public Property(string name, double cost, int yearPurchased, double assessment, string Address)
        :base(name, cost, yearPurchased)
    {
        this.assessment = assessment;
        this.address = Address;
       // Console.WriteLine("Property success");
    }
    public new double ComputeValue()
    {
        return assessment;
    }
    public new void print()
    {
        base.print();
        Console.WriteLine("property: " + assessment + " " + address);
    }
}
class Building: Property
{
    private string address;
    public Building(string name, double cost, int yearPurchased, double assessment, string address)
        :base(name, cost, yearPurchased, assessment, address)
    {
        this.address = address;
        //Console.WriteLine("Building success");
    }
    public new void print()
    {
        base.print();
        Console.WriteLine("Building:" + address);
    }
}
class Art:Property
{
    private String artist;
    private int yearCreated;
    public Art(string name, double cost, int yearPurchased, double assessment, string address, string artist, int yearCreated)
       : base(name, cost, yearPurchased, assessment, address)
    {
            this.artist = artist;
            this.yearCreated = yearCreated;
       // Console.WriteLine("Building success");
    }
    public new void print()
    {
        base.print();
        Console.WriteLine("Art" + artist + " " + yearCreated);
    }
}
class Invest
{
    static void Main()
    {
        //Console.WriteLine("Amortized costs per year:");
        Stock microsoft = new Stock("Microscoft", 8000, 1994, "MSFT", 200, 56);
        Building beachHouse = new Building("Beach House", 9000, 1964, 35000, "123 seashore ave, Malibu, CA");
        Art nighthawks = new Art("Nighthawks", 850, 1955, 7500,"vatican city",  "edward hopper", 1942);
        Console.WriteLine("Success");
        Console.WriteLine("Amortized costs per year:");
        Console.WriteLine("Microsoft stock ${0}", microsoft.AmortizedCost(2002));
        Console.WriteLine("Beach house ${0}", beachHouse.AmortizedCost(2002));
        Console.WriteLine("Nighthawks ${0}", nighthawks.AmortizedCost(2002));

        Console.WriteLine();
        Console.WriteLine("Compute Methods");
        Console.WriteLine("Valuations:");
        Console.WriteLine("Microsoft stock ${0}", microsoft.ComputeValue());
        Console.WriteLine("Beach House ${0}", beachHouse.ComputeValue());
        Console.WriteLine("Nighthawks ${0}", nighthawks.ComputeValue());


        Console.WriteLine("Mandatory to print");
        Console.WriteLine();
        microsoft.print();
        beachHouse.print();
        nighthawks.print();
    }
}