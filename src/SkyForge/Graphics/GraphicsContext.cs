using SkyForge.Math;

namespace SkyForge.Render
{
    public class GraphicsContext
    {
        public char[] buffer { get; }
        public int width { get; }
        public int height { get; }

        public GraphicsContext(int width, int height)
        {
            this.width = width;
            this.height = height;
            buffer = new char[width * height];
        }

        public void Clear(char backGround)
        {
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = backGround;
        }

        public void Draw(char[] texture, Vector2 size, Vector2 position)
        {
            for (int x = 0; x < size.x; x++)
            {
                for (int y = 0; y < size.y; y++)
                {
                    buffer[x + (int)position.x + (y + (int)position.y) * width] = texture[x + y * (int)size.x];
                }
            }
        }
    }
}