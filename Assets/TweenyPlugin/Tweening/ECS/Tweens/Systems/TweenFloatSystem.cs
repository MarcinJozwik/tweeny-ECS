using Entitas;

public class TweenFloatSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> floatGroup;

    public TweenFloatSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.floatGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Float, TweenyMatcher.Ease));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.floatGroup.GetEntities();
		int count = entities.Length;

		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];
			entity.@float.Value.Value = entity.@float.StartValue + entity.ease.Value * (entity.@float.EndValue - entity.@float.StartValue);
		}
	}
}