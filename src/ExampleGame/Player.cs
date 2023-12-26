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
        
        private Texture texture = new Texture(new Vector2(6, 8));
        
        public override void Draw(GraphicsContext context)
        {
            context.Draw(texture, testComponent.position);
        }

        public override void Start()
        {           
            texture.SetTexture(sprite);
            AddComponent(new PlayerMovement(), this);
            AddComponent(testComponent, this);
            base.Start();
        }
  
    }

    public class PlayerMovement : BaseComponent
    {
        private TestComponent m_testComponent;
        private int count = 1;
        public override void Start()
        {
            m_testComponent = GetComponent<TestComponent>();
            Console.WriteLine("Start Component");
        }

        public override void Update()
        {

            if (InputSystem.IsKeyPressed(KeyCode.A))
                m_testComponent.position.x -= 1;
            if (InputSystem.IsKeyPressed(KeyCode.D))
                m_testComponent.position.x += 1;
            if (InputSystem.IsKeyPressed(KeyCode.S))
                m_testComponent.position.y += 1;
            if (InputSystem.IsKeyPressed(KeyCode.W))
                m_testComponent.position.y -= 1;

        }
    }

    public class TestComponent : BaseComponent
    {
        public Vector2 position = new Vector2();
        public float speed = 2;

        public override void Start()
        {
            position = new Vector2(6, 6);
        }

        public override void Update()
        {
            
        }
    }

}