using SkyForge;
using SkyForge.Math;
using System;

namespace ExampleGame
{

    public class Player : GameObject
    {
        public override void Start()
        {
            position = new Vector2(1, 1);
            Console.WriteLine("Start");
        }

        public override void Update()
        {
            Console.WriteLine("Update");
        }
    }


}