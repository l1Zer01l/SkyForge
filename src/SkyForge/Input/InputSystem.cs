using SkyForge.Logs;
using System;
using System.Threading;

namespace SkyForge.Input
{

    public static class InputSystem
    {
        private static InputKey m_currentKey = new InputKey(InputState.None, '\0');
        public static void Init()
        {
            ThreadStart threadStart = new ThreadStart(UpdateInputSystem);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Log.CoreLogger.Logging("Initialized Input System", LogLevel.Info);
        }


        private static void UpdateInputSystem()
        {
            while (true)
            {        
                var key = Console.ReadKey(true).KeyChar;
                if (m_currentKey.keyPressed == key)
                {
                    m_currentKey = new InputKey(InputState.Repeat, key);
                }
                else
                {
                    m_currentKey = new InputKey(InputState.Press, key);
                }
                Thread.Sleep(6);
                m_currentKey = new InputKey(InputState.None, key);
            }
        }

        public static bool IsKeyPressed(KeyCode keyCode)
        {
            return (m_currentKey.state == InputState.Press || m_currentKey.state == InputState.Repeat) && GetKeyCode(m_currentKey.keyPressed) == keyCode;
        }

        private static KeyCode GetKeyCode(char key)
        {
            if (key == 'a' || key == 'A')
                return KeyCode.A;
            return KeyCode.None;
        }
    }
}