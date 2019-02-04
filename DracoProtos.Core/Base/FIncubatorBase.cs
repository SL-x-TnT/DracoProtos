using System;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FIncubatorBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.eggId = (string)stream.ReadDynamicObject();
			this.incubatorId = stream.ReadUtfString();
			this.itemType = (ItemType?)stream.ReadDynamicObject();
			this.roostBuildingId = (string)stream.ReadDynamicObject();
			this.slotIndex = stream.ReadInt32();
			this.usagesLeft = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.eggId);
			stream.WriteUtfString(this.incubatorId);
			stream.WriteDynamicObject(this.itemType);
			stream.WriteDynamicObject(this.roostBuildingId);
			stream.WriteInt32(this.slotIndex);
			stream.WriteInt32(this.usagesLeft);
		}

		public string eggId;

		public int usagesLeft;

		public string incubatorId;

		public string roostBuildingId;

		public int slotIndex;

		public ItemType? itemType;
	}
}
