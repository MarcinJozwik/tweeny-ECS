using Entitas;
using TweenyPlugin.Utilities;
using UnityEngine;

[Tweeny]
public class Vector2Component : IComponent
{
    public TweenyVector2 Value;
    public Vector2 StartValue;
    public Vector2 EndValue;
}
