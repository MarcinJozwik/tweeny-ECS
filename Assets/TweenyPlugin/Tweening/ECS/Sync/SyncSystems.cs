using TweenyPlugin.Tweening.ECS.Sync.Systems;

namespace TweenyPlugin.Tweening.ECS.Sync
{
    public class SyncSystems : Feature
    {
        public SyncSystems(Contexts contexts)
            : base("Sync Systems")
        {
            this.Add(new SyncTransformPositionSystem(contexts));
            this.Add(new SyncTransformScaleSystem(contexts));
            this.Add(new SyncMaterialFadeSystem(contexts));
            
            this.Add(new SyncCameraOrthographicSizeSystem(contexts));
            this.Add(new SyncCameraFieldOfViewSystem(contexts));
            
            this.Add(new SyncTweenyFloatSystem(contexts));
            this.Add(new SyncTweenyDoubleSystem(contexts));
            this.Add(new SyncTweenyVector2System(contexts));
            this.Add(new SyncTweenyVector3System(contexts));
        }
    }
}