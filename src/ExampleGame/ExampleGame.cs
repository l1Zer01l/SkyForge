using SkyForge.Core;
using SkyForge.Logs;

namespace ExampleGame
{

    public class ExampleGame : Application
    {

        public ExampleGame()
        {
            Log.ClientLogger.Logging("Initialize Game", LogLevel.Info);
            AddGameObject(new Player());
        }

    }

}