﻿using UnityEngine;

namespace TweenyPlugin
{
    public static partial class Extensions
    {
        public static void TMove(this Transform transform, Vector3 startPosition,
            Vector3 endPosition, float duration, Ease ease)
        {
            Tweeny.Add(new TMove(transform, startPosition, endPosition, duration, ease));
        }

        public static void TScale(this Transform transform, Vector3 startScale, Vector3 endScale,
            float duration, Ease ease)
        {
            Tweeny.Add(new TScale(transform, startScale, endScale, duration, ease));
        }

        public static void TFade(this Material material, float startAlpha, float endAlpha, float duration, Ease ease)
        {
            Tweeny.Add(new TFade(material, startAlpha, endAlpha, duration, ease));
        }
    }
}