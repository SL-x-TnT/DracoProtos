using System;
using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FAvaUpdateBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.activationRadius = stream.ReadDouble();
			this.alliance = (AllianceType?)stream.ReadDynamicObject();
			this.altarCoords = (GeoCoords)stream.ReadDynamicObject();
			this.artifactDustFactor = stream.ReadFloat();
			this.artifacts = stream.ReadStaticList<ArtifactName>(true);
			this.buddy = (FBuddy)stream.ReadDynamicObject();
			this.buffs = stream.ReadStaticList<FBuff>(true);
			this.candies = stream.ReadStaticMap<CreatureType, int>(true, true);
			this.coins = stream.ReadInt32();
			this.creatureStorageSize = stream.ReadInt32();
			this.currentExperience = stream.ReadInt32();
			this.dungeonId = (string)stream.ReadDynamicObject();
			this.dust = stream.ReadInt32();
			this.eggsHatchedCount = stream.ReadInt32();
			this.emulatorCheckDisabled = stream.ReadBoolean();
			this.exp = stream.ReadFloat();
			this.freshNewsDate = stream.ReadInt64();
			this.hasUnhandledAdvices = stream.ReadBoolean();
			this.incenseDuration = stream.ReadInt64();
			this.incenseGenMonstersGroupName = stream.ReadUtfString();
			this.incenseLeftTime = stream.ReadInt64();
			this.isArtifactsBagFull = stream.ReadBoolean();
			this.isBagFull = stream.ReadBoolean();
			this.isEggBagFull = stream.ReadBoolean();
			this.level = stream.ReadInt32();
			this.monstersCaughtCount = stream.ReadInt32();
			this.nextLevelExperience = stream.ReadInt32();
			this.recipeLevels = stream.ReadStaticMap<RecipeType, int>(true, true);
			this.registerDate = stream.ReadInt64();
			this.stopFieldDuration = stream.ReadInt64();
			this.stopFieldLeftTime = stream.ReadInt64();
			this.superVisionCenter = (GeoCoords)stream.ReadDynamicObject();
			this.superVisionDuration = stream.ReadInt64();
			this.superVisionLeftTime = stream.ReadInt64();
			this.totalDistanceF = stream.ReadFloat();
			this.wearArtifacts = stream.ReadStaticList<ArtifactName>(true);
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDouble(this.activationRadius);
			stream.WriteDynamicObject(this.alliance);
			stream.WriteDynamicObject(this.altarCoords);
			stream.WriteFloat(this.artifactDustFactor);
			stream.WriteStaticCollection(this.artifacts, true);
			stream.WriteDynamicObject(this.buddy);
			stream.WriteStaticCollection(this.buffs, true);
			stream.WriteStaticMap(this.candies, true, true);
			stream.WriteInt32(this.coins);
			stream.WriteInt32(this.creatureStorageSize);
			stream.WriteInt32(this.currentExperience);
			stream.WriteDynamicObject(this.dungeonId);
			stream.WriteInt32(this.dust);
			stream.WriteInt32(this.eggsHatchedCount);
			stream.WriteBoolean(this.emulatorCheckDisabled);
			stream.WriteFloat(this.exp);
			stream.WriteInt64(this.freshNewsDate);
			stream.WriteBoolean(this.hasUnhandledAdvices);
			stream.WriteInt64(this.incenseDuration);
			stream.WriteUtfString(this.incenseGenMonstersGroupName);
			stream.WriteInt64(this.incenseLeftTime);
			stream.WriteBoolean(this.isArtifactsBagFull);
			stream.WriteBoolean(this.isBagFull);
			stream.WriteBoolean(this.isEggBagFull);
			stream.WriteInt32(this.level);
			stream.WriteInt32(this.monstersCaughtCount);
			stream.WriteInt32(this.nextLevelExperience);
			stream.WriteStaticMap(this.recipeLevels, true, true);
			stream.WriteInt64(this.registerDate);
			stream.WriteInt64(this.stopFieldDuration);
			stream.WriteInt64(this.stopFieldLeftTime);
			stream.WriteDynamicObject(this.superVisionCenter);
			stream.WriteInt64(this.superVisionDuration);
			stream.WriteInt64(this.superVisionLeftTime);
			stream.WriteFloat(this.totalDistanceF);
			stream.WriteStaticCollection(this.wearArtifacts, true);
		}

		public int level;

		public float exp;

		public int currentExperience;

		public int nextLevelExperience;

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

		public GeoCoords superVisionCenter;

		public Dictionary<RecipeType, int> recipeLevels;

		public List<FBuff> buffs;

		public GeoCoords altarCoords;

		public FBuddy buddy;

		public float totalDistanceF;

		public long registerDate;

		public long stopFieldLeftTime;

		public long stopFieldDuration;

		public List<ArtifactName> artifacts;

		public List<ArtifactName> wearArtifacts;

		public Dictionary<CreatureType, int> candies;

		public string incenseGenMonstersGroupName;

		public float artifactDustFactor;

		public int monstersCaughtCount;

		public int eggsHatchedCount;

		public long freshNewsDate;

		public bool hasUnhandledAdvices;

		public bool emulatorCheckDisabled;
	}
}
