namespace DesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        Structural();
    }

    static void Structural()
    {
        System.Console.WriteLine("Structural");

        System.Console.WriteLine("\n[-] Facade");
        Facade();

        System.Console.WriteLine("\n[-] Proxy");
        Proxy();

        System.Console.WriteLine("\n[-] Flyweight");
        System.Console.WriteLine("\n + On the fly property");
        FlyweightOnTheFlyProperty();

        System.Console.WriteLine("\n + Shared object across instances");
        FlyweightSharedObject();

        System.Console.WriteLine("\n + Reuse object");
        ReuseObject();
    }

    static void Facade()
    {
        Subsystem1 subsystem1 = new Subsystem1();
        Subsystem2 subsystem2 = new Subsystem2();
        Facade facade = new Facade(subsystem1, subsystem2);
        ClientFacade.ClientCode(facade);
    }

    static void Proxy()
    {
        ClientProxy clientProxy = new ClientProxy();

        System.Console.WriteLine("Client: Executing the client code with a real subject:");
        RealSubject realSubject = new RealSubject();
        clientProxy.ClientCode(realSubject);

        System.Console.WriteLine();

        System.Console.WriteLine("Client: Executing the same client code with a proxy:");
        Proxy proxy = new Proxy(realSubject);
        clientProxy.ClientCode(proxy);
    }

    static void FlyweightOnTheFlyProperty()
    {
        OnTheFlyProperty onTheFlyProperty = new OnTheFlyProperty();
        foreach (var item in onTheFlyProperty.GetEverySecondLetter)
        {
            System.Console.WriteLine(item);
        }
    }

    static void FlyweightSharedObject()
    {
        SharedObject sharedObject = new SharedObject();
        sharedObject.Name = "Name #1";
        sharedObject.Description = "Description #1";
        System.Console.WriteLine($"sharedObject: {sharedObject.IsLearning}");

        SharedObject sharedObject2 = new SharedObject();
        sharedObject2.Name = "Name #2";
        sharedObject2.Description = "Description #2";
        System.Console.WriteLine($"sharedObject2: {sharedObject2.IsLearning}");
    }

    static void ReuseObject()
    {
        ReusableObject.AdditionalData additionalData = new ReusableObject.AdditionalData();
        additionalData.Age = 10;
        System.Console.WriteLine($"additionalData on initializing: {additionalData.Age}");

        ReusableObject reusableObject = new ReusableObject();
        reusableObject.Reuse(additionalData); // Like for example recalculating the age with the same object
        System.Console.WriteLine($"additionalData after reuse: {additionalData.Age}");
    }
}