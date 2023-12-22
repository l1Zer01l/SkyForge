using SkyForge;
using SkyForge.Input;
using SkyForge.Math;
using SkyForge.Render;
using System;

namespace ExampleGame
{

    public class Player : GameObject
    {
        private char[] texture = new char[] 
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

        public override void Draw(GraphicsContext context)
        {
            context.Draw(texture, new Vector2(6, 8), new Vector2(0, 0));
        }

        public override void Start()
        {
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
            if (InputSystem.IsKeyPressed(KeyCode.A))
                Console.WriteLine("Pressed A");
                    
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