using SkyForge.Math;
using System;

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