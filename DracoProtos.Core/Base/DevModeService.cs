using System.Collections.Generic;
using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
    public class DevModeService
	{
		public Async<FAvaUpdate> AddRunes()
		{
			return new Async<FAvaUpdate>("DevModeService", "AddRunes", new object[0]);
		}

		public Async<object> AddAllCreatures()
		{
			return new Async<object>("DevModeService", "addAllCreatures", new object[0]);
		}

		public Async<object> AddAllLogEvents()
		{
			return new Async<object>("DevModeService", "addAllLogEvents", new object[0]);
		}

		public Async<object> AddArenaExperience(FBuildingRequest building, int layer, int expToAdd)
		{
			return new Async<object>("DevModeService", "addArenaExperience", new object[]
			{
				building,
				layer,
				expToAdd
			});
		}

		public Async<FAvaUpdate> AddArtifact(ArtifactName artifactName)
		{
			return new Async<FAvaUpdate>("DevModeService", "addArtifact", new object[]
			{
				artifactName
			});
		}

		public Async<FAvaUpdate> AddBuff(string buffName, int value)
		{
			return new Async<FAvaUpdate>("DevModeService", "addBuff", new object[]
			{
				buffName,
				value
			});
		}

		public Async<FAvaUpdate> AddCandies(int amount)
		{
			return new Async<FAvaUpdate>("DevModeService", "addCandies", new object[]
			{
				amount
			});
		}

		public Async<FAvaUpdate> AddCoins(int amount)
		{
			return new Async<FAvaUpdate>("DevModeService", "addCoins", new object[]
			{
				amount
			});
		}

		public Async<object> AddContestCompletedEvent(int contestPlace, float contestScore)
		{
			return new Async<object>("DevModeService", "addContestCompletedEvent", new object[]
			{
				contestPlace,
				contestScore
			});
		}

		public Async<object> AddContestRatingAward(int month, int place, int dust, int runes)
		{
			return new Async<object>("DevModeService", "addContestRatingAward", new object[]
			{
				month,
				place,
				dust,
				runes
			});
		}

		public Async<FAvaUpdate> AddDust(int amount)
		{
			return new Async<FAvaUpdate>("DevModeService", "addDust", new object[]
			{
				amount
			});
		}

		public Async<object> AddExistingCreatures()
		{
			return new Async<object>("DevModeService", "addExistingCreatures", new object[0]);
		}

		public Async<FUpdate> AddExp(int amount)
		{
			return new Async<FUpdate>("DevModeService", "addExp", new object[]
			{
				amount
			});
		}

		public Async<FAvaUpdate> AddFood()
		{
			return new Async<FAvaUpdate>("DevModeService", "addFood", new object[0]);
		}

		public Async<FAvaUpdate> AddItems(ItemType itemType, int amount)
		{
			return new Async<FAvaUpdate>("DevModeService", "addItems", new object[]
			{
				itemType,
				amount
			});
		}

		public Async<FAvaUpdate> AddLure()
		{
			return new Async<FAvaUpdate>("DevModeService", "addLure", new object[0]);
		}

		public Async<object> AddMigrationWorker(string migrationWorkerClass)
		{
			return new Async<object>("DevModeService", "addMigrationWorker", new object[]
			{
				migrationWorkerClass
			});
		}

		public Async<FUserCreature> AddRandomCreature()
		{
			return new Async<FUserCreature>("DevModeService", "addRandomCreature", new object[0]);
		}

		public Async<FAvaUpdate> AddRandomEgg(ItemType eggType)
		{
			return new Async<FAvaUpdate>("DevModeService", "addRandomEgg", new object[]
			{
				eggType
			});
		}

		public Async<FAvaUpdate> AddRecipes()
		{
			return new Async<FAvaUpdate>("DevModeService", "addRecipes", new object[0]);
		}

		public Async<FHatchingResult> AddReferralDragon()
		{
			return new Async<FHatchingResult>("DevModeService", "addReferralDragon", new object[0]);
		}

		public Async<object> AddWizardBattleRatingEvent(bool victory, float rewardPercent)
		{
			return new Async<object>("DevModeService", "addWizardBattleRatingEvent", new object[]
			{
				victory,
				rewardPercent
			});
		}

		public Async<FUpdate> CastRecipe(RecipeType recipeType)
		{
			return new Async<FUpdate>("DevModeService", "castRecipe", new object[]
			{
				recipeType
			});
		}

		public Async<FUpdate> CastSpell(SpellType spell)
		{
			return new Async<FUpdate>("DevModeService", "castSpell", new object[]
			{
				spell
			});
		}

		public Async<int> CatchMonsterLimitCount()
		{
			return new Async<int>("DevModeService", "catchMonsterLimitCount", new object[0]);
		}

		public Async<FQuestUpdate> ChangeDailyQuest()
		{
			return new Async<FQuestUpdate>("DevModeService", "changeDailyQuest", new object[0]);
		}

		public Async<FUserCreature> DamageCreature(string id, int dmg)
		{
			return new Async<FUserCreature>("DevModeService", "damageCreature", new object[]
			{
				id,
				dmg
			});
		}

		public Async<object> DeleteUser(string userId)
		{
			return new Async<object>("DevModeService", "deleteUser", new object[]
			{
				userId
			});
		}

		public Async<object> ExecuteCql(string cql)
		{
			return new Async<object>("DevModeService", "executeCql", new object[]
			{
				cql
			});
		}

		public Async<FAvaUpdate> GetAvaUpdate()
		{
			return new Async<FAvaUpdate>("DevModeService", "getAvaUpdate", new object[0]);
		}

		public Async<double> GetCurrentVisionRadius()
		{
			return new Async<double>("DevModeService", "getCurrentVisionRadius", new object[0]);
		}

		public Async<byte[]> GetDefaultConfigBytes()
		{
			return new Async<byte[]>("DevModeService", "getDefaultConfigBytes", new object[0]);
		}

		public Async<long?> GetPushNotification(string userId, string type)
		{
			return new Async<long?>("DevModeService", "getPushNotification", new object[]
			{
				userId,
				type
			});
		}

		public Async<int> GetSuspicionPoints()
		{
			return new Async<int>("DevModeService", "getSuspicionPoints", new object[0]);
		}

		public Async<List<string>> GetSuspiciousList()
		{
			return new Async<List<string>>("DevModeService", "getSuspiciousList", new object[0]);
		}

		public Async<object> GiveInstantItem(InstantUseItem itemType, long value)
		{
			return new Async<object>("DevModeService", "giveInstantItem", new object[]
			{
				itemType,
				value
			});
		}

		public Async<object> GiveLootItem(ItemType itemType)
		{
			return new Async<object>("DevModeService", "giveLootItem", new object[]
			{
				itemType
			});
		}

		public Async<object> KillCreature(string creatureId)
		{
			return new Async<object>("DevModeService", "killCreature", new object[]
			{
				creatureId
			});
		}

		public Async<FUpdate> LevelUp(int levels)
		{
			return new Async<FUpdate>("DevModeService", "levelUp", new object[]
			{
				levels
			});
		}

		public Async<FWeeklyQuestFragment> OpenMapFragment()
		{
			return new Async<FWeeklyQuestFragment>("DevModeService", "openMapFragment", new object[0]);
		}

		public Async<long> PauseAndReset(string testName)
		{
			return new Async<long>("DevModeService", "pauseAndReset", new object[]
			{
				testName
			});
		}

		public Async<object> ProcessNotificationsNow()
		{
			return new Async<object>("DevModeService", "processNotificationsNow", new object[0]);
		}

		public Async<object> ResetMigrationWorkers()
		{
			return new Async<object>("DevModeService", "resetMigrationWorkers", new object[0]);
		}

		public Async<object> ResetRemasterCooldown()
		{
			return new Async<object>("DevModeService", "resetRemasterCooldown", new object[0]);
		}

		public Async<int> Resume()
		{
			return new Async<int>("DevModeService", "resume", new object[0]);
		}

		public Async<object> RunMigration()
		{
			return new Async<object>("DevModeService", "runMigration", new object[0]);
		}

		public Async<object> SendPushNotification(long delay)
		{
			return new Async<object>("DevModeService", "sendPushNotification", new object[]
			{
				delay
			});
		}

		public Async<FArenaDetails> SetArenaAllianceType(FBuildingRequest building, int layer, AllianceType type)
		{
			return new Async<FArenaDetails>("DevModeService", "setArenaAllianceType", new object[]
			{
				building,
				layer,
				type
			});
		}

		public Async<long> TimeJump(long millis)
		{
			return new Async<long>("DevModeService", "timeJump", new object[]
			{
				millis
			});
		}

		public Async<object> UploadConfig(byte[] bytes)
		{
			return new Async<object>("DevModeService", "uploadConfig", new object[]
			{
				bytes
			});
		}

		public Async<FUpdate> WeeklyQuestDig()
		{
			return new Async<FUpdate>("DevModeService", "weeklyQuestDig", new object[0]);
		}
	}
}
