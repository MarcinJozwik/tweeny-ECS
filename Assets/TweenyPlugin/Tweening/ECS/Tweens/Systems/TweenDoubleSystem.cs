using Entitas;

public class TweenDoubleSystem : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> doubleGroup;

    public TweenDoubleSystem(Contexts contexts) 
    {
        this.contexts = contexts;
        this.doubleGroup = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Double, TweenyMatcher.Ease));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.doubleGroup.GetEntities();
		int count = entities.Length;

		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];
			entity.@double.Value.Value = entity.@double.StartValue + entity.ease.Value * (entity.@double.EndValue - entity.@double.StartValue);
		}
	}
}