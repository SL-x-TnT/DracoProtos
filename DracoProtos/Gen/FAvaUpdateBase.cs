using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FAvaUpdateBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.activationRadius = stream.ReadDouble();
			this.activationRadiusIncreased = stream.ReadBoolean();
			this.activationRadiusIncreasedLeftTime = stream.ReadInt64();
			this.alliance = (AllianceType?)stream.ReadDynamicObject();
			this.altarCoords = (GeoCoords)stream.ReadDynamicObject();
			this.buddy = (FBuddy)stream.ReadDynamicObject();
			this.buffs = stream.ReadStaticList<FBuff>(true);
			this.candies = stream.ReadStaticMap<CreatureType, int>(true, true);
			this.coins = stream.ReadInt32();
			this.creatureStorageSize = stream.ReadInt32();
			this.currentExperience = stream.ReadInt32();
			this.doubleDropDuration = stream.ReadInt64();
			this.doubleDropLeftTime = stream.ReadInt64();
			this.dungeonId = (string)stream.ReadDynamicObject();
			this.dust = stream.ReadInt32();
			this.exp = stream.ReadFloat();
			this.experienceBoosterDuration = stream.ReadInt64();
			this.experienceBoosterLeftTime = stream.ReadInt64();
			this.incenseDuration = stream.ReadInt64();
			this.incenseLeftTime = stream.ReadInt64();
			this.isArtifactsBagFull = stream.ReadBoolean();
			this.isBagFull = stream.ReadBoolean();
			this.isEggBagFull = stream.ReadBoolean();
			this.level = stream.ReadInt32();
			this.nextLevelExperience = stream.ReadInt32();
			this.recipes = stream.ReadStaticList<RecipeType>(true);
			this.registerDate = stream.ReadInt64();
			this.scoutChargesLeft = stream.ReadInt32();
			this.scoutRadius = stream.ReadFloat();
			this.slugLeftTime = stream.ReadInt32();
			this.stopFieldDuration = stream.ReadInt64();
			this.stopFieldLeftTime = stream.ReadInt64();
			this.superVisionCenter = (GeoCoords)stream.ReadDynamicObject();
			this.superVisionDuration = stream.ReadInt64();
			this.superVisionLeftTime = stream.ReadInt64();
			this.totalDistance = stream.ReadInt32();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDouble(this.activationRadius);
			stream.WriteBoolean(this.activationRadiusIncreased);
			stream.WriteInt64(this.activationRadiusIncreasedLeftTime);
			stream.WriteDynamicObject(this.alliance);
			stream.WriteDynamicObject(this.altarCoords);
			stream.WriteDynamicObject(this.buddy);
			stream.WriteStaticCollection(this.buffs, true);
			stream.WriteStaticMap(this.candies, true, true);
			stream.WriteInt32(this.coins);
			stream.WriteInt32(this.creatureStorageSize);
			stream.WriteInt32(this.currentExperience);
			stream.WriteInt64(this.doubleDropDuration);
			stream.WriteInt64(this.doubleDropLeftTime);
			stream.WriteDynamicObject(this.dungeonId);
			stream.WriteInt32(this.dust);
			stream.WriteFloat(this.exp);
			stream.WriteInt64(this.experienceBoosterDuration);
			stream.WriteInt64(this.experienceBoosterLeftTime);
			stream.WriteInt64(this.incenseDuration);
			stream.WriteInt64(this.incenseLeftTime);
			stream.WriteBoolean(this.isArtifactsBagFull);
			stream.WriteBoolean(this.isBagFull);
			stream.WriteBoolean(this.isEggBagFull);
			stream.WriteInt32(this.level);
			stream.WriteInt32(this.nextLevelExperience);
			stream.WriteStaticCollection(this.recipes, true);
			stream.WriteInt64(this.registerDate);
			stream.WriteInt32(this.scoutChargesLeft);
			stream.WriteFloat(this.scoutRadius);
			stream.WriteInt32(this.slugLeftTime);
			stream.WriteInt64(this.stopFieldDuration);
			stream.WriteInt64(this.stopFieldLeftTime);
			stream.WriteDynamicObject(this.superVisionCenter);
			stream.WriteInt64(this.superVisionDuration);
			stream.WriteInt64(this.superVisionLeftTime);
			stream.WriteInt32(this.totalDistance);
		}

		public int level;

		public float exp;

		public int currentExperience;

		public int nextLevelExperience;

		public bool activationRadiusIncreased;

		public long activationRadiusIncreasedLeftTime;

		public double activationRadius;

		public AllianceType? alliance;

		public string dungeonId;

		public int creatureStorageSize;

		public bool isBagFull;

		public bool isArtifactsBagFull;

		public bool isEggBagFull;

		public int coins;

		public int dust;

		public long incenseLeftTime;

		public long incenseDuration;

		public long superVisionLeftTime;

		public long superVisionDuration;

		public long doubleDropLeftTime;

		public long doubleDropDuration;

		public long experienceBoosterLeftTime;

		public long experienceBoosterDuration;

		public GeoCoords superVisionCenter;

		public int scoutChargesLeft;

		public float scoutRadius;

		public List<RecipeType> recipes;

		public List<FBuff> buffs;

		public GeoCoords altarCoords;

		public FBuddy buddy;

		public int slugLeftTime;

		public int totalDistance;

		public long registerDate;

		public long stopFieldLeftTime;

		public long stopFieldDuration;

		public Dictionary<CreatureType, int> candies;
	}
}
