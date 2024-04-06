namespace Adapter
{
    public class FileLogger : FileWriter
    {
        private Logger logger;

        public FileLogger(Logger logger, string filepath) : base(filepath)
        {
            this.logger = logger;
        }
        public override void Write(string message)
        {
            LoggerMethods(base.Write, message);
          
           
        }
        public override void WriteLine(string message)
        {
            LoggerMethods(base.WriteLine, message);
        }

        private void LoggerMethods(Action<string> methods, string message)
        {
            Random random = new Random();
            switch (random.Next(1, 4))
            {
                case 1:
                    logger.Log();
                    break;
                case 2:
                    logger.Warn();
                    break;
                case 3:
                    logger.Error();
                    break;
            }
            methods(message);
            Console.ResetColor();
        }

       
    }
}
