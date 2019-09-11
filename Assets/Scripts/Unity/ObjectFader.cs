using UnityEngine;

namespace Unity
{
    public class ObjectFader : MonoBehaviour
    {
        public int Mode;
        public float Duration = 5f;
    
        private float timer = 0f;
        private float easeValue;

        private Material material;
        private float startAlpha;
        private float endAlpha;
        private float alpha;
        
        private bool started = false;

        private void Start()
        {
            material = GetComponent<Renderer>().material;
            
            startAlpha = 0;
            endAlpha = material.color.a;
        }
        
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                timer = 0f;
                started = true;
            }

            if (started)
            {
                timer = Mathf.MoveTowards(timer, Duration, Time.deltaTime);
                easeValue = TweenyPlugin.Tweeny.GetValue(timer, 0, Duration, TweenyTest.GetEase(Mode));
                alpha = startAlpha + easeValue * (endAlpha - startAlpha);
                material.color = new Color(material.color.r, material.color.g, material.color.b, alpha);
            }

            if (timer >= Duration)
            {
                started = false;
            }
        }
    }
}