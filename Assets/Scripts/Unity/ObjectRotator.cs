using EaseMethods;
using UnityEngine;

namespace Unity
{
    public class ObjectRotator : MonoBehaviour
    {
        public AGetValue EaseMethod;
        public float Duration = 5f;
    
        private float timer = 0f;
        private float easeValue;
        private float timeStep;

        private Vector3 startRotation;
        private Vector3 endRotation;
        private Vector3 rotation;
        private float direction;
        private float distance;

        private bool started = false;

        private void Start()
        {
            startRotation = transform.rotation.eulerAngles;
            endRotation = startRotation + new Vector3(0,360,0);
            direction = 1f;
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
                timer = Mathf.MoveTowards(timer, Duration, Time.deltaTime);
                timeStep = timer / Duration;
                easeValue = EaseMethod.GetValue(timeStep);
                rotation = startRotation + new Vector3(0,distance * easeValue,0);
                transform.rotation = Quaternion.Euler(rotation);
            }

            if (timer >= Duration)
            {
                started = false;
            }
        }
    }
}
