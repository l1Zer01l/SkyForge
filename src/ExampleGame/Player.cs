using SkyForge;
using SkyForge.Input;
using SkyForge.Math;
using SkyForge.Render;
using System;

namespace ExampleGame
{

    public class Player : GameObject
    {
        private TestComponent testComponent = new TestComponent();
        
        private Texture texture = new Texture(new Vector2(12, 20), @"A:\dev\ñ#\SkyForge\resource\player.png");
        
        public override void Draw(GraphicsContext context)
        {
            context.Draw(texture, testComponent.position);
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
        private int count = 1;

        public override void OnEvent(KeyCode key)
        {
            if (key == KeyCode.A)
                m_testComponent.position.x -= 1;
            if (key == KeyCode.D)
                m_testComponent.position.x += 1;
            if (key == KeyCode.S)
                m_testComponent.position.y += 1;
            if (key == KeyCode.W)
                m_testComponent.position.y -= 1;
        }

        public override void Start()
        {
            m_testComponent = GetComponent<TestComponent>();
            Console.WriteLine("Start Component");
        }

        public override void Update()
        {

        }
    }

    public class TestComponent : BaseComponent
    {
        public Vector2 position = new Vector2();
        public float speed = 2;

        public override void OnEvent(KeyCode key)
        {
            
        }

        public override void Start()
        {
            position = new Vector2(6, 6);
        }

        public override void Update()
        {
            
        }
    }

}