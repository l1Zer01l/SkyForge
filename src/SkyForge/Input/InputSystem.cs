using SkyForge.Logs;
using System;
using System.Threading;

namespace SkyForge.Input
{
    public delegate void KeyPressed(KeyCode keyCode);
    public static class InputSystem
    {
        public static KeyPressed OnKeyPressedEvent;
        public static void Init()
        {
            ThreadStart threadStart = new ThreadStart(UpdateInputSystem);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Log.CoreLogger.Logging("Initialized Input System", LogLevel.Info);
        }


        private static void UpdateInputSystem()
        {
            var key = Console.ReadKey(true).KeyChar;
            OnKeyPressedEvent?.Invoke(GetKeyCode(key));
            UpdateInputSystem();
        }

        private static KeyCode GetKeyCode(char key)
        {
            if (key == 'a' || key == 'A')
                return KeyCode.A;
            if (key == 's' || key == 'S')
                return KeyCode.S;
            if (key == 'd' || key == 'D')
                return KeyCode.D;
            if (key == 'w' || key == 'W')
                return KeyCode.W;
            if (key == 'q' || key == 'Q')
                return KeyCode.Q;
            if (key == 'e' || key == 'E')
                return KeyCode.E;
            if (key == 'f' || key == 'F')
                return KeyCode.F;
            if (key == 'r' || key == 'R')
                return KeyCode.R;
            if (key == 't' || key == 'T')
                return KeyCode.T;
            if (key == 'g' || key == 'G')
                return KeyCode.G;
            return KeyCode.None;
        }
    }
}