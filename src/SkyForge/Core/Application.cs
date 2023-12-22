using System;
using System.Collections.Generic;

namespace SkyForge.Core
{
    public class Application
    {
        private static Application m_instance;
        private bool m_running = true;
        private List<IGameObject> m_gameObjects = new List<IGameObject>();

        public Application GetApplication() => m_instance;

        public Application()
        {
            if (m_instance == null)
            {
                m_instance = this;
            }
            Console.WriteLine("Welcome to SkyForge!");
        }

        public void Run()
        {
            while (m_running)
            {

                UpdateGameObject();
            }
        }

        public void AddGameObject(IGameObject gameObject)
        {
            gameObject.Start();
            m_gameObjects.Add(gameObject);
        }

        public void RemoveGameObject(IGameObject gameObject)
        {
            m_gameObjects.Remove(gameObject);
            gameObject.Destroy();
        }

        private void UpdateGameObject()
        {
            foreach (var gameObject in m_gameObjects)
            {
                gameObject.Update();
            }
        }

    }

}