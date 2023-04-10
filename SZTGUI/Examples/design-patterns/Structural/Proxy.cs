namespace DesignPatterns
{
    public interface ISubject
    {
        void Request();
    }

    class RealSubject : ISubject
    {
        public void Request()
        {
            System.Console.WriteLine("RealSubject: Handling Request.");
        }
    }

    class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        public void Request()
        {
            if (CheckAccess())
            {
                _realSubject.Request();

                LogAccess();
            }
        }

        public bool CheckAccess()
        {
            System.Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void LogAccess()
        {
            System.Console.WriteLine("Proxy: Logging the time of request.");
        }
    }

    public class ClientProxy
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}