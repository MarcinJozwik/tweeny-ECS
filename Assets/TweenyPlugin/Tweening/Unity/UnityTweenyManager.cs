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
            tweenyManager.InitServices(new UnityTimeService());
        }
        
        private void Update()
        {
            tweenyManager.OnUpdate();
        }
    }
}