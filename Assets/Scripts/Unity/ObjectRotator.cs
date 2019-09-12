using TweenyPlugin;
using UnityEngine;

namespace Unity
{
    public class ObjectRotator : MonoBehaviour
    {
        private int mode;
        private float duration;
    
        private float timer = 0f;
        private float easeValue;

        private Vector3 startRotation;
        private Vector3 rotation;
        private float distance;

        private bool started = false;

        private void Start()
        {
            duration = GetComponentInParent<Duration>().DurationTime;
            mode = GetComponent<Mode>().EaseMode;
            startRotation = transform.rotation.eulerAngles;
            distance = 360;
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
                rotation = startRotation + new Vector3(0,distance * easeValue,0);
                transform.rotation = Quaternion.Euler(rotation);
            }

            if (timer >= duration)
            {
                started = false;
            }
        }
    }
}
