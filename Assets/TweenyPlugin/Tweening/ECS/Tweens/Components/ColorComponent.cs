using Entitas;
using UnityEngine;

[Tweeny]
public class ColorComponent : IComponent
{
    public Color CurrentValue;
    public Color StartValue;
    public Color EndValue;
}
