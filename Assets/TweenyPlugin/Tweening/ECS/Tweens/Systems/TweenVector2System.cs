using Entitas;

public class TweenVector2System : IExecuteSystem  
{
	private readonly Contexts contexts;
    private readonly IGroup<TweenyEntity> vector2Group;

    public TweenVector2System(Contexts contexts) 
    {
        this.contexts = contexts;
        this.vector2Group = this.contexts.tweeny.GetGroup(TweenyMatcher.AllOf(TweenyMatcher.Tweening, TweenyMatcher.Vector2, TweenyMatcher.Ease));
    }

	public void Execute()
	{
		TweenyEntity[] entities = this.vector2Group.GetEntities();
		int count = entities.Length;

		for (int i = 0; i < count; i++)
		{
			TweenyEntity entity = entities[i];
			entity.vector2.Value.Value = entity.vector2.StartValue + entity.ease.Value * (entity.vector2.EndValue - entity.vector2.StartValue);
		}
	}
}