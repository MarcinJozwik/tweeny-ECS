using Entitas;
using UnityEngine;

[Tweeny]
public class QuaternionComponent : IComponent
{
    public Quaternion CurrentValue;
    public Quaternion StartValue;
    public Quaternion EndValue;
}
