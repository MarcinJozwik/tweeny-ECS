using UnityEngine;

namespace TweenyPlugin
{
    public class TFade : Tween
    {
        private readonly float startAlpha;
        private readonly float endAlpha;
        private readonly Material material;

        private float alpha;

        public TFade(Material material, float startAlpha, float endAlpha, float duration, Ease ease) : base(duration, ease)
        {
            this.startAlpha = startAlpha;
            this.endAlpha = endAlpha;
            this.material = material;
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            
            alpha = startAlpha + EaseValue * (endAlpha - startAlpha);
            material.color = new Color(material.color.r, material.color.g, material.color.b, alpha);
        }
    }
}