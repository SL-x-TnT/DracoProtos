﻿using DracoProtos.Core.Objects;
using System;
using System.Collections.Generic;

namespace DracoProtos.Core.Base
{
    public static class FGameObjects
	{
		static FGameObjects()
		{
			FGameObjects.CLASSES.Add(typeof(object), 4);
			FGameObjects.CLASSES.Add(typeof(bool), 5);
			FGameObjects.CLASSES.Add(typeof(sbyte), 6);
			FGameObjects.CLASSES.Add(typeof(short), 7);
			FGameObjects.CLASSES.Add(typeof(int), 8);
			FGameObjects.CLASSES.Add(typeof(long), 9);
			FGameObjects.CLASSES.Add(typeof(float), 10);
			FGameObjects.CLASSES.Add(typeof(double), 11);
			FGameObjects.CLASSES.Add(typeof(string), 12);
			FGameObjects.CLASSES.Add(typeof(List<>), 13);
			FGameObjects.CLASSES.Add(typeof(HashSet<>), 14);
			FGameObjects.CLASSES.Add(typeof(Dictionary<, >), 15);
			FGameObjects.CLASSES.Add(typeof(SortedDictionary<, >), 16);
			FGameObjects.CLASSES.Add(typeof(ContestStage), 17);
			FGameObjects.CLASSES.Add(typeof(AllianceType), 18);
			FGameObjects.CLASSES.Add(typeof(ArtifactName), 19);
			FGameObjects.CLASSES.Add(typeof(ArtifactType), 20);
			FGameObjects.CLASSES.Add(typeof(BuffConfig), 21);
			FGameObjects.CLASSES.Add(typeof(BuffType), 22);
			FGameObjects.CLASSES.Add(typeof(BuildingType), 23);
			FGameObjects.CLASSES.Add(typeof(CreatureType), 24);
			FGameObjects.CLASSES.Add(typeof(DungeonShapeType), 25);
			FGameObjects.CLASSES.Add(typeof(ElementType), 26);
			FGameObjects.CLASSES.Add(typeof(EventLogType), 27);
			FGameObjects.CLASSES.Add(typeof(InAppEventInfo), 28);
			FGameObjects.CLASSES.Add(typeof(InAppEventType), 29);
			FGameObjects.CLASSES.Add(typeof(InstantUseItem), 30);
			FGameObjects.CLASSES.Add(typeof(ItemType), 31);
			FGameObjects.CLASSES.Add(typeof(PersonalizedStop), 32);
			FGameObjects.CLASSES.Add(typeof(PotionConfig), 33);
			FGameObjects.CLASSES.Add(typeof(QuestComplexity), 34);
			FGameObjects.CLASSES.Add(typeof(QuestType), 35);
			FGameObjects.CLASSES.Add(typeof(RecipeType), 36);
			FGameObjects.CLASSES.Add(typeof(SaleSetConfig), 37);
			FGameObjects.CLASSES.Add(typeof(SaleSetType), 38);
			FGameObjects.CLASSES.Add(typeof(ExtraPack), 39);
			FGameObjects.CLASSES.Add(typeof(ProductGroup), 40);
			FGameObjects.CLASSES.Add(typeof(ProductLot), 41);
			FGameObjects.CLASSES.Add(typeof(SkillQuality), 42);
			FGameObjects.CLASSES.Add(typeof(SpellType), 43);
			FGameObjects.CLASSES.Add(typeof(AuthData), 44);
			FGameObjects.CLASSES.Add(typeof(AuthType), 45);
			FGameObjects.CLASSES.Add(typeof(LogDetailsType), 46);
			FGameObjects.CLASSES.Add(typeof(FClientInfo), 47);
			FGameObjects.CLASSES.Add(typeof(FRegistrationInfo), 48);
			FGameObjects.CLASSES.Add(typeof(ClientPlatform), 49);
			FGameObjects.CLASSES.Add(typeof(ClientScreen), 50);
			FGameObjects.CLASSES.Add(typeof(FActiveObject), 51);
			FGameObjects.CLASSES.Add(typeof(FActiveObjectsUpdate), 52);
			FGameObjects.CLASSES.Add(typeof(FAllianceChooseRequest), 53);
			FGameObjects.CLASSES.Add(typeof(FAltar), 54);
			FGameObjects.CLASSES.Add(typeof(FAltarDetails), 55);
			FGameObjects.CLASSES.Add(typeof(FArena), 56);
			FGameObjects.CLASSES.Add(typeof(FArenaBattleResult), 57);
			FGameObjects.CLASSES.Add(typeof(FArenaDetails), 58);
			FGameObjects.CLASSES.Add(typeof(FDefenderDetails), 59);
			FGameObjects.CLASSES.Add(typeof(FArenaWithBattleUpdate), 60);
			FGameObjects.CLASSES.Add(typeof(FArtifactsUpdate), 61);
			FGameObjects.CLASSES.Add(typeof(FAttackArenaRequest), 62);
			FGameObjects.CLASSES.Add(typeof(FAuthData), 63);
			FGameObjects.CLASSES.Add(typeof(FAvaUpdate), 64);
			FGameObjects.CLASSES.Add(typeof(FBagItem), 65);
			FGameObjects.CLASSES.Add(typeof(FBagUpdate), 66);
			FGameObjects.CLASSES.Add(typeof(FBaseItemUpdate), 67);
			FGameObjects.CLASSES.Add(typeof(FBaseLootItem), 68);
			FGameObjects.CLASSES.Add(typeof(FBaseRatingRecord), 69);
			FGameObjects.CLASSES.Add(typeof(FBuddy), 70);
			FGameObjects.CLASSES.Add(typeof(FBuff), 71);
			FGameObjects.CLASSES.Add(typeof(FBuilding), 72);
			FGameObjects.CLASSES.Add(typeof(FBuildingRequest), 73);
			FGameObjects.CLASSES.Add(typeof(FBuildingUpdate), 74);
			FGameObjects.CLASSES.Add(typeof(FCatchCreatureResult), 75);
			FGameObjects.CLASSES.Add(typeof(FCatchingConfig), 76);
			FGameObjects.CLASSES.Add(typeof(FCatchingCreature), 77);
			FGameObjects.CLASSES.Add(typeof(FChest), 78);
			FGameObjects.CLASSES.Add(typeof(FChestUpdate), 79);
			FGameObjects.CLASSES.Add(typeof(FClientLogRecord), 80);
			FGameObjects.CLASSES.Add(typeof(FClientRequest), 81);
			FGameObjects.CLASSES.Add(typeof(FCollectorRating), 82);
			FGameObjects.CLASSES.Add(typeof(FCollectorRatingListRecord), 83);
			FGameObjects.CLASSES.Add(typeof(FConfig), 84);
			FGameObjects.CLASSES.Add(typeof(FContest), 85);
			FGameObjects.CLASSES.Add(typeof(FContestBattle), 86);
			FGameObjects.CLASSES.Add(typeof(FContestParticipant), 87);
			FGameObjects.CLASSES.Add(typeof(FContestStats), 88);
			FGameObjects.CLASSES.Add(typeof(FContestUpdate), 89);
			FGameObjects.CLASSES.Add(typeof(FCreadex), 90);
			FGameObjects.CLASSES.Add(typeof(FCreadexChain), 91);
			FGameObjects.CLASSES.Add(typeof(FCreadexEntry), 92);
			FGameObjects.CLASSES.Add(typeof(FCreatureRequest), 93);
			FGameObjects.CLASSES.Add(typeof(FCreatureUpdate), 94);
			FGameObjects.CLASSES.Add(typeof(FDailyQuest), 95);
			FGameObjects.CLASSES.Add(typeof(FDungeonUpdate), 96);
			FGameObjects.CLASSES.Add(typeof(FEgg), 97);
			FGameObjects.CLASSES.Add(typeof(FEncounterBattleResult), 98);
			FGameObjects.CLASSES.Add(typeof(FEncounterDetails), 99);
			FGameObjects.CLASSES.Add(typeof(FEncounterUpdate), 100);
			FGameObjects.CLASSES.Add(typeof(FFeedMonsterResult), 101);
			FGameObjects.CLASSES.Add(typeof(FFightCreature), 102);
			FGameObjects.CLASSES.Add(typeof(FFightItem), 103);
			FGameObjects.CLASSES.Add(typeof(FFightRequest), 104);
			FGameObjects.CLASSES.Add(typeof(FFightUpdate), 105);
			FGameObjects.CLASSES.Add(typeof(FHatchedEggs), 106);
			FGameObjects.CLASSES.Add(typeof(FHatchingResult), 107);
			FGameObjects.CLASSES.Add(typeof(FInAppEventUpdate), 108);
			FGameObjects.CLASSES.Add(typeof(FIncubator), 109);
			FGameObjects.CLASSES.Add(typeof(FIngameNotifications), 110);
			FGameObjects.CLASSES.Add(typeof(FItemCreatureGroup), 111);
			FGameObjects.CLASSES.Add(typeof(FJournalUpdate), 112);
			FGameObjects.CLASSES.Add(typeof(FJournalRecord), 113);
			FGameObjects.CLASSES.Add(typeof(FLoot), 114);
			FGameObjects.CLASSES.Add(typeof(FLootItemArtifact), 115);
			FGameObjects.CLASSES.Add(typeof(FLootItemBuff), 116);
			FGameObjects.CLASSES.Add(typeof(FLootItemCandy), 117);
			FGameObjects.CLASSES.Add(typeof(FLootItemCoins), 118);
			FGameObjects.CLASSES.Add(typeof(FLootItemDust), 119);
			FGameObjects.CLASSES.Add(typeof(FLootItemExp), 120);
			FGameObjects.CLASSES.Add(typeof(FLootItemInstantUseItem), 121);
			FGameObjects.CLASSES.Add(typeof(FLootItemItem), 122);
			FGameObjects.CLASSES.Add(typeof(FLootItemRecipe), 123);
			FGameObjects.CLASSES.Add(typeof(FMentorshipAwardUpdate), 124);
			FGameObjects.CLASSES.Add(typeof(FMentorshipInfo), 125);
			FGameObjects.CLASSES.Add(typeof(FNewsArticle), 126);
			FGameObjects.CLASSES.Add(typeof(FNicknameValidationError), sbyte.MaxValue);
			FGameObjects.CLASSES.Add(typeof(FNicknameValidationResult), sbyte.MinValue);
			FGameObjects.CLASSES.Add(typeof(FNotification), -127);
			FGameObjects.CLASSES.Add(typeof(FObeliskDetails), -126);
			FGameObjects.CLASSES.Add(typeof(FOpenChestResult), -125);
			FGameObjects.CLASSES.Add(typeof(FPickItemsResponse), -124);
			FGameObjects.CLASSES.Add(typeof(FPitstop), -123);
			FGameObjects.CLASSES.Add(typeof(FPrice), -122);
			FGameObjects.CLASSES.Add(typeof(FPurchaseResult), -121);
			FGameObjects.CLASSES.Add(typeof(FQuestCompleted), -120);
			FGameObjects.CLASSES.Add(typeof(FQuestUpdate), -119);
			FGameObjects.CLASSES.Add(typeof(FRecipeConfig), -118);
			FGameObjects.CLASSES.Add(typeof(FResistModifyDetails), -117);
			FGameObjects.CLASSES.Add(typeof(FResistModifyResult), -116);
			FGameObjects.CLASSES.Add(typeof(FScoutRequest), -115);
			FGameObjects.CLASSES.Add(typeof(FServiceError), -114);
			FGameObjects.CLASSES.Add(typeof(FShopConfig), -113);
			FGameObjects.CLASSES.Add(typeof(FShopConfigRequest), -112);
			FGameObjects.CLASSES.Add(typeof(FSpellCastDone), -111);
			FGameObjects.CLASSES.Add(typeof(FSpellEffectsUpdate), -110);
			FGameObjects.CLASSES.Add(typeof(FStartEncounterRequest), -109);
			FGameObjects.CLASSES.Add(typeof(FStudent), -108);
			FGameObjects.CLASSES.Add(typeof(FTile), -107);
			FGameObjects.CLASSES.Add(typeof(FTileState), -106);
			FGameObjects.CLASSES.Add(typeof(FTips), -105);
			FGameObjects.CLASSES.Add(typeof(FTransferMonsterToCandiesResponse), -104);
			FGameObjects.CLASSES.Add(typeof(FUpdate), -103);
			FGameObjects.CLASSES.Add(typeof(FUpdateNicknameResult), -102);
			FGameObjects.CLASSES.Add(typeof(FUpdateRequest), -101);
			FGameObjects.CLASSES.Add(typeof(FUserCreature), -100);
			FGameObjects.CLASSES.Add(typeof(FUserCreatureUpdate), -99);
			FGameObjects.CLASSES.Add(typeof(FUserCreaturesList), -98);
			FGameObjects.CLASSES.Add(typeof(FUserHatchingInfo), -97);
			FGameObjects.CLASSES.Add(typeof(FUserInfo), -96);
			FGameObjects.CLASSES.Add(typeof(FWeeklyQuest), -95);
			FGameObjects.CLASSES.Add(typeof(FWeeklyQuestFragment), -94);
			FGameObjects.CLASSES.Add(typeof(FWildCreature), -93);
			FGameObjects.CLASSES.Add(typeof(FWizardBattleInfo), -92);
			FGameObjects.CLASSES.Add(typeof(FWizardBattleRating), -91);
			FGameObjects.CLASSES.Add(typeof(FWizardBattleRatingListRecord), -90);
			FGameObjects.CLASSES.Add(typeof(FWizardBattleResult), -89);
			FGameObjects.CLASSES.Add(typeof(GeoCoords), -88);
			FGameObjects.CLASSES.Add(typeof(GeoCoordsWithAccuracy), -87);
			FGameObjects.CLASSES.Add(typeof(IdAndCoords), -86);
			FGameObjects.CLASSES.Add(typeof(Tile), -85);
		}

		public const uint ProtocolVersion = 1440475418u;

		public static readonly Dictionary<Type, sbyte> CLASSES = new Dictionary<Type, sbyte>();
	}
}