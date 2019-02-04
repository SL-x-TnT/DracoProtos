using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
    public class FWeeklyQuest : FWeeklyQuestBase
	{
		public bool isActive()
		{
			return this.openFragments.Count > 0;
		}
	}
}
