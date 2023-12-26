using SkyForge.Logs;
using SkyForge.Window;
using System;

namespace SkyForge.Render
{
    public static class GraphicsSystem
    {
        public static WindowConsole window { get; private set; }
        public static GraphicsContext graphicsContext { get; private set; }
        
        public static void Init(int width, int height, char backGround, 
            ConsoleColor backGroundColor = ConsoleColor.Black, ConsoleColor foreingColor = ConsoleColor.White)
        {
            window = new WindowConsole(width, height);
            graphicsContext = new GraphicsContext(window);
            graphicsContext.backGroundFill = backGround;
            graphicsContext.backGroundColor = backGroundColor;
            graphicsContext.foreingColor = foreingColor;
            
            Log.CoreLogger.Logging("Initialized Graphics System", LogLevel.Info);
            
        }

        public static void Begin()
        {
            graphicsContext.Clear();      
        }

        public static void End()
        {
            graphicsContext.RenderBuffer();
        }

    }

}