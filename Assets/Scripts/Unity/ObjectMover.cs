using TweenyPlugin;
using UnityEngine;

namespace Unity
{
    public class ObjectMover : MonoBehaviour
    {
        private int mode;
        private float duration;
    
        private float timer = 0f;
        private float easeValue;

        private Vector3 startPosition;
        private Vector3 endPosition;
        private Vector3 direction;
        private float distance;

        private bool started = false;

        private void Start()
        {
            duration = GetComponentInParent<Duration>().DurationTime;
            mode = GetComponent<Mode>().EaseMode;
            startPosition = transform.position;
            endPosition = startPosition + transform.forward * 40f;
            direction = (endPosition - startPosition).normalized;
            distance = Vector3.Distance(endPosition, startPosition);
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
                transform.position = startPosition + (easeValue * distance * direction);
            }

            if (timer >= duration)
            {
                started = false;
            }
        }
    }
}
