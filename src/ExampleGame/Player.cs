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
        private TestComponent testComponent = new TestComponent();
        public override void Draw(GraphicsContext context)
        {
            context.Draw(texture, new Vector2(6, 8), testComponent.position);
        }

        public override void Start()
        {
            AddComponent(new PlayerMovement(), this);
            AddComponent(testComponent, this);
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