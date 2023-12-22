namespace SkyForge.Input
{
    public class InputKey
    {
        private InputState m_currentState;
        private char m_currentKeyPressed;

        public InputState state => m_currentState;
        public char keyPressed => m_currentKeyPressed;

        public InputKey(InputState state, char key)
        {
            m_currentState = state;
            m_currentKeyPressed = key;
        }
    }
}