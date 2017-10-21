namespace DracoProtos.Command
{
    public class FDailyQuest : FDailyQuestBase
	{
		public bool IsEmpty()
		{
			return this.id == null;
		}
	}
}
