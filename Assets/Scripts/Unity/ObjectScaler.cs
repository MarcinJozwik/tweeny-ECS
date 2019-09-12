using TweenyPlugin;
using UnityEngine;

namespace Unity
{
    public class ObjectScaler : MonoBehaviour
    {
        private int mode;
        private float duration;
    
        private float timer = 0f;
        private float easeValue;

        private Vector3 startScale;
        private Vector3 endScale;
        private Vector3 distance;

        private bool started = false;

        private void Start()
        {
            duration = GetComponentInParent<Duration>().DurationTime;
            mode = GetComponent<Mode>().EaseMode;
            startScale = transform.localScale;
            endScale = startScale * 2f;
            distance = endScale - startScale;
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
                timer = Mathf.MoveTowards(timer, duration, Time.deltaTime);
                easeValue = Tweeny.GetValue(timer, 0, duration, TweenyTest.GetEase(mode));
                transform.localScale = startScale + (distance * easeValue);
            }

            if (timer >= duration)
            {
                started = false;
            }
        }
    }
}
