using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using UnityEngine;

namespace TweenyPlugin.Core
{
    public static partial class Extensions
    {
        public static Tween TMove(this Transform transform, Vector3 startPosition,
            Vector3 endPosition, float duration, Ease ease)
        {
            return Tweeny.TMove(transform, startPosition, endPosition, duration, ease);
        }

        public static Tween TScale(this Transform transform, Vector3 startScale, Vector3 endScale,
            float duration, Ease ease)
        {
            return Tweeny.TScale(transform, startScale, endScale, duration, ease);
        }

        public static Tween TFade(this Material material, float startAlpha, float endAlpha,
            float duration, Ease ease)
        {
            return Tweeny.TFade(material, startAlpha, endAlpha, duration, ease);
        }
    }
}