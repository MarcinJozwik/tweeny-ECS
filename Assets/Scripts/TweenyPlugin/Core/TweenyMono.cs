using UnityEngine;

namespace TweenyPlugin
{
    public class TweenyMono : MonoBehaviour
    {
        private void Update()
        {
            TweenyCollector.Update(Time.deltaTime);
        }
    }
}