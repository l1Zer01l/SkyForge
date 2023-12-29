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
            var key = Console.ReadKey(true).Key;
            OnKeyPressedEvent?.Invoke(GetKeyCode(key));
            UpdateInputSystem();
        }

        private static KeyCode GetKeyCode(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.S:
                    return KeyCode.S;
                case ConsoleKey.A:
                    return KeyCode.A;
                case ConsoleKey.D:
                    return KeyCode.D;
                case ConsoleKey.W:
                    return KeyCode.W;
                case ConsoleKey.E:
                    return KeyCode.E;
                case ConsoleKey.F:
                    return KeyCode.F;
                case ConsoleKey.R:
                    return KeyCode.R;
                case ConsoleKey.T:
                    return KeyCode.T;
                case ConsoleKey.G:
                    return KeyCode.G;
                default:
                    return KeyCode.None;
            }
        }
    }
}