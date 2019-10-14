using Entitas;
using TweenyPlugin.Utilities;

[Tweeny]
public class DoubleComponent : IComponent
{
    public TweenyDouble Value;
    public double StartValue;
    public double EndValue;
}
