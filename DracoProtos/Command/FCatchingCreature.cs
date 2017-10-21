namespace DracoProtos.Command
{
    public class FCatchingCreature : FCatchingCreatureBase
	{
		public void SetNotFed()
		{
			this.feedLeftTime = 0;
			this.feedFoodType = null;
		}
	}
}
