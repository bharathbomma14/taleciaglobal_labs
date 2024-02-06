using System;
using System.Reflection;

delegate void MessageHandler(string message);
class Publisher
{
    public MessageHandler MH;
    public void Dispatch(string message)
    {
        if(MH!=null)
        {
            MH.Invoke(message);
        }
    }
}
class Subscriber
{
    public void CallMe(string message)
    {
        Console.WriteLine($"callMe message is {message}");
    }
    public void MeToo(string message)
    {
        Console.WriteLine($"MeToo message is {message}");
    }
    public static void AndMe(string message)
    {
        Console.WriteLine($"AndMe message is {message}");
    }
}
class Driver
{
    static void Main()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();
        MessageHandler subscribedelegate = new MessageHandler(subscriber.CallMe);
        publisher.MH += subscribedelegate;
        publisher.Dispatch("Hello! Subscribe.");

        publisher.MH += new MessageHandler(subscriber.MeToo);
        publisher.MH += new MessageHandler(Subscriber.AndMe);

        publisher.Dispatch("All methods are called");

        publisher.MH = new MessageHandler(subscriber.MeToo);
        publisher.MH("directly deploying the delegates");

        

    }
}