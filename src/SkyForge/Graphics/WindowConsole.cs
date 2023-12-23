using SkyForge.Math;
using SkyForge.Render;
using System;

namespace SkyForge.Window
{

    public class WindowConsole
    {
        private int m_windowWidth;
        private int m_windowHeight;

        public int windowWidth => m_windowWidth;
        public int windowHeight => m_windowHeight;

        public WindowConsole(int windowWidth, int windowHeight)
        {
            m_windowWidth = windowWidth;
            m_windowHeight = windowHeight;
            Console.WindowHeight = windowHeight + 1;
            Console.WindowWidth = windowWidth;
            Console.BufferWidth = windowWidth;
            Console.BufferHeight = windowHeight + 1;
            Console.CursorVisible = false;
        }


        public void Draw(char[] buffer, ConsoleColor[] color)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.ForegroundColor = color[i];
                Console.Write(buffer[i]);   
            }
        }

    }

}