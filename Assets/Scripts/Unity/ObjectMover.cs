using EaseMethods;
using UnityEngine;

namespace Unity
{
    public class ObjectMover : MonoBehaviour
    {
        public AGetValue EaseMethod;
        public float Duration = 5f;
    
        private float timer = 0f;
        private float easeValue;
        private float timeStep;

        private Vector3 startPosition;
        private Vector3 endPosition;
        private Vector3 direction;
        private float distance;

        private bool started = false;

        private void Start()
        {
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
                timer = Mathf.MoveTowards(timer, Duration, Time.deltaTime);
                timeStep = timer / Duration;
                easeValue = EaseMethod.GetValue(timeStep);
                transform.position = startPosition + (easeValue * distance * direction);
            }

            if (timer >= Duration)
            {
                started = false;
            }
        }
    }
}
