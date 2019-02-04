using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FCatchingCreatureBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.aggressive = stream.ReadBoolean();
			this.ancient = stream.ReadBoolean();
			this.candyType = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.catching = (FCatchingConfig)stream.ReadDynamicObject();
			this.cp = stream.ReadInt32();
			this.element = (ElementType)stream.ReadEnum(typeof(ElementType));
			this.feedFoodType = (ItemType?)stream.ReadDynamicObject();
			this.feedLeftTime = stream.ReadInt32();
			this.id = stream.ReadUtfString();
			this.isCreatureStorageFull = stream.ReadBoolean();
			this.items = stream.ReadStaticMap<ItemType, int>(true, true);
			this.name = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.quality = stream.ReadFloat();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.aggressive);
			stream.WriteBoolean(this.ancient);
			stream.WriteEnum(this.candyType);
			stream.WriteDynamicObject(this.catching);
			stream.WriteInt32(this.cp);
			stream.WriteEnum(this.element);
			stream.WriteDynamicObject(this.feedFoodType);
			stream.WriteInt32(this.feedLeftTime);
			stream.WriteUtfString(this.id);
			stream.WriteBoolean(this.isCreatureStorageFull);
			stream.WriteStaticMap(this.items, true, true);
			stream.WriteEnum(this.name);
			stream.WriteFloat(this.quality);
		}

		public string id;

		public int cp;

		public CreatureType name;

		public float quality;

		public CreatureType candyType;

		public ElementType element;

		public bool isCreatureStorageFull;

		public FCatchingConfig catching;

		public Dictionary<ItemType, int> items;

		public int feedLeftTime;

		public ItemType? feedFoodType;

		public bool aggressive;

		public bool ancient;
	}
}
