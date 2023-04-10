namespace DesignPatterns
{
    public class Facade
    {
        protected Subsystem1 _subsystem1;
        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.Operation1;
            result += this._subsystem2.Operation1;
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.OperationN;
            result += this._subsystem2.OperationZ;

            return result;
        }
    }

    public class Subsystem1
    {
        public string Operation1 => "Subsystem1: Ready!\n";
        public string OperationN => "Subsystem1: Go!\n";
    }

    public class Subsystem2
    {
        public string Operation1 => "Subsystem2: Get ready!\n";
        public string OperationZ => "Subsystem2: Fire!\n";
    }

    class Client
    {
        public static void ClientCode(Facade facade)
        {
            System.Console.Write(facade.Operation());
        }
    }
}