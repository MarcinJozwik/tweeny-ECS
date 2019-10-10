using UnityEngine;

namespace Unity
{
    public class EntitasInstantatior : MonoBehaviour
    {
        public EntitasObject[] EntitasObjects;
        private bool isPlaying;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int count = EntitasObjects.Length;

                if (!isPlaying)
                {
                    for (var i = 0; i < count; i++)
                    {
                        EntitasObjects[i].Tween();
                    }
                }
                else
                {
                    for (var i = 0; i < count; i++)
                    {
                        EntitasObjects[i].Stop();
                    }
                }
                
                isPlaying = !isPlaying;
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                int count = EntitasObjects.Length;
                for (var i = 0; i < count; i++)
                {
                    EntitasObjects[i].Reset();
                }
            }
        }
    }
}