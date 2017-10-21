using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FConfigBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.aggressiveChanceToAttack = stream.ReadFloat();
			this.aggressiveChanceToJump = stream.ReadFloat();
			this.aggressiveChancesCooldownTime = stream.ReadFloat();
			this.altarAvailableFromLevel = stream.ReadInt32();
			this.angularDrag = stream.ReadFloat();
			this.arenaLayerLevels = stream.ReadStaticArray<int>(true);
			this.arenaLevelsThreshold = stream.ReadStaticArray<int>(true);
			this.avatarMoveMaxDistanceRun = stream.ReadInt32();
			this.avatarMoveRunSpeed = stream.ReadInt32();
			this.ballCurve = stream.ReadFloat();
			this.battlesEnhancedLimitPrice = stream.ReadInt32();
			this.buildingsVisionRadius = stream.ReadInt32();
			this.cameraFieldOfView = stream.ReadFloat();
			this.catchPopup = stream.ReadStaticSortedMap<float, string>(true, true);
			this.congratulationLayerLevels = stream.ReadStaticArray<int>(true);
			this.creaturesDelayVisibility = stream.ReadInt32();
			this.dailyQuestAvailableFromLevel = stream.ReadInt32();
			this.defenderBaseAttackBeforeChargedMax = stream.ReadInt32();
			this.defenderBaseAttackBeforeChargedMin = stream.ReadInt32();
			this.delayForCheckMaxSpeedToPlay = stream.ReadFloat();
			this.delayToDisableGameBecauseOfLowGPSAccuracy = stream.ReadFloat();
			this.desiredGpsAccuracy = stream.ReadFloat();
			this.distanceToLoadTiles = stream.ReadFloat();
			this.distanceToUnloadTiles = stream.ReadFloat();
			this.encounterDelaySinceStartup = stream.ReadInt32();
			this.fogEndDistance = stream.ReadFloat();
			this.fogStartDistance = stream.ReadFloat();
			this.goOrbitDistance = stream.ReadFloat();
			this.goOrbitDistanceMax = stream.ReadFloat();
			this.goOrbitDistanceMin = stream.ReadFloat();
			this.goOrbitHeightMaxLimit = stream.ReadFloat();
			this.goOrbitHeightMinLimit = stream.ReadFloat();
			this.goOrbitOffsetMax = stream.ReadFloat();
			this.goOrbitOffsetMin = stream.ReadFloat();
			this.highSpeedDurationRequiredForWarning = stream.ReadFloat();
			this.mapServer = stream.ReadUtfString();
			this.mapVersion = stream.ReadInt32();
			this.maxAngularVelocity = stream.ReadInt32();
			this.maxClientPauseDuration = stream.ReadFloat();
			this.maxSpeedForUse = stream.ReadFloat();
			this.maxSpeedToPlay = stream.ReadInt32();
			this.monsterLevelPerUserLevel = stream.ReadFloat();
			this.monsterMaxLevel = stream.ReadInt32();
			this.personalizationPrice = stream.ReadInt32();
			this.potionConfig = (PotionConfig)stream.ReadStaticObject(typeof(PotionConfig));
			this.radarVisionRadius = stream.ReadDouble();
			this.runes = stream.ReadStaticMap<RecipeType, List<object>>(true, true);
			this.serverTime = stream.ReadInt64();
			this.spinGain = stream.ReadFloat();
			this.superVisionEffectInterval = stream.ReadFloat();
			this.superVisionRadius = stream.ReadInt32();
			this.timeLimitPerDefender = stream.ReadFloat();
			this.updateRequestCooldownSeconds = stream.ReadInt32();
			this.updateRequestIgnoreWorseAccuracyCooldownSeconds = stream.ReadInt32();
			this.updateRequestMinimalDistance = stream.ReadInt32();
			this.updateRequestPeriodSeconds = stream.ReadInt32();
			this.weeklyQuestAvailableFromLevel = stream.ReadInt32();
			this.wizardAvailableFromLevel = stream.ReadInt32();
			this.wizardEnhanceCount = stream.ReadInt32();
			this.xVelocityFactor = stream.ReadFloat();
			this.xVelocityFactorSpin = stream.ReadFloat();
			this.yVelocityFactor = stream.ReadFloat();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteFloat(this.aggressiveChanceToAttack);
			stream.WriteFloat(this.aggressiveChanceToJump);
			stream.WriteFloat(this.aggressiveChancesCooldownTime);
			stream.WriteInt32(this.altarAvailableFromLevel);
			stream.WriteFloat(this.angularDrag);
			stream.WriteStaticCollection(this.arenaLayerLevels, true);
			stream.WriteStaticCollection(this.arenaLevelsThreshold, true);
			stream.WriteInt32(this.avatarMoveMaxDistanceRun);
			stream.WriteInt32(this.avatarMoveRunSpeed);
			stream.WriteFloat(this.ballCurve);
			stream.WriteInt32(this.battlesEnhancedLimitPrice);
			stream.WriteInt32(this.buildingsVisionRadius);
			stream.WriteFloat(this.cameraFieldOfView);
			stream.WriteStaticMap(this.catchPopup, true, true);
			stream.WriteStaticCollection(this.congratulationLayerLevels, true);
			stream.WriteInt32(this.creaturesDelayVisibility);
			stream.WriteInt32(this.dailyQuestAvailableFromLevel);
			stream.WriteInt32(this.defenderBaseAttackBeforeChargedMax);
			stream.WriteInt32(this.defenderBaseAttackBeforeChargedMin);
			stream.WriteFloat(this.delayForCheckMaxSpeedToPlay);
			stream.WriteFloat(this.delayToDisableGameBecauseOfLowGPSAccuracy);
			stream.WriteFloat(this.desiredGpsAccuracy);
			stream.WriteFloat(this.distanceToLoadTiles);
			stream.WriteFloat(this.distanceToUnloadTiles);
			stream.WriteInt32(this.encounterDelaySinceStartup);
			stream.WriteFloat(this.fogEndDistance);
			stream.WriteFloat(this.fogStartDistance);
			stream.WriteFloat(this.goOrbitDistance);
			stream.WriteFloat(this.goOrbitDistanceMax);
			stream.WriteFloat(this.goOrbitDistanceMin);
			stream.WriteFloat(this.goOrbitHeightMaxLimit);
			stream.WriteFloat(this.goOrbitHeightMinLimit);
			stream.WriteFloat(this.goOrbitOffsetMax);
			stream.WriteFloat(this.goOrbitOffsetMin);
			stream.WriteFloat(this.highSpeedDurationRequiredForWarning);
			stream.WriteUtfString(this.mapServer);
			stream.WriteInt32(this.mapVersion);
			stream.WriteInt32(this.maxAngularVelocity);
			stream.WriteFloat(this.maxClientPauseDuration);
			stream.WriteFloat(this.maxSpeedForUse);
			stream.WriteInt32(this.maxSpeedToPlay);
			stream.WriteFloat(this.monsterLevelPerUserLevel);
			stream.WriteInt32(this.monsterMaxLevel);
			stream.WriteInt32(this.personalizationPrice);
			stream.WriteStaticObject(this.potionConfig);
			stream.WriteDouble(this.radarVisionRadius);
			stream.WriteStaticMap(this.runes, true, true);
			stream.WriteInt64(this.serverTime);
			stream.WriteFloat(this.spinGain);
			stream.WriteFloat(this.superVisionEffectInterval);
			stream.WriteInt32(this.superVisionRadius);
			stream.WriteFloat(this.timeLimitPerDefender);
			stream.WriteInt32(this.updateRequestCooldownSeconds);
			stream.WriteInt32(this.updateRequestIgnoreWorseAccuracyCooldownSeconds);
			stream.WriteInt32(this.updateRequestMinimalDistance);
			stream.WriteInt32(this.updateRequestPeriodSeconds);
			stream.WriteInt32(this.weeklyQuestAvailableFromLevel);
			stream.WriteInt32(this.wizardAvailableFromLevel);
			stream.WriteInt32(this.wizardEnhanceCount);
			stream.WriteFloat(this.xVelocityFactor);
			stream.WriteFloat(this.xVelocityFactorSpin);
			stream.WriteFloat(this.yVelocityFactor);
		}

		public string mapServer;

		public long serverTime;

		public float spinGain;

		public float ballCurve;

		public int maxAngularVelocity;

		public float angularDrag;

		public float xVelocityFactor;

		public float xVelocityFactorSpin;

		public float yVelocityFactor;

		public int creaturesDelayVisibility;

		public int monsterMaxLevel;

		public float monsterLevelPerUserLevel;

		public double radarVisionRadius;

		public int wizardAvailableFromLevel;

		public int altarAvailableFromLevel;

		public int dailyQuestAvailableFromLevel;

		public int weeklyQuestAvailableFromLevel;

		public int avatarMoveMaxDistanceRun;

		public int avatarMoveRunSpeed;

		public int wizardEnhanceCount;

		public int battlesEnhancedLimitPrice;

		public int personalizationPrice;

		public int[] arenaLevelsThreshold;

		public int[] congratulationLayerLevels;

		public int[] arenaLayerLevels;

		public Dictionary<RecipeType, List<object>> runes;

		public int encounterDelaySinceStartup;

		public SortedDictionary<float, string> catchPopup;

		public PotionConfig potionConfig;

		public float goOrbitDistance;

		public float goOrbitHeightMinLimit;

		public float goOrbitHeightMaxLimit;

		public float goOrbitDistanceMin;

		public float goOrbitDistanceMax;

		public float goOrbitOffsetMin;

		public float goOrbitOffsetMax;

		public float cameraFieldOfView;

		public float fogStartDistance;

		public float fogEndDistance;

		public float distanceToLoadTiles;

		public float distanceToUnloadTiles;

		public float aggressiveChanceToAttack;

		public float aggressiveChanceToJump;

		public float aggressiveChancesCooldownTime;

		public int buildingsVisionRadius;

		public int superVisionRadius;

		public float superVisionEffectInterval;

		public float timeLimitPerDefender;

		public float maxClientPauseDuration;

		public int maxSpeedToPlay;

		public float delayForCheckMaxSpeedToPlay;

		public float maxSpeedForUse;

		public int mapVersion;

		public float delayToDisableGameBecauseOfLowGPSAccuracy;

		public float highSpeedDurationRequiredForWarning;

		public float desiredGpsAccuracy;

		public int updateRequestPeriodSeconds;

		public int updateRequestMinimalDistance;

		public int updateRequestCooldownSeconds;

		public int updateRequestIgnoreWorseAccuracyCooldownSeconds;

		public int defenderBaseAttackBeforeChargedMin;

		public int defenderBaseAttackBeforeChargedMax;
	}
}
