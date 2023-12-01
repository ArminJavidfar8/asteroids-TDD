using UnityEngine;

namespace Management.Abstraction
{
    public interface IBullet
    {
        void SetPosition(Vector3 position);
        void MoveTo(Vector3 direction);
    }
}