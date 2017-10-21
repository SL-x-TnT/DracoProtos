using System;
using System.Collections.Generic;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FWeeklyQuestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.allOpen = stream.ReadBoolean();
			this.completed = stream.ReadBoolean();
			this.currentFragment = stream.ReadInt32();
			this.digFragments = stream.ReadStaticList<int>(true);
			this.nextWeeklyQuestIn = stream.ReadInt32();
			this.openFragments = stream.ReadStaticMap<int, sbyte[]>(true, true);
			this.sideFragmentNumber = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.allOpen);
			stream.WriteBoolean(this.completed);
			stream.WriteInt32(this.currentFragment);
			stream.WriteStaticCollection(this.digFragments, true);
			stream.WriteInt32(this.nextWeeklyQuestIn);
			stream.WriteStaticMap(this.openFragments, true, true);
			stream.WriteInt32(this.sideFragmentNumber);
		}

		public int sideFragmentNumber;

		public Dictionary<int, sbyte[]> openFragments;

		public List<int> digFragments;

		public int currentFragment;

		public bool allOpen;

		public bool completed;

		public int nextWeeklyQuestIn;
	}
}
