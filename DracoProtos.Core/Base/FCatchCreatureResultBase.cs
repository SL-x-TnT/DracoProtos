using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FCatchCreatureResultBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.avaUpdate = (FAvaUpdate)stream.ReadStaticObject(typeof(FAvaUpdate));
			this.ballType = (ItemType?)stream.ReadDynamicObject();
			this.candies = stream.ReadInt32();
			this.candyType = (CreatureType?)stream.ReadDynamicObject();
			this.catchChance = stream.ReadFloat();
			this.catching = (FCatchingConfig)stream.ReadDynamicObject();
			this.caught = stream.ReadBoolean();
			this.creadex = (FCreadex)stream.ReadDynamicObject();
			this.creature = (CreatureType?)stream.ReadDynamicObject();
			this.dust = stream.ReadInt32();
			this.expAccurate = stream.ReadInt32();
			this.expCreatureExisting = stream.ReadInt32();
			this.expCreatureNew = stream.ReadInt32();
			this.expSpin = stream.ReadInt32();
			this.levelUpLoot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.loot = (FLoot)stream.ReadStaticObject(typeof(FLoot));
			this.runAway = stream.ReadBoolean();
			this.streakDust = stream.ReadInt32();
			this.userCreature = (FUserCreature)stream.ReadDynamicObject();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticObject(this.avaUpdate);
			stream.WriteDynamicObject(this.ballType);
			stream.WriteInt32(this.candies);
			stream.WriteDynamicObject(this.candyType);
			stream.WriteFloat(this.catchChance);
			stream.WriteDynamicObject(this.catching);
			stream.WriteBoolean(this.caught);
			stream.WriteDynamicObject(this.creadex);
			stream.WriteDynamicObject(this.creature);
			stream.WriteInt32(this.dust);
			stream.WriteInt32(this.expAccurate);
			stream.WriteInt32(this.expCreatureExisting);
			stream.WriteInt32(this.expCreatureNew);
			stream.WriteInt32(this.expSpin);
			stream.WriteStaticObject(this.levelUpLoot);
			stream.WriteStaticObject(this.loot);
			stream.WriteBoolean(this.runAway);
			stream.WriteInt32(this.streakDust);
			stream.WriteDynamicObject(this.userCreature);
		}

		public bool caught;

		public bool runAway;

		public int dust;

		public CreatureType? candyType;

		public int candies;

		public int expCreatureNew;

		public int expCreatureExisting;

		public int expAccurate;

		public int expSpin;

		public int streakDust;

		public float catchChance;

		public CreatureType? creature;

		public ItemType? ballType;

		public FCatchingConfig catching;

		public FAvaUpdate avaUpdate;

		public FLoot loot;

		public FLoot levelUpLoot;

		public FUserCreature userCreature;

		public FCreadex creadex;
	}
}
