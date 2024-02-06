using System;

class Stock
{
    string name;
    double price;
    int shares;
    void Initialize(stirng name, double price, int shares)
    {
        this.name = name;
        this.price = price;
        this.shares = shares;
    }
    void Buy(int shares)
    {
        this.shares += shares;
    }
    void Sell(int shares)
    {
        this.shares -= shares;
    }
    void SetPrice(double Price)
    {
        this.price += Price;
    }
    double Value()
    {
        return price * shares;
    }
    static void main(string[] args)
    {
        Stock ibm = new Stock();
        Stock sun = new Stock();
        ibm.Initialize("Ibm", 1200, 100);
        Console.ReadLine(ibm.Value());

    }
 
}
