using SkyForge.Logs;
using SkyForge.Math;
using System;
using System.Drawing;

namespace SkyForge.Render
{

    public class Texture
    {
        private const string POLITRA = "  .:-^=*%x&#@@";
        private char[] m_sprite;
        private Vector2 m_size;

        private ConsoleColor[] m_color;
        public char[] sprite => m_sprite;
        public ConsoleColor[] color => m_color;
        public Vector2 size => m_size;

        public Texture(Vector2 size, string path)
        {
            m_size = size;
            m_sprite = new char[(int)size.x * (int)size.y];
            m_color = new ConsoleColor[(int)size.x * (int)size.y];
            InitImage(path);
        }

        public void SetTexture(char[] sprite)
        {
            m_sprite = sprite;
        }

        private void InitImage(string path)
        {
            try
            {
                Bitmap bitmap = new Bitmap(path, true);
                for (int x = 0; x < m_size.x; x++)
                {
                    for (int y = 0; y < m_size.y; y++)
                    {
                        Color pixelColor = bitmap.GetPixel(x, y);
                        var agvColor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        m_sprite[x + y * (int)m_size.x] = POLITRA[Math.Math.Lerp(POLITRA.Length - 1, 255, agvColor)];

                    }
                }
            }
            catch (ArgumentException)
            {
                Log.CoreLogger.Logging(" Can't read image. Check the path to the image file.", LogLevel.Error);
            }
        }
    }

}