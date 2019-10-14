using Entitas;

public class TweenCameraFieldOfViewSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> cameraGroup;

    public TweenCameraFieldOfViewSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.cameraGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Camera, TweenyMatcher.CameraFieldOfView, TweenyMatcher.Ease));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.cameraGroup.GetEntities();
		int count = entities.Length;

		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];
			entity.camera.Camera.fieldOfView = entity.cameraFieldOfView.StartFov + entity.ease.Value * (entity.cameraFieldOfView.EndFov - entity.cameraFieldOfView.StartFov);
		}
	}
}