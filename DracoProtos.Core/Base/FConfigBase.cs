using System.Collections.Generic;
using DracoProtos.Core.Enums;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FConfigBase : FBaseItemUpdate
	{
        public override void ReadExternal(FInputStream stream)
        {
            base.ReadExternal(stream);
            this.actionInfoShowDuration = stream.ReadFloat();
            this.activeTimeAllowedInBackgroundDuration = stream.ReadFloat();
            this.aggressiveChanceToAttack = stream.ReadFloat();
            this.aggressiveChanceToJump = stream.ReadFloat();
            this.aggressiveChancesCooldownTime = stream.ReadFloat();
            this.altarAvailableFromLevel = stream.ReadInt32();
            this.angularDrag = stream.ReadFloat();
            this.arenaLayerLevels = stream.ReadStaticArray<int>(true);
            this.arenaLevelsThreshold = stream.ReadStaticArray<int>(true);
            this.artifactSellPrice = stream.ReadStaticMap<ArtifactName, int>(true, true);
            this.avatarMoveExtrapolationMaxRunawayDistance = stream.ReadFloat();
            this.avatarMoveMaxDistanceRun = stream.ReadInt32();
            this.avatarMoveMaxMoveDuration = stream.ReadFloat();
            this.avatarMoveReturnToRealPositionDuration = stream.ReadFloat();
            this.avatarMoveReturnToRealPositionTimeout = stream.ReadFloat();
            this.avatarMoveRunSpeed = stream.ReadInt32();
            this.ballCurve = stream.ReadFloat();
            this.bottomSwipeScreenPart = stream.ReadFloat();
            this.buildingsVisibilityDistanceLevels = stream.ReadStaticArray<float>(true);
            this.buildingsVisionRadius = stream.ReadInt32();
            this.cameraFieldOfView = stream.ReadFloat();
            this.catchPopup = stream.ReadStaticSortedMap<float, string>(true, true);
            this.clientTexts = stream.ReadStaticMap<string, string>(true, true);
            this.collectorRatingButtonVisibleToAll = stream.ReadBoolean();
            this.congratulationLayerLevels = stream.ReadStaticArray<int>(true);
            this.contestAcceptStartPeriod = stream.ReadFloat();
            this.contestAvailableFromLevel = stream.ReadInt32();
            this.contestBattleTimeout = stream.ReadFloat();
            this.contestVisibleToAll = stream.ReadBoolean();
            this.contestVisionRadius = stream.ReadFloat();
            this.creaturesDelayVisibility = stream.ReadInt32();
            this.dailyQuestAvailableFromLevel = stream.ReadInt32();
            this.defaultAugmentedRealitySwitchState = stream.ReadBoolean();
            this.defenderBaseAttackBeforeChargedMax = stream.ReadInt32();
            this.defenderBaseAttackBeforeChargedMin = stream.ReadInt32();
            this.delayForCheckMaxSpeedToPlay = stream.ReadFloat();
            this.delayToDisableGameBecauseOfLowGPSAccuracy = stream.ReadFloat();
            this.desiredGpsAccuracy = stream.ReadFloat();
            this.distanceToLoadTiles = stream.ReadFloat();
            this.distanceToUnloadTiles = stream.ReadFloat();
            this.emulatorCheckEnabled = stream.ReadBoolean();
            this.encounterDelayBeforeExtraEncounter = stream.ReadInt32();
            this.encounterNeededActiveUserTime = stream.ReadStaticArray<int>(true);
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
            this.maintenanceEnabled = stream.ReadBoolean();
            this.mapServer = stream.ReadUtfString();
            this.mapVersion = stream.ReadInt32();
            this.maxAngularVelocity = stream.ReadInt32();
            this.maxClientPauseDuration = stream.ReadFloat();
            this.maxSpeedForUse = stream.ReadFloat();
            this.maxSpeedToPlay = stream.ReadInt32();
            this.mentorChooseEnabled = stream.ReadBoolean();
            this.mentorshipEnabled = stream.ReadBoolean();
            this.minFPS = stream.ReadInt32();
            this.minFPSMeasureDurationSec = stream.ReadFloat();
            this.monsterLevelPerUserLevel = stream.ReadFloat();
            this.monsterMaxLevel = stream.ReadInt32();
            this.newsCheckIntervalSeconds = stream.ReadFloat();
            this.notEmulatorModelHashes = stream.ReadStaticHashSet<sbyte[]>(true);
            this.oppositeDodgeTimeoutSeconds = stream.ReadFloat();
            this.personalizationPrices = stream.ReadStaticMap<PersonalizedStop, FPrice>(true, true);
            this.potionConfig = (PotionConfig)stream.ReadStaticObject(typeof(PotionConfig));
            this.radarVisionRadius = stream.ReadDouble();
            this.recipes = stream.ReadStaticMap<RecipeType, List<object>>(true, true);
            this.requestRetryDelay = stream.ReadFloat();
            this.screenDifferentSwipeDivision = stream.ReadFloat();
            this.spinGain = stream.ReadFloat();
            this.stopLootStreakDuration = stream.ReadFloat();
            this.stopUsageHintTillLevel = stream.ReadInt32();
            this.superVisionEffectInterval = stream.ReadFloat();
            this.superVisionRadius = stream.ReadInt32();
            this.throwSensitivity = stream.ReadFloat();
            this.timeLimitPerDefender = stream.ReadFloat();
            this.topSwipeScreenPart = stream.ReadFloat();
            this.updateRequestCooldownSeconds = stream.ReadInt32();
            this.updateRequestIgnoreWorseAccuracyCooldownSeconds = stream.ReadInt32();
            this.updateRequestMinimalDistance = stream.ReadInt32();
            this.updateRequestPeriodSeconds = stream.ReadInt32();
            this.weeklyQuestAvailableFromLevel = stream.ReadInt32();
            this.wizardAvailableFromLevel = stream.ReadInt32();
            this.wizardRatingButtonVisibleToAll = stream.ReadBoolean();
            this.worldScreenBuffDisplayMaxDurationTimeSeconds = stream.ReadFloat();
            this.xVelocityFactor = stream.ReadFloat();
            this.xVelocityFactorSpin = stream.ReadFloat();
            this.yVelocityFactor = stream.ReadFloat();
        }

        public override void WriteExternal(FOutputStream stream)
        {
            base.WriteExternal(stream);
            stream.WriteFloat(this.actionInfoShowDuration);
            stream.WriteFloat(this.activeTimeAllowedInBackgroundDuration);
            stream.WriteFloat(this.aggressiveChanceToAttack);
            stream.WriteFloat(this.aggressiveChanceToJump);
            stream.WriteFloat(this.aggressiveChancesCooldownTime);
            stream.WriteInt32(this.altarAvailableFromLevel);
            stream.WriteFloat(this.angularDrag);
            stream.WriteStaticCollection(this.arenaLayerLevels, true);
            stream.WriteStaticCollection(this.arenaLevelsThreshold, true);
            stream.WriteStaticMap(this.artifactSellPrice, true, true);
            stream.WriteFloat(this.avatarMoveExtrapolationMaxRunawayDistance);
            stream.WriteInt32(this.avatarMoveMaxDistanceRun);
            stream.WriteFloat(this.avatarMoveMaxMoveDuration);
            stream.WriteFloat(this.avatarMoveReturnToRealPositionDuration);
            stream.WriteFloat(this.avatarMoveReturnToRealPositionTimeout);
            stream.WriteInt32(this.avatarMoveRunSpeed);
            stream.WriteFloat(this.ballCurve);
            stream.WriteFloat(this.bottomSwipeScreenPart);
            stream.WriteStaticCollection(this.buildingsVisibilityDistanceLevels, true);
            stream.WriteInt32(this.buildingsVisionRadius);
            stream.WriteFloat(this.cameraFieldOfView);
            stream.WriteStaticMap(this.catchPopup, true, true);
            stream.WriteStaticMap(this.clientTexts, true, true);
            stream.WriteBoolean(this.collectorRatingButtonVisibleToAll);
            stream.WriteStaticCollection(this.congratulationLayerLevels, true);
            stream.WriteFloat(this.contestAcceptStartPeriod);
            stream.WriteInt32(this.contestAvailableFromLevel);
            stream.WriteFloat(this.contestBattleTimeout);
            stream.WriteBoolean(this.contestVisibleToAll);
            stream.WriteFloat(this.contestVisionRadius);
            stream.WriteInt32(this.creaturesDelayVisibility);
            stream.WriteInt32(this.dailyQuestAvailableFromLevel);
            stream.WriteBoolean(this.defaultAugmentedRealitySwitchState);
            stream.WriteInt32(this.defenderBaseAttackBeforeChargedMax);
            stream.WriteInt32(this.defenderBaseAttackBeforeChargedMin);
            stream.WriteFloat(this.delayForCheckMaxSpeedToPlay);
            stream.WriteFloat(this.delayToDisableGameBecauseOfLowGPSAccuracy);
            stream.WriteFloat(this.desiredGpsAccuracy);
            stream.WriteFloat(this.distanceToLoadTiles);
            stream.WriteFloat(this.distanceToUnloadTiles);
            stream.WriteBoolean(this.emulatorCheckEnabled);
            stream.WriteInt32(this.encounterDelayBeforeExtraEncounter);
            stream.WriteStaticCollection(this.encounterNeededActiveUserTime, true);
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
            stream.WriteBoolean(this.maintenanceEnabled);
            stream.WriteUtfString(this.mapServer);
            stream.WriteInt32(this.mapVersion);
            stream.WriteInt32(this.maxAngularVelocity);
            stream.WriteFloat(this.maxClientPauseDuration);
            stream.WriteFloat(this.maxSpeedForUse);
            stream.WriteInt32(this.maxSpeedToPlay);
            stream.WriteBoolean(this.mentorChooseEnabled);
            stream.WriteBoolean(this.mentorshipEnabled);
            stream.WriteInt32(this.minFPS);
            stream.WriteFloat(this.minFPSMeasureDurationSec);
            stream.WriteFloat(this.monsterLevelPerUserLevel);
            stream.WriteInt32(this.monsterMaxLevel);
            stream.WriteFloat(this.newsCheckIntervalSeconds);
            stream.WriteStaticEnumerable(this.notEmulatorModelHashes, true);
            stream.WriteFloat(this.oppositeDodgeTimeoutSeconds);
            stream.WriteStaticMap(this.personalizationPrices, true, true);
            stream.WriteStaticObject(this.potionConfig);
            stream.WriteDouble(this.radarVisionRadius);
            stream.WriteStaticMap(this.recipes, true, true);
            stream.WriteFloat(this.requestRetryDelay);
            stream.WriteFloat(this.screenDifferentSwipeDivision);
            stream.WriteFloat(this.spinGain);
            stream.WriteFloat(this.stopLootStreakDuration);
            stream.WriteInt32(this.stopUsageHintTillLevel);
            stream.WriteFloat(this.superVisionEffectInterval);
            stream.WriteInt32(this.superVisionRadius);
            stream.WriteFloat(this.throwSensitivity);
            stream.WriteFloat(this.timeLimitPerDefender);
            stream.WriteFloat(this.topSwipeScreenPart);
            stream.WriteInt32(this.updateRequestCooldownSeconds);
            stream.WriteInt32(this.updateRequestIgnoreWorseAccuracyCooldownSeconds);
            stream.WriteInt32(this.updateRequestMinimalDistance);
            stream.WriteInt32(this.updateRequestPeriodSeconds);
            stream.WriteInt32(this.weeklyQuestAvailableFromLevel);
            stream.WriteInt32(this.wizardAvailableFromLevel);
            stream.WriteBoolean(this.wizardRatingButtonVisibleToAll);
            stream.WriteFloat(this.worldScreenBuffDisplayMaxDurationTimeSeconds);
            stream.WriteFloat(this.xVelocityFactor);
            stream.WriteFloat(this.xVelocityFactorSpin);
            stream.WriteFloat(this.yVelocityFactor);
        }

        public string mapServer;

        public bool maintenanceEnabled;

        public float spinGain;

        public float ballCurve;

        public int maxAngularVelocity;

        public float angularDrag;

        public float xVelocityFactor;

        public float xVelocityFactorSpin;

        public float yVelocityFactor;

        public float throwSensitivity;

        public int creaturesDelayVisibility;

        public int monsterMaxLevel;

        public float monsterLevelPerUserLevel;

        public double radarVisionRadius;

        public int wizardAvailableFromLevel;

        public int contestAvailableFromLevel;

        public float contestVisionRadius;

        public float contestAcceptStartPeriod;

        public float contestBattleTimeout;

        public int altarAvailableFromLevel;

        public int dailyQuestAvailableFromLevel;

        public int weeklyQuestAvailableFromLevel;

        public int avatarMoveMaxDistanceRun;

        public int avatarMoveRunSpeed;

        public float avatarMoveReturnToRealPositionTimeout;

        public float avatarMoveReturnToRealPositionDuration;

        public float avatarMoveMaxMoveDuration;

        public float avatarMoveExtrapolationMaxRunawayDistance;

        public Dictionary<PersonalizedStop, FPrice> personalizationPrices;

        public int[] arenaLevelsThreshold;

        public int[] congratulationLayerLevels;

        public int[] arenaLayerLevels;

        public Dictionary<RecipeType, List<object>> recipes;

        public float activeTimeAllowedInBackgroundDuration;

        public int[] encounterNeededActiveUserTime;

        public int encounterDelayBeforeExtraEncounter;

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

        public float oppositeDodgeTimeoutSeconds;

        public float actionInfoShowDuration;

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

        public int stopUsageHintTillLevel;

        public Dictionary<ArtifactName, int> artifactSellPrice;

        public float newsCheckIntervalSeconds;

        public float worldScreenBuffDisplayMaxDurationTimeSeconds;

        public float requestRetryDelay;

        public bool mentorshipEnabled;

        public float topSwipeScreenPart;

        public float bottomSwipeScreenPart;

        public float screenDifferentSwipeDivision;

        public bool mentorChooseEnabled;

        public float stopLootStreakDuration;

        public bool collectorRatingButtonVisibleToAll;

        public bool wizardRatingButtonVisibleToAll;

        public bool contestVisibleToAll;

        public Dictionary<string, string> clientTexts;

        public bool emulatorCheckEnabled;

        public HashSet<sbyte[]> notEmulatorModelHashes;

        public bool defaultAugmentedRealitySwitchState;

        public int minFPS;

        public float minFPSMeasureDurationSec;

        public float[] buildingsVisibilityDistanceLevels;
    }
}

