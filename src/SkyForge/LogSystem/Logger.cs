namespace SkyForge.Logs.Core
{

    public class Logger
    {
        private string name;
        
        public Logger(string name)
        {
            this.name = name;
        }

        public static void Init(bool write, bool tasted = false, string logPath = @".\Log\")
        {
            LoggerImpl.SetLogFile(logPath);
            LoggerImpl.WriteToFile = write;
            LoggerImpl.Tested = tasted;
            LoggerImpl.Init();

        }
        public void Logging(string massage, LogLevel level)
        {
            LoggerImpl.Write($" {name}: {massage}", level);
        }
    }

}