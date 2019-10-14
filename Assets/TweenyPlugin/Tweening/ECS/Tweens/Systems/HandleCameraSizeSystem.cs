using Entitas;

public class HandleCameraSizeSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> cameraGroup;

    public HandleCameraSizeSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.cameraGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Camera, TweenyMatcher.CameraSize, TweenyMatcher.Ease));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.cameraGroup.GetEntities();
		int count = entities.Length;

		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];
			entity.camera.Camera.orthographicSize = entity.cameraSize.StartSize + entity.ease.Value * (entity.cameraSize.EndSize - entity.cameraSize.StartSize);
		}
	}
}