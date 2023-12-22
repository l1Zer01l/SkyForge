
namespace SkyForge
{

    public interface IComponent
    {
        IGameObject gameObject { get; }
        void InitGameObject(IGameObject gameObject);
        void Start();
        void Update();
        void OnDestory();

    }

}