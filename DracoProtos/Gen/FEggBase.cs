using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FEggBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.eggType = (ItemType)stream.ReadEnum(typeof(ItemType));
			this.id = stream.ReadUtfString();
			this.incubatorId = (string)stream.ReadDynamicObject();
			this.isEggForRoost = stream.ReadBoolean();
			this.isHatching = stream.ReadBoolean();
			this.passedDistance = stream.ReadFloat();
			this.totalDistance = stream.ReadFloat();
			this.totalIncubationTime = stream.ReadInt64();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteEnum(this.eggType);
			stream.WriteUtfString(this.id);
			stream.WriteDynamicObject(this.incubatorId);
			stream.WriteBoolean(this.isEggForRoost);
			stream.WriteBoolean(this.isHatching);
			stream.WriteFloat(this.passedDistance);
			stream.WriteFloat(this.totalDistance);
			stream.WriteInt64(this.totalIncubationTime);
		}

		public string id;

		public float totalDistance;

		public float passedDistance;

		public bool isHatching;

		public string incubatorId;

		public bool isEggForRoost;

		public long totalIncubationTime;

		public ItemType eggType;
	}
}
