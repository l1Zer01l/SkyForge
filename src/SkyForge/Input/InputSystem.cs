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
            Console.WriteLine("Init InputSystem");
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
                Thread.Sleep(3);
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