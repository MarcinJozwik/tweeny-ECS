using System.Collections.Generic;
using Unity;
using UnityEngine;

public class TweenyInstantiator : MonoBehaviour
{
    public int Count = 5000;
    public List<GameObject> Cubes = new List<GameObject>();
    public TweenyObject[] TweenyObjects;
    
    void Start()
    {
        TweenyObjects = new TweenyObject[Count * Cubes.Count];
        for (int i = 0; i < Count; i++)
        {
            int cubesCount = Cubes.Count;
            for (var j = 0; j < cubesCount; j++)
            {
                var cube = Cubes[j];
                var newCube = Instantiate(cube, transform);
                TweenyObjects[i * cubesCount + j] = newCube.GetComponent<TweenyObject>();
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
            int count = TweenyObjects.Length;
            for (var i = 0; i < count; i++)
            {
                TweenyObjects[i].Tween();
            }
        }
    }
}
