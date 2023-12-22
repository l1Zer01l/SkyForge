using SkyForge.Logs;
using System;

namespace SkyForge.Render
{
    public static class GraphicsSystem
    {
        public static GraphicsContext graphicsContext { get; private set; }
        public static int width { get; set; }
        public static int height { get; set; }
        public static char backGroundFill { get; set; }

        public static void Init()
        {
            width = 120;
            height = 28;
            backGroundFill = ' ';
            graphicsContext = new GraphicsContext(width, height);
            Log.CoreLogger.Logging("Initialized Graphics System", LogLevel.Info);
            
        }

        public static void Begin()
        {
            Reset();
            Console.SetCursorPosition(0, 0);
        }

        public static void End()
        {
            Console.Write(graphicsContext.buffer);
        }

        private static void Reset()
        {
            graphicsContext.Clear(backGroundFill);
        }



    }

}