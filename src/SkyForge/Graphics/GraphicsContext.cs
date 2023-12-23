using SkyForge.Math;
using SkyForge.Window;
using System;

namespace SkyForge.Render
{
    public class GraphicsContext
    {
        public WindowConsole window { get; }
        public char[] buffer { get; }
        public ConsoleColor[] bufferColor { get; }
        
        public char backGroundFill { get; set; }
        public ConsoleColor backGroundColor { get; set; }

        public GraphicsContext(WindowConsole window)
        {
            this.window = window;
            buffer = new char[window.windowWidth * window.windowHeight];
            bufferColor = new ConsoleColor[buffer.Length];
            
        }

        public void Clear()
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = backGroundFill;
                bufferColor[i] = backGroundColor;
            }         
        }    
        public void Draw(Texture texture, Vector2 position)
        {
            for (int x = 0; x < texture.size.x; x++)
            {
                for (int y = 0; y < texture.size.y; y++)
                {
                    
                     buffer[x + (int)position.x + (y + (int)position.y) * window.windowWidth] = texture.sprite[x + y * (int)texture.size.x];
                     bufferColor[x + (int)position.x + (y + (int)position.y) * window.windowWidth] = texture.color[x + y * (int)texture.size.x];
                    
                }
            }
        }


        public void RenderBuffer()
        {
            window.Draw(buffer, bufferColor);
        }
    }
}