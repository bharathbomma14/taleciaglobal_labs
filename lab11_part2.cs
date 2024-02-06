
class OverdrawnException:ApplicationException
{
    public double Balance { get; }
    public OverdrawnException(string s, double aa)
        :base(s)
    {
        Balance = aa;
    }
}
class SavingAccount
{
    private int accountNumber;
    private double balance;
    public SavingAccount(int accountNumber, double balance)
    { 
        this.accountNumber = accountNumber;
        this.balance = balance;
    }
    public void Withdraw(double amt)
    {
        if(amt>balance)
        {
            throw new OverdrawnException("withdraw amt exceeds balace", balance);
        }
        this.balance -= amt;
    }
}
class SavingAccountTest
{
    static void Main()
    {
        try
        {
            SavingAccount acc = new SavingAccount(12345, 2000);
            acc.Withdraw(98000);
        }
        catch (OverdrawnException ode)
        {
           Console.WriteLine(ode.Message);
            Console.WriteLine(ode.StackTrace);
        }
        
    }
}