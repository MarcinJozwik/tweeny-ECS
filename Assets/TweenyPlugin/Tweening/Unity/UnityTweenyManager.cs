using TweenyPlugin.Tweening.ECS;
using UnityEngine;

namespace TweenyPlugin.Tweening.Unity
{
    public class UnityTweenyManager : MonoBehaviour
    {
        private TweenyManager tweenyManager;

        private void Start()
        {
            tweenyManager = new TweenyManager();
            tweenyManager.Init();
        }
        
        private void Update()
        {
            tweenyManager.OnUpdate();
        }
    }
}