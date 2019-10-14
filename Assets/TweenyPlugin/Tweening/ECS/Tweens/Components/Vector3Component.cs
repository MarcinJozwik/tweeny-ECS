using Entitas;
using TweenyPlugin.Utilities;
using UnityEngine;

[Tweeny]
public class Vector3Component : IComponent
{
    public TweenyVector3 Value;
    public Vector3 StartValue;
    public Vector3 EndValue;
}
