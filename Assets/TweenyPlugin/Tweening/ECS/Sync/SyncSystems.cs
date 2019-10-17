using TweenyPlugin.Tweening.ECS.Sync.Systems;

namespace TweenyPlugin.Tweening.ECS.Sync
{
    public class SyncSystems : Feature
    {
        public SyncSystems(Contexts contexts)
            : base("Sync Systems")
        {
            this.Add(new SyncTransformPositionSystem(contexts));
            this.Add(new SyncTransformRotationSystem(contexts));
            this.Add(new SyncTransformScaleSystem(contexts));
            this.Add(new SyncMaterialColorSystem(contexts));
            this.Add(new SyncMaterialFadeSystem(contexts));
            
            this.Add(new SyncCameraOrthographicSizeSystem(contexts));
            this.Add(new SyncCameraFieldOfViewSystem(contexts));
            
            this.Add(new SyncTweenyFloatSystem(contexts));
            this.Add(new SyncTweenyDoubleSystem(contexts));
            this.Add(new SyncTweenyVector2System(contexts));
            this.Add(new SyncTweenyVector3System(contexts));
            this.Add(new SyncTweenyColorSystem(contexts));
            this.Add(new SyncTweenyQuaternionSystem(contexts));
            
            this.Add(new SyncLightIntensitySystem(contexts));
            this.Add(new SyncLightRangeSystem(contexts));
            this.Add(new SyncLightSpotAngleSystem(contexts));
            this.Add(new SyncLightColorSystem(contexts));
            this.Add(new SyncLightFadeSystem(contexts));
            
            this.Add(new SyncLineRendererStartColorSystem(contexts));
            this.Add(new SyncLineRendererEndColorSystem(contexts));
            this.Add(new SyncLineRendererStartWidthSystem(contexts));
            this.Add(new SyncLineRendererEndWidthSystem(contexts));
        }
    }
}