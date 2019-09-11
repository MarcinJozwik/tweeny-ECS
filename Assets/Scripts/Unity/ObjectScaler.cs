﻿using TweenyPlugin;
using UnityEngine;

namespace Unity
{
    public class ObjectScaler : MonoBehaviour
    {
        public int Mode;
        public float Duration = 5f;
    
        private float timer = 0f;
        private float easeValue;

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
                easeValue = Tweeny.GetValue(timer, 0, Duration, TweenyTest.GetEase(Mode));
                transform.localScale = startScale + (distance * easeValue);
            }

            if (timer >= Duration)
            {
                started = false;
            }
        }
    }
}
