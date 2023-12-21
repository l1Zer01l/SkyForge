using SkyForge.Math;
using System;

namespace SkyForge
{

    public abstract class GameObject : IGameObject
    {
        public Vector2 position { get; set; }

        public void Destroy()
        {
            OnDestroy();

        }

        public virtual void OnDestroy() { }
        public abstract void Start();
        public abstract void Update();
    }



}