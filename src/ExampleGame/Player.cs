using SkyForge;
using SkyForge.Input;
using System;

namespace ExampleGame
{

    public class Player : GameObject
    {
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