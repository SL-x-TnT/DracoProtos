using System.Collections.Generic;
using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
    public class PlayerService
	{
		public Async<object> AcknowledgeNotification(string type)
		{
			return new Async<object>("PlayerService", "acknowledgeNotification", new object[]
			{
				type
			});
		}

		public Async<FAvaUpdate> Buy(ItemType type, int amount, int price)
		{
			return new Async<FAvaUpdate>("PlayerService", "buy", new object[]
			{
				type,
				amount,
				price
			});
		}

		public Async<FAvaUpdate> BuyArtifact(ArtifactName name)
		{
			return new Async<FAvaUpdate>("PlayerService", "buyArtifact", new object[]
			{
				name
			});
		}

		public Async<FAvaUpdate> BuyCoins(string productId, string receipt, string localizedPriceStr, string currency, double localizedPrice)
		{
			return new Async<FAvaUpdate>("PlayerService", "buyCoins", new object[]
			{
				productId,
				receipt,
				localizedPriceStr,
				currency,
				localizedPrice
			});
		}

		public Async<FPurchaseResult> BuyFromStore(string productId, string receipt, string localizedPriceStr, string currency, double localizedPrice)
		{
			return new Async<FPurchaseResult>("PlayerService", "buyFromStore", new object[]
			{
				productId,
				receipt,
				localizedPriceStr,
				currency,
				localizedPrice
			});
		}

		public Async<FAvaUpdate> BuySaleSet(SaleSetConfig saleSet)
		{
			return new Async<FAvaUpdate>("PlayerService", "buySaleSet", new object[]
			{
				saleSet
			});
		}

		public Async<FObeliskDetails> ChangeDailyQuest(FClientRequest request, FBuildingRequest building)
		{
			return new Async<FObeliskDetails>("PlayerService", "changeDailyQuest", new object[]
			{
				request,
				building
			});
		}

		public Async<object> ChangeLanguage(string language)
		{
			return new Async<object>("PlayerService", "changeLanguage", new object[]
			{
				language
			});
		}

		public Async<FMentorshipInfo> ChooseMentor(string code)
		{
			return new Async<FMentorshipInfo>("PlayerService", "chooseMentor", new object[]
			{
				code
			});
		}

		public Async<FUpdate> CollectContestRatingAward()
		{
			return new Async<FUpdate>("PlayerService", "collectContestRatingAward", new object[0]);
		}

		public Async<FActiveObjectsUpdate> CollectTribute(int currentUtcOffsetSeconds)
		{
			return new Async<FActiveObjectsUpdate>("PlayerService", "collectTribute", new object[]
			{
				currentUtcOffsetSeconds
			});
		}

		public Async<FActiveObjectsUpdate> GetActiveObjects(int currentUtcOffsetSeconds)
		{
			return new Async<FActiveObjectsUpdate>("PlayerService", "getActiveObjects", new object[]
			{
				currentUtcOffsetSeconds
			});
		}

		public Async<FArtifactsUpdate> GetArtifacts()
		{
			return new Async<FArtifactsUpdate>("PlayerService", "getArtifacts", new object[0]);
		}

		public Async<FAvaUpdate> GetAvaUpdate()
		{
			return new Async<FAvaUpdate>("PlayerService", "getAvaUpdate", new object[0]);
		}

		public Async<FCollectorRating> GetCollectorGlobalRatingTop()
		{
			return new Async<FCollectorRating>("PlayerService", "getCollectorGlobalRatingTop", new object[0]);
		}

		public Async<FCollectorRating> GetCollectorRegionalRatingTop()
		{
			return new Async<FCollectorRating>("PlayerService", "getCollectorRegionalRatingTop", new object[0]);
		}

		public Async<FContestRating> GetContestGlobalRatingTop()
		{
			return new Async<FContestRating>("PlayerService", "getContestGlobalRatingTop", new object[0]);
		}

		public Async<FContestRating> GetContestRegionalRatingTop()
		{
			return new Async<FContestRating>("PlayerService", "getContestRegionalRatingTop", new object[0]);
		}

		public Async<FDailyQuest> GetDailyQuest()
		{
			return new Async<FDailyQuest>("PlayerService", "getDailyQuest", new object[0]);
		}

		public Async<FPurchaseResult> GetFreeFromStore(string productId)
		{
			return new Async<FPurchaseResult>("PlayerService", "getFreeFromStore", new object[]
			{
				productId
			});
		}

		public Async<FJournalUpdate> GetJournalUpdate()
		{
			return new Async<FJournalUpdate>("PlayerService", "getJournalUpdate", new object[0]);
		}

		public Async<FMentorshipInfo> GetMentorshipInfo()
		{
			return new Async<FMentorshipInfo>("PlayerService", "getMentorshipInfo", new object[0]);
		}

		public Async<FShopConfig> GetShopConfig()
		{
			return new Async<FShopConfig>("PlayerService", "getShopConfig", new object[0]);
		}

		public Async<FShopConfig> GetShopConfigIfModified(FShopConfigRequest configRequest)
		{
			return new Async<FShopConfig>("PlayerService", "getShopConfigIfModified", new object[]
			{
				configRequest
			});
		}

		public Async<FWeeklyQuest> GetWeeklyQuest(FClientRequest request)
		{
			return new Async<FWeeklyQuest>("PlayerService", "getWeeklyQuest", new object[]
			{
				request
			});
		}

		public Async<FWizardBattleRating> GetWizardGlobalRatingTop()
		{
			return new Async<FWizardBattleRating>("PlayerService", "getWizardGlobalRatingTop", new object[0]);
		}

		public Async<FWizardBattleRating> GetWizardRegionalRatingTop()
		{
			return new Async<FWizardBattleRating>("PlayerService", "getWizardRegionalRatingTop", new object[0]);
		}

		public Async<FMentorshipInfo> KickStudent(string studentId)
		{
			return new Async<FMentorshipInfo>("PlayerService", "kickStudent", new object[]
			{
				studentId
			});
		}

		public Async<object> MarkAllianceChooseScreenSeen()
		{
			return new Async<object>("PlayerService", "markAllianceChooseScreenSeen", new object[0]);
		}

		public Async<object> OnClientStarted()
		{
			return new Async<object>("PlayerService", "onClientStarted", new object[0]);
		}

		public Async<FObeliskDetails> OpenWeeklyQuestFragment(FClientRequest request, FBuildingRequest building)
		{
			return new Async<FObeliskDetails>("PlayerService", "openWeeklyQuestFragment", new object[]
			{
				request,
				building
			});
		}

		public Async<FAvaUpdate> PurchaseError(string productId, string store, string receiptStr, string localizedPriceStr, string currency, string status)
		{
			return new Async<FAvaUpdate>("PlayerService", "purchaseError", new object[]
			{
				productId,
				store,
				receiptStr,
				localizedPriceStr,
				currency,
				status
			});
		}

		public Async<FMentorshipInfo> RegenerateMentorCode()
		{
			return new Async<FMentorshipInfo>("PlayerService", "regenerateMentorCode", new object[0]);
		}

		public Async<FArtifactsUpdate> RemoveArtifact(ArtifactName artifact)
		{
			return new Async<FArtifactsUpdate>("PlayerService", "removeArtifact", new object[]
			{
				artifact
			});
		}

		public Async<object> ResetWeeklyQuest(FClientRequest request)
		{
			return new Async<object>("PlayerService", "resetWeeklyQuest", new object[]
			{
				request
			});
		}

		public Async<FUpdateNicknameResult> SaveNickname(string nickname)
		{
			return new Async<FUpdateNicknameResult>("PlayerService", "saveNickname", new object[]
			{
				nickname
			});
		}

		public Async<object> SaveUserSettings(int avatarAppearanceDetails)
		{
			return new Async<object>("PlayerService", "saveUserSettings", new object[]
			{
				avatarAppearanceDetails
			});
		}

		public Async<FUpdate> SelectAlliance(AllianceType alliance, int bonus)
		{
			return new Async<FUpdate>("PlayerService", "selectAlliance", new object[]
			{
				alliance,
				bonus
			});
		}

		public Async<FAvaUpdate> SelectBuddy(string creatureId)
		{
			return new Async<FAvaUpdate>("PlayerService", "selectBuddy", new object[]
			{
				creatureId
			});
		}

		public Async<object> UpdatePushRegistrationId(string deviceId, string providerName, string registrationId)
		{
			return new Async<object>("PlayerService", "updatePushRegistrationId", new object[]
			{
				deviceId,
				providerName,
				registrationId
			});
		}

		public Async<FAvaUpdate> UpgradeBag()
		{
			return new Async<FAvaUpdate>("PlayerService", "upgradeBag", new object[0]);
		}

		public Async<FAvaUpdate> UpgradeCreatureStorage()
		{
			return new Async<FAvaUpdate>("PlayerService", "upgradeCreatureStorage", new object[0]);
		}

		public Async<FArtifactsUpdate> WearOnArtifact(ArtifactName artifact, int place)
		{
			return new Async<FArtifactsUpdate>("PlayerService", "wearOnArtifact", new object[]
			{
				artifact,
				place
			});
		}

		public Async<FArtifactsUpdate> WearOnArtifacts(List<ArtifactName> artifacts)
		{
			return new Async<FArtifactsUpdate>("PlayerService", "wearOnArtifacts", new object[]
			{
				artifacts
			});
		}
	}
}
