using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FDailyQuestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.count = stream.ReadInt32();
			this.elementType = (ElementType?)stream.ReadDynamicObject();
			this.id = (string)stream.ReadDynamicObject();
			this.nextDailyQuestIn = stream.ReadInt32();
			this.pitstopPath = stream.ReadDynamicList<IdAndCoords>(true);
			this.progress = stream.ReadInt32();
			this.type = (QuestType?)stream.ReadDynamicObject();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.count);
			stream.WriteDynamicObject(this.elementType);
			stream.WriteDynamicObject(this.id);
			stream.WriteInt32(this.nextDailyQuestIn);
			stream.WriteDynamicCollection(this.pitstopPath, true);
			stream.WriteInt32(this.progress);
			stream.WriteDynamicObject(this.type);
		}

		public string id;

		public QuestType? type;

		public int count;

		public int progress;

		public int nextDailyQuestIn;

		public ElementType? elementType;

		public List<IdAndCoords> pitstopPath;
	}
}
