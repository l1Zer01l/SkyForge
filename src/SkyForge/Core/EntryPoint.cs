using SkyForge.Logs;
using SkyForge.Input;
using SkyForge.Render;


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
            GraphicsSystem.Init();
            Log.CoreLogger.Logging("Initialized SkyForge", LogLevel.Info);
            
        }

        public static int Main()
        {
            Application.Run();
            return 0;
        }

    }

}