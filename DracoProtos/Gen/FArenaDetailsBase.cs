using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
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
			this.hasRemoteBuildingControlAction = stream.ReadBoolean();
			this.id = stream.ReadUtfString();
			this.level = stream.ReadInt32();
			this.libraryBlocked = stream.ReadBoolean();
			this.minUseLevel = stream.ReadInt32();
			this.nextLevelExp = stream.ReadInt32();
			this.ownerAlliance = (AllianceType?)stream.ReadDynamicObject();
			this.protectionRemainingTime = stream.ReadFloat();
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
			stream.WriteBoolean(this.hasRemoteBuildingControlAction);
			stream.WriteUtfString(this.id);
			stream.WriteInt32(this.level);
			stream.WriteBoolean(this.libraryBlocked);
			stream.WriteInt32(this.minUseLevel);
			stream.WriteInt32(this.nextLevelExp);
			stream.WriteDynamicObject(this.ownerAlliance);
			stream.WriteFloat(this.protectionRemainingTime);
			stream.WriteDynamicObject(this.restrictedForAllianceToCapture);
			stream.WriteFloat(this.restrictedForAllianceToCaptureRemainingTime);
		}

		public string id;

		public GeoCoords coords;

		public bool hasRemoteBuildingControlAction;

		public int minUseLevel;

		public bool canAttack;

		public float protectionRemainingTime;

		public AllianceType? ownerAlliance;

		public int level;

		public int currentExp;

		public int nextLevelExp;

		public List<FDefenderDetails> defenders;

		public bool canAddDefender;

		public bool capturableGeoPointsLimitReached;

		public int combinedName;

		public bool libraryBlocked;

		public AllianceType? restrictedForAllianceToCapture;

		public float restrictedForAllianceToCaptureRemainingTime;

		public FAllianceChooseRequest allianceChooseRequest;

		public BuildingType buildingType;
	}
}
