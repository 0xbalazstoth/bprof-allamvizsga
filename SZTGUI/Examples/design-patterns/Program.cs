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
        System.Console.WriteLine("[-] Facade");
        Facade();
    }

    static void Facade()
    {
        Subsystem1 subsystem1 = new Subsystem1();
        Subsystem2 subsystem2 = new Subsystem2();
        Facade facade = new Facade(subsystem1, subsystem2);
        Client.ClientCode(facade);
    }
}