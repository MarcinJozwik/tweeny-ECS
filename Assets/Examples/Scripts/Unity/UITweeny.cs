using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using TweenyPlugin.Tweening.Link;
using UnityEngine;
using UnityEngine.UI;

namespace Unity
{
    public class UITweeny : MonoBehaviour
    {
        public RectTransform RectTransform;
        public Vector2 StartPosition;
        public Vector2 EndPosition;

        [Space] public RawImage Image;
        public Texture2D StartImage;
        public Texture2D EndImage;

        private void Start()
        {
            RectTransform.TMove(StartPosition, EndPosition, 4f, EaseMode.SmoothStart3,
                new TweenSet()
                    .OnStart(() => { ChangeSprite(StartImage); })
                    .OnComplete(() => { ChangeSprite(EndImage); })
                    ).Play();
        }

        private void ChangeSprite(Texture2D texture2D)
        {
            Image.texture = texture2D;
        }
    }
}