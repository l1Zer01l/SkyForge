using SkyForge.Core;

namespace ExampleGame
{

    public static class Game
    {

        public static void Main(string[] args)
        {
            EntryPoint.Init();
            EntryPoint.Application = new ExampleGame();
            EntryPoint.Main();

        }

    }


}