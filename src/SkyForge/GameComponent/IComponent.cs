
using SkyForge.Input;

namespace SkyForge
{

    public interface IComponent
    {
        IGameObject gameObject { get; }
        void InitGameObject(IGameObject gameObject);
        void Start();
        void OnEvent(KeyCode key);
        void Update();
        void OnDestory();

    }

}