using SkyForge;
using SkyForge.Math;
using SkyForge.Render;
using System;

namespace ExampleGame
{

    public class Player : GameObject
    {
        private char[] sprite = new char[] 
        { 
            ' ', ' ', '^', '^', ' ', ' ',
            ' ', ' ', '0', '0', ' ', ' ',
            ' ', '/', '-', '-', '\\', ' ',
            ' ', '\\', '#', '#', '/', ' ',
            ' ', ' ', '#', '#', ' ', ' ',
            ' ', ' ', '|', '|', ' ', ' ',
            ' ', ' ', '|', '|', ' ', ' ',
            ' ', ' ', '=', '=', ' ', ' ',
        };

        private ConsoleColor[] color = new ConsoleColor[] 
        {
            ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta, ConsoleColor.White, ConsoleColor.White, ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta,
            ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta, ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta,
            ConsoleColor.DarkMagenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.White, ConsoleColor.Red, ConsoleColor.DarkMagenta,
            ConsoleColor.DarkMagenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.White, ConsoleColor.Red, ConsoleColor.DarkMagenta,
            ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta, ConsoleColor.White, ConsoleColor.White, ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta,
            ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta, ConsoleColor.White, ConsoleColor.White, ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta,
            ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta, ConsoleColor.Cyan, ConsoleColor.Cyan, ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta,
            ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta, ConsoleColor.Cyan, ConsoleColor.Cyan, ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta,

        };
        
        private Texture texture = new Texture(new Vector2(6, 8));
        
        public override void Draw(GraphicsContext context)
        {
            context.Draw(texture, new Vector2(0, 0));
        }

        public override void Start()
        {           
            texture.SetTexture(sprite, color);
            AddComponent(new PlayerMovement(), this);
            AddComponent(new TestComponent(), this);
            base.Start();
        }
  
    }

    public class PlayerMovement : BaseComponent
    {
        
        public override void Start()
        {

            Console.WriteLine("Start Component");
        }

        public override void Update()
        {
                   
        }
    }

    public class TestComponent : BaseComponent
    {
        public float speed = 2;
        public override void Start()
        {
            
        }

        public override void Update()
        {
            
        }
    }

}