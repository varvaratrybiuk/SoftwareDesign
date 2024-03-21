namespace Singleton
{
    public sealed class Authenticator
    {
        private static Authenticator? _instance;
        private static object _obj = new object();
        private Authenticator() {
            Console.WriteLine("Initialization Authenticator");
        }
        public static Authenticator GetInstance()
        {
            if(_instance == null)
            {
                lock (_obj)
                {
                    if (_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }
    }
}
