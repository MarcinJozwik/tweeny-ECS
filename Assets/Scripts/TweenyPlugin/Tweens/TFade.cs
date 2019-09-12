using UnityEngine;

namespace TweenyPlugin
{
    public class TFade : Tween
    {
        private readonly Ease ease;
        private readonly float startAlpha;
        private readonly float endAlpha;
        private readonly Material material;

        private float alpha;
        private float easeValue = 0f;

        public TFade(Material material, float startAlpha, float endAlpha, float duration, Ease ease) : base(duration)
        {
            this.ease = ease;
            this.startAlpha = startAlpha;
            this.endAlpha = endAlpha;
            this.material = material;
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            easeValue = Tweeny.GetValue(Timer, 0, Duration, ease);
            
            alpha = startAlpha + easeValue * (endAlpha - startAlpha);
            material.color = new Color(material.color.r, material.color.g, material.color.b, alpha);
        }
    }
}