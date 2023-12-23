using SkyForge;
using SkyForge.Input;
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
        private TestComponent testComponent = new TestComponent();

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
            context.Draw(texture, testComponent.position);
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
        private TestComponent m_testComponent;
        public override void Start()
        {
            m_testComponent = GetComponent<TestComponent>();
            Console.WriteLine("Start Component");
        }

        public override void Update()
        {
            if (InputSystem.IsKeyPressed(KeyCode.A))
                m_testComponent.position.x += 1;


        }
    }

    public class TestComponent : BaseComponent
    {
        public Vector2 position = new Vector2();
        public float speed = 2;
        public override void Start()
        {
            position = new Vector2(1, 1);
        }

        public override void Update()
        {
            
        }
    }

}