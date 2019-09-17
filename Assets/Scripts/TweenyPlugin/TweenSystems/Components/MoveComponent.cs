using Entitas;
using UnityEngine;

[Tweeny]
public class MoveComponent : IComponent
{
    public Vector3 StartPosition;
    public Vector3 Direction;
    public float Distance;
}
