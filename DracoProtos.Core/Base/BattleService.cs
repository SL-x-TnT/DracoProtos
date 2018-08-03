using System;
using System.Collections.Generic;
using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
	public class BattleService
	{
		public Async<FUpdate> AddDefenderToArena(FBuildingRequest arena, FClientRequest clientRequest, string creatureId)
		{
			return new Async<FUpdate>("BattleService", "addDefenderToArena", new object[]
			{
				arena,
				clientRequest,
				creatureId
			});
		}

		public Async<FFightUpdate> AttackArena(FAttackArenaRequest attackRequest)
		{
			return new Async<FFightUpdate>("BattleService", "attackArena", new object[]
			{
				attackRequest
			});
		}

		public Async<FWizardBattleInfo> BuyExtraWizardBattles(string extraPackName)
		{
			return new Async<FWizardBattleInfo>("BattleService", "buyExtraWizardBattles", new object[]
			{
				extraPackName
			});
		}

		public Async<FFightUpdate> FindWizardBattle(List<string> selectedCreatures)
		{
			return new Async<FFightUpdate>("BattleService", "findWizardBattle", new object[]
			{
				selectedCreatures
			});
		}

		public Async<FUserCreaturesList> GetPossibleArenaAttackers()
		{
			return new Async<FUserCreaturesList>("BattleService", "getPossibleArenaAttackers", new object[0]);
		}

		public Async<FUserCreaturesList> GetPossibleArenaAttackersV2(List<string> selectedCreatures)
		{
			return new Async<FUserCreaturesList>("BattleService", "getPossibleArenaAttackersV2", new object[]
			{
				selectedCreatures
			});
		}

		public Async<FUserCreature> GetPossibleEncounterAttacker(ElementType elementType)
		{
			return new Async<FUserCreature>("BattleService", "getPossibleEncounterAttacker", new object[]
			{
				elementType
			});
		}

		public Async<FUserCreaturesList> GetPossibleWizardAttackers()
		{
			return new Async<FUserCreaturesList>("BattleService", "getPossibleWizardAttackers", new object[0]);
		}

		public Async<FWizardBattleInfo> GetWizardBattleInfo()
		{
			return new Async<FWizardBattleInfo>("BattleService", "getWizardBattleInfo", new object[0]);
		}

		public Async<bool> StartedWizardBattleV2(string battleId)
		{
			return new Async<bool>("BattleService", "startedWizardBattleV2", new object[]
			{
				battleId
			});
		}

		public Async<FUpdate> UpdateBattleDetails(FBuildingRequest buildingRequest, FClientRequest request, FFightRequest fightRequest)
		{
			return new Async<FUpdate>("BattleService", "updateBattleDetails", new object[]
			{
				buildingRequest,
				request,
				fightRequest
			});
		}

		public Async<FWizardBattleResult> UpdateWizardBattle(FFightRequest fightRequest)
		{
			return new Async<FWizardBattleResult>("BattleService", "updateWizardBattle", new object[]
			{
				fightRequest
			});
		}
	}
}
