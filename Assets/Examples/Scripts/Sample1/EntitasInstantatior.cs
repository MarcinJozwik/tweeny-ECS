#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;

namespace Unity
{
    public class EntitasInstantatior : MonoBehaviour
    {
        [Range(0, 0.99999f)] 
        public float GoToStep; 
        
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
                        EntitasObjects[i].Play();
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
            
            if (Input.GetKeyDown(KeyCode.G))
            {
                int count = EntitasObjects.Length;
                for (var i = 0; i < count; i++)
                {
                    EntitasObjects[i].GoTo(GoToStep);
                    Debug.Log("Go to " + GoToStep);
                    isPlaying = false;
                }
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                int count = EntitasObjects.Length;
                for (var i = 0; i < count; i++)
                {
                    EntitasObjects[i].Reset();
                    isPlaying = false;
                }
            }
        }
    }
    
    #if UNITY_EDITOR
    [CustomEditor(typeof(EntitasInstantatior))]
    public class EntitasInstantatiorEditor : Editor
    {
        private EntitasInstantatior instantatior;
        
        private void OnEnable()
        {
            instantatior = target as EntitasInstantatior;
        }

        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            base.OnInspectorGUI();
            if (EditorGUI.EndChangeCheck() && Application.isPlaying)
            {
                int count = instantatior.EntitasObjects.Length;
                for (var i = 0; i < count; i++)
                {
                    instantatior.EntitasObjects[i].GoTo(instantatior.GoToStep);
                }
            }
        }
    }
    #endif
}