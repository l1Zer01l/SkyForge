
using SkyForge.Input;

namespace SkyForge
{
    public abstract class BaseComponent : IComponent
    {
        public IGameObject gameObject { get; private set; }

        public void InitGameObject(IGameObject gameObject)
        {
            if (this.gameObject == null)
            {
                this.gameObject = gameObject;
            }
        }

        public T GetComponent<T>() where T : BaseComponent
        {
            return gameObject.GetComponent<T>();
        }

        public virtual void OnDestory() { }

        public abstract void Start();

        public abstract void Update();

        public abstract void OnEvent(KeyCode key);
       
    }
}