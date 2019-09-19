using System.Collections.Generic;
using UnityEngine;

namespace Unity
{
    public class EntitasInstantatior : MonoBehaviour
    {
        public int Count = 100;
        public List<GameObject> Cubes = new List<GameObject>();
        public EntitasObject[] EntitasObjects;

        private bool isPlaying;
        void Start()
        {
            EntitasObjects = new EntitasObject[Count * Cubes.Count];
            
            for (int i = 0; i < Count; i++)
            {
                int cubesCount = Cubes.Count;
                for (var j = 0; j < cubesCount; j++)
                {
                    var cube = Cubes[j];
                    var newCube = Instantiate(cube, transform);
                    EntitasObjects[i * cubesCount + j] = newCube.GetComponent<EntitasObject>();
                }
            }
            
            for (var j = 0; j < Cubes.Count; j++)
            {
                Destroy(Cubes[j]);
            }
            
            Cubes.Clear();
        }
            
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
        }
    }
}