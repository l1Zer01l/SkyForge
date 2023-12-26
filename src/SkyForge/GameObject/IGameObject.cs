
using SkyForge.Input;
using SkyForge.Render;

namespace SkyForge
{

    public interface IGameObject
    {
        T GetComponent<T>() where T : BaseComponent;

        void Draw(GraphicsContext context);
        void Start();
        void OnEvent(KeyCode key);
        void Update();
        void Destroy();
        void OnDestroy();

    }

}