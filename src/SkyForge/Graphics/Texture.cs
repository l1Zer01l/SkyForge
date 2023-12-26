using SkyForge.Math;
using System;

namespace SkyForge.Render
{

    public class Texture
    {
        private char[] m_sprite;
        private Vector2 m_size;
        private ConsoleColor[] m_color;
        public char[] sprite => m_sprite;
        public ConsoleColor[] color => m_color;
        public Vector2 size => m_size;

        public Texture(Vector2 size)
        {
            m_size = size;
            m_sprite = new char[(int)size.x * (int)size.y];
            m_color = new ConsoleColor[(int)size.x * (int)size.y];
        }

        public void SetTexture(char[] sprite)
        {
            m_sprite = sprite;
        }

    }

}