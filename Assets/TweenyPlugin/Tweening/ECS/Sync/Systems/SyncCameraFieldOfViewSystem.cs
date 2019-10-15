using Entitas;

namespace TweenyPlugin.Tweening.ECS.Sync.Systems
{
	public class SyncCameraFieldOfViewSystem : IExecuteSystem  
	{
		private readonly Contexts contexts;
		private readonly IGroup<TweenyEntity> cameraGroup;

		public SyncCameraFieldOfViewSystem(Contexts contexts) 
		{
			this.contexts = contexts;
			this.cameraGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Camera, TweenyMatcher.CameraFieldOfView, TweenyMatcher.Float));
		}

		public void Execute()
		{
			TweenyEntity[] entities = this.cameraGroup.GetEntities();
			int count = entities.Length;

			for (int i = 0; i < count; i++)
			{
				TweenyEntity entity = entities[i];
				entity.camera.Camera.fieldOfView = entity.@float.CurrentValue;
			}
		}
	}
}