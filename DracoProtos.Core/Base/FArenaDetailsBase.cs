using System;
using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FArenaDetailsBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.allianceChooseRequest = (FAllianceChooseRequest)stream.ReadDynamicObject();
			this.buildingType = (BuildingType)stream.ReadEnum(typeof(BuildingType));
			this.canAddDefender = stream.ReadBoolean();
			this.canAttack = stream.ReadBoolean();
			this.capturableGeoPointsLimitReached = stream.ReadBoolean();
			this.combinedName = stream.ReadInt32();
			this.coords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.currentExp = stream.ReadInt32();
			this.defenders = stream.ReadStaticList<FDefenderDetails>(true);
			this.id = stream.ReadUtfString();
			this.lastUpdateTime = stream.ReadInt64();
			this.level = stream.ReadInt32();
			this.libraryBlockedCooldown = stream.ReadInt32();
			this.minUseLevel = stream.ReadInt32();
			this.nextLevelExp = stream.ReadInt32();
			this.ownerAlliance = (AllianceType?)stream.ReadDynamicObject();
			this.possibleDefendersCount = stream.ReadInt32();
			this.protectionRemainingTime = stream.ReadFloat();
			this.remoteBuildingControlChargesMaxCount = stream.ReadInt32();
			this.remoteBuildingControlChargesUsed = stream.ReadInt32();
			this.remoteBuildingControlCooldown = stream.ReadInt32();
			this.restrictedForAllianceToCapture = (AllianceType?)stream.ReadDynamicObject();
			this.restrictedForAllianceToCaptureRemainingTime = stream.ReadFloat();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDynamicObject(this.allianceChooseRequest);
			stream.WriteEnum(this.buildingType);
			stream.WriteBoolean(this.canAddDefender);
			stream.WriteBoolean(this.canAttack);
			stream.WriteBoolean(this.capturableGeoPointsLimitReached);
			stream.WriteInt32(this.combinedName);
			stream.WriteStaticObject(this.coords);
			stream.WriteInt32(this.currentExp);
			stream.WriteStaticCollection(this.defenders, true);
			stream.WriteUtfString(this.id);
			stream.WriteInt64(this.lastUpdateTime);
			stream.WriteInt32(this.level);
			stream.WriteInt32(this.libraryBlockedCooldown);
			stream.WriteInt32(this.minUseLevel);
			stream.WriteInt32(this.nextLevelExp);
			stream.WriteDynamicObject(this.ownerAlliance);
			stream.WriteInt32(this.possibleDefendersCount);
			stream.WriteFloat(this.protectionRemainingTime);
			stream.WriteInt32(this.remoteBuildingControlChargesMaxCount);
			stream.WriteInt32(this.remoteBuildingControlChargesUsed);
			stream.WriteInt32(this.remoteBuildingControlCooldown);
			stream.WriteDynamicObject(this.restrictedForAllianceToCapture);
			stream.WriteFloat(this.restrictedForAllianceToCaptureRemainingTime);
		}

		public string id;

		public GeoCoords coords;

		public int remoteBuildingControlChargesMaxCount;

		public int remoteBuildingControlChargesUsed;

		public int remoteBuildingControlCooldown;

		public int minUseLevel;

		public bool canAttack;

		public float protectionRemainingTime;

		public AllianceType? ownerAlliance;

		public int level;

		public int currentExp;

		public int nextLevelExp;

		public List<FDefenderDetails> defenders;

		public bool canAddDefender;

		public int possibleDefendersCount;

		public bool capturableGeoPointsLimitReached;

		public int combinedName;

		public int libraryBlockedCooldown;

		public AllianceType? restrictedForAllianceToCapture;

		public float restrictedForAllianceToCaptureRemainingTime;

		public FAllianceChooseRequest allianceChooseRequest;

		public BuildingType buildingType;

		public long lastUpdateTime;
	}
}
