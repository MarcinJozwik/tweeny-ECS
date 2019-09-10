using System.Collections.Generic;
using EaseMethods;
using UnityEngine;

namespace Unity
{
    public class GetEase : MonoBehaviour
    {
        public List<AGetValue> EaseMethods = new List<AGetValue>();

        public AGetValue Get()
        {
            return EaseMethods[Random.Range(0, EaseMethods.Count)];
        }
    }
}
