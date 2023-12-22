
using SkyForge.Render;

namespace SkyForge
{

    public interface IGameObject
    {
        T GetComponent<T>() where T : BaseComponent;

        void Draw(GraphicsContext context);
        void Start();
        void Update();
        void Destroy();
        void OnDestroy();

    }

}