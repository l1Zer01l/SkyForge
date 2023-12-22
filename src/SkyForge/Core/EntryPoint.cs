using SkyForge.Logs;
using SkyForge.Input;
using System;

namespace SkyForge.Core
{

    public static class EntryPoint
    {
        private static Application m_application = null;

        public static Application Application { get { return m_application; } set { m_application = value; } }

        public static void Init()
        {
            Log.Init();
            InputSystem.Init();
            Log.CoreLogger.Logging("Initialize SkyForge", LogLevel.Info);
            
        }

        public static int Main()
        {
            Application.Run();
            return 0;
        }

    }

}