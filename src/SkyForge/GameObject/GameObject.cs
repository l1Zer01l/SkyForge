using SkyForge.Input;
using SkyForge.Render;
using System.Collections.Generic;

namespace SkyForge
{

    public abstract class GameObject : IGameObject
    {

        private List<IComponent> m_components = new List<IComponent>();
        public void Destroy()
        {
            OnDestroy();
        }

        public virtual void OnDestroy() { }
        public virtual void Start()
        {
            foreach (var component in m_components)
            {
                component.Start();
            }
        }
        public void Update()
        {
            foreach (var component in m_components)
            {
                component.Update();
            }
        }

        public T GetComponent<T>() where T : BaseComponent
        {
            foreach (var component in m_components)
            {
                if (typeof(T) == component.GetType())
                {
                    return (T)component;
                }
            }
            return null;
        }
        
        public void AddComponent(IComponent component, IGameObject parent)
        {
            component.InitGameObject(parent);
            m_components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            m_components.Remove(component);
            component.OnDestory();
        }

        public abstract void Draw(GraphicsContext context);

        public void OnEvent(KeyCode key)
        {
            foreach (var component in m_components)
            {
                component.OnEvent(key);
            }

        }
    }



}