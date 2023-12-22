using SkyForge.Logs.Core;

namespace SkyForge.Logs
{

    public static class Log
    {
        private static Logger m_coreLogger;
        private static Logger m_clientLogger;

        public static Logger CoreLogger => m_coreLogger;
        public static Logger ClientLogger => m_clientLogger;

        public static void Init()
        {
            m_coreLogger = new Logger("SkyForge");
            m_clientLogger = new Logger("Client");
            Logger.Init(true);
            m_coreLogger.Logging("Initialized Log System", LogLevel.Info);
        }

    }


}