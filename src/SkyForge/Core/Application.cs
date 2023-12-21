using System;

namespace SkyForge.Core
{

    public class Application
    {
        private static Application m_instance;
        private bool m_running = true;

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

            }
        }

    }

}