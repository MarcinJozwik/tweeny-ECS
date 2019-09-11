using TweenyPlugin;
using UnityEngine;

namespace Unity
{
    public class ObjectRotator : MonoBehaviour
    {
        public int Mode;
        public float Duration = 5f;
    
        private float timer = 0f;
        private float easeValue;

        private Vector3 startRotation;
        private Vector3 rotation;
        private float distance;

        private bool started = false;

        private void Start()
        {
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
                timer = Mathf.MoveTowards(timer, Duration, Time.deltaTime);
                easeValue = Tweeny.GetValue(timer, 0, Duration, TweenyTest.GetEase(Mode));
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
