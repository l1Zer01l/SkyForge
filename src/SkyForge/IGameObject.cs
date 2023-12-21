
namespace SkyForge
{

    public interface IGameObject
    {
        T GetComponent<T>() where T : BaseComponent;

        void Start();
        void Update();
        void Destroy();
        void OnDestroy();

    }

}