using System;
using System.Collections.Generic;
using DracoProtos.Core.Enums;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Classes
{
    public static class FGameObjects
    {
        static FGameObjects()
        {
            FGameObjects.CLASSES.Add(typeof(FObeliskDetails), -128);
            FGameObjects.CLASSES.Add(typeof(FOpenChestResult), -127);
            FGameObjects.CLASSES.Add(typeof(FPickItemsResponse), -126);
            FGameObjects.CLASSES.Add(typeof(FPitstop), -125);
            FGameObjects.CLASSES.Add(typeof(FPurchaseResult), -124);
            FGameObjects.CLASSES.Add(typeof(FQuestCompleted), -123);
            FGameObjects.CLASSES.Add(typeof(FQuestUpdate), -122);
            FGameObjects.CLASSES.Add(typeof(FRecipeConfig), -121);
            FGameObjects.CLASSES.Add(typeof(FResistModifyDetails), -120);
            FGameObjects.CLASSES.Add(typeof(FResistModifyResult), -119);
            FGameObjects.CLASSES.Add(typeof(FScoutRequest), -118);
            FGameObjects.CLASSES.Add(typeof(FServiceError), -117);
            FGameObjects.CLASSES.Add(typeof(FShopConfig), -116);
            FGameObjects.CLASSES.Add(typeof(FSpellCastDone), -115);
            FGameObjects.CLASSES.Add(typeof(FSpellEffectsUpdate), -114);
            FGameObjects.CLASSES.Add(typeof(FStartEncounterRequest), -113);
            FGameObjects.CLASSES.Add(typeof(FStudent), -112);
            FGameObjects.CLASSES.Add(typeof(FTile), -111);
            FGameObjects.CLASSES.Add(typeof(FTileState), -110);
            FGameObjects.CLASSES.Add(typeof(FTips), -109);
            FGameObjects.CLASSES.Add(typeof(FTransferMonsterToCandiesResponse), -108);
            FGameObjects.CLASSES.Add(typeof(FUpdate), -107);
            FGameObjects.CLASSES.Add(typeof(FUpdateNicknameResult), -106);
            FGameObjects.CLASSES.Add(typeof(FUpdateRequest), -105);
            FGameObjects.CLASSES.Add(typeof(FUserCreature), -104);
            FGameObjects.CLASSES.Add(typeof(FUserCreatureUpdate), -103);
            FGameObjects.CLASSES.Add(typeof(FUserCreaturesList), -102);
            FGameObjects.CLASSES.Add(typeof(FUserHatchingInfo), -101);
            FGameObjects.CLASSES.Add(typeof(FUserInfo), -100);
            FGameObjects.CLASSES.Add(typeof(FWeeklyQuest), -99);
            FGameObjects.CLASSES.Add(typeof(FWeeklyQuestFragment), -98);
            FGameObjects.CLASSES.Add(typeof(FWildCreature), -97);
            FGameObjects.CLASSES.Add(typeof(FWizardBattleInfo), -96);
            FGameObjects.CLASSES.Add(typeof(FWizardBattleRating), -95);
            FGameObjects.CLASSES.Add(typeof(FWizardBattleRatingListRecord), -94);
            FGameObjects.CLASSES.Add(typeof(FWizardBattleResult), -93);
            FGameObjects.CLASSES.Add(typeof(GeoCoords), -92);
            FGameObjects.CLASSES.Add(typeof(GeoCoordsWithAccuracy), -91);
            FGameObjects.CLASSES.Add(typeof(IdAndCoords), -90);
            FGameObjects.CLASSES.Add(typeof(Tile), -89);
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
            FGameObjects.CLASSES.Add(typeof(Dictionary<,>), 15);
            FGameObjects.CLASSES.Add(typeof(SortedDictionary<,>), 16);
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
            FGameObjects.CLASSES.Add(typeof(FContestBattle), 85);
            FGameObjects.CLASSES.Add(typeof(FContestStats), 86);
            FGameObjects.CLASSES.Add(typeof(FContestUpdate), 87);
            FGameObjects.CLASSES.Add(typeof(FCreadex), 88);
            FGameObjects.CLASSES.Add(typeof(FCreadexChain), 89);
            FGameObjects.CLASSES.Add(typeof(FCreadexEntry), 90);
            FGameObjects.CLASSES.Add(typeof(FCreatureRequest), 91);
            FGameObjects.CLASSES.Add(typeof(FCreatureUpdate), 92);
            FGameObjects.CLASSES.Add(typeof(FDailyQuest), 93);
            FGameObjects.CLASSES.Add(typeof(FDungeonUpdate), 94);
            FGameObjects.CLASSES.Add(typeof(FEgg), 95);
            FGameObjects.CLASSES.Add(typeof(FEncounterBattleResult), 96);
            FGameObjects.CLASSES.Add(typeof(FEncounterDetails), 97);
            FGameObjects.CLASSES.Add(typeof(FEncounterUpdate), 98);
            FGameObjects.CLASSES.Add(typeof(FFeedMonsterResult), 99);
            FGameObjects.CLASSES.Add(typeof(FFightCreature), 100);
            FGameObjects.CLASSES.Add(typeof(FFightItem), 101);
            FGameObjects.CLASSES.Add(typeof(FFightRequest), 102);
            FGameObjects.CLASSES.Add(typeof(FFightUpdate), 103);
            FGameObjects.CLASSES.Add(typeof(FHatchedEggs), 104);
            FGameObjects.CLASSES.Add(typeof(FHatchingResult), 105);
            FGameObjects.CLASSES.Add(typeof(FInAppEventUpdate), 106);
            FGameObjects.CLASSES.Add(typeof(FIncubator), 107);
            FGameObjects.CLASSES.Add(typeof(FIngameNotifications), 108);
            FGameObjects.CLASSES.Add(typeof(FItemCreatureGroup), 109);
            FGameObjects.CLASSES.Add(typeof(FJournalUpdate), 110);
            FGameObjects.CLASSES.Add(typeof(FJournalRecord), 111);
            FGameObjects.CLASSES.Add(typeof(FLoot), 112);
            FGameObjects.CLASSES.Add(typeof(FLootItemArtifact), 113);
            FGameObjects.CLASSES.Add(typeof(FLootItemBuff), 114);
            FGameObjects.CLASSES.Add(typeof(FLootItemCandy), 115);
            FGameObjects.CLASSES.Add(typeof(FLootItemCoins), 116);
            FGameObjects.CLASSES.Add(typeof(FLootItemDust), 117);
            FGameObjects.CLASSES.Add(typeof(FLootItemExp), 118);
            FGameObjects.CLASSES.Add(typeof(FLootItemInstantUseItem), 119);
            FGameObjects.CLASSES.Add(typeof(FLootItemItem), 120);
            FGameObjects.CLASSES.Add(typeof(FLootItemRecipe), 121);
            FGameObjects.CLASSES.Add(typeof(FMentorshipAwardUpdate), 122);
            FGameObjects.CLASSES.Add(typeof(FMentorshipInfo), 123);
            FGameObjects.CLASSES.Add(typeof(FNewsArticle), 124);
            FGameObjects.CLASSES.Add(typeof(FNicknameValidationError), 125);
            FGameObjects.CLASSES.Add(typeof(FNicknameValidationResult), 126);
            FGameObjects.CLASSES.Add(typeof(FNotification), 127);
        }

        public const uint ProtocolVersion = 389771870;

        public const uint ClientVersion = 11808;

        public static readonly Dictionary<Type, sbyte> CLASSES = new Dictionary<Type, sbyte>();
    }
}
