using SkyForge.Math;

namespace SkyForge
{

    public interface IGameObject
    {
        Vector2 position { get; set; }

        void Start();
        void Update();
        void Destroy();
        void OnDestroy();

    }

}