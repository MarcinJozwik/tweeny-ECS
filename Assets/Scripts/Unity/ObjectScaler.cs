using EaseMethods;
using UnityEngine;

namespace Unity
{
    public class ObjectScaler : MonoBehaviour
    {
        public AGetValue EaseMethod;
        public float Duration = 5f;
    
        private float timer = 0f;
        private float easeValue;
        private float timeStep;

        private Vector3 startScale;
        private Vector3 endScale;
        private Vector3 distance;

        private bool started = false;

        private void Start()
        {
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
                timer = Mathf.MoveTowards(timer, Duration, Time.deltaTime);
                timeStep = timer / Duration;
                easeValue = EaseMethod.GetValue(timeStep);
                transform.localScale = startScale + (distance * easeValue);
            }

            if (timer >= Duration)
            {
                started = false;
            }
        }
    }
}
