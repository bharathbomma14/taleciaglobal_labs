using System.ComponentModel.DataAnnotations;

class SavingsAccount
{
    private int accountNumber;
    private double balance;
    private double interestEarned;
    private static double interestRate;
    public SavingsAccount(int accountNumber, double balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }
    public int AccountNumber 
    { 
        get 
        {  
            return accountNumber;
        }
    }
    public double Balance
    {
        get
        {
            return balance;
        }
    }
    public bool IsOverdrawn
    {
        get
        {
            if (balance < 0)
                return false;
            else
                return true;
        }
    }
    public double InterestEarned
    {
        set
        {
            interestEarned = value;
        }
        get
        {
            return interestEarned;
        }
    }
    public static double InterestRate
    {
        set
        {
            interestRate = value;
        }
        get
        {
            return interestRate;
        }
    }
    
}
class SavingAccountTest
{
    static void Main()
    {
        SavingsAccount acc = new SavingsAccount(1234, 2000);
        Console.WriteLine(acc.AccountNumber);
        Console.WriteLine(acc.Balance);
        Console.WriteLine(acc.IsOverdrawn);
        acc.InterestEarned = 2000;
        Console.WriteLine(acc.InterestEarned);
        Console.WriteLine();
        SavingsAccount.InterestRate = 2.5;
        Console.WriteLine(SavingsAccount.InterestRate);
    }
}