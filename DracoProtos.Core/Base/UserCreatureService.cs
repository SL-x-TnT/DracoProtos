using System.Collections.Generic;
using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
    public class UserCreatureService
	{
		public Async<object> AddCreatureToGroup(string creatureId, int group)
		{
			return new Async<object>("UserCreatureService", "addCreatureToGroup", new object[]
			{
				creatureId,
				group
			});
		}

		public Async<FUserCreature> ChangeCreatureSpecialization(string creatureId)
		{
			return new Async<FUserCreature>("UserCreatureService", "changeCreatureSpecialization", new object[]
			{
				creatureId
			});
		}

		public Async<FUpdate> ConvertCreaturesToCandies(List<string> creatureIds, bool sendUpdate)
		{
			return new Async<FUpdate>("UserCreatureService", "convertCreaturesToCandies", new object[]
			{
				creatureIds,
				sendUpdate
			});
		}

		public Async<FUserCreatureUpdate> EnhanceCreature(string creatureId)
		{
			return new Async<FUserCreatureUpdate>("UserCreatureService", "enhanceCreature", new object[]
			{
				creatureId
			});
		}

		public Async<FUserCreatureUpdate> EvolveCreature(string creatureId, CreatureType toType)
		{
			return new Async<FUserCreatureUpdate>("UserCreatureService", "evolveCreature", new object[]
			{
				creatureId,
				toType
			});
		}

		public Async<FCreadex> GetCreadex()
		{
			return new Async<FCreadex>("UserCreatureService", "getCreadex", new object[0]);
		}

		public Async<FUserHatchingInfo> GetHatchingInfo()
		{
			return new Async<FUserHatchingInfo>("UserCreatureService", "getHatchingInfo", new object[0]);
		}

		public Async<FResistModifyDetails> GetResistDetails(string creatureId)
		{
			return new Async<FResistModifyDetails>("UserCreatureService", "getResistDetails", new object[]
			{
				creatureId
			});
		}

		public Async<FUserCreaturesList> GetUserCreatures()
		{
			return new Async<FUserCreaturesList>("UserCreatureService", "getUserCreatures", new object[0]);
		}

		public Async<FResistModifyResult> ModifyResist(string creatureId, HashSet<string> sacrificeCreatureIds)
		{
			return new Async<FResistModifyResult>("UserCreatureService", "modifyResist", new object[]
			{
				creatureId,
				sacrificeCreatureIds
			});
		}

		public Async<FHatchingResult> OpenHatchedEgg(string incubatorId)
		{
			return new Async<FHatchingResult>("UserCreatureService", "openHatchedEgg", new object[]
			{
				incubatorId
			});
		}

		public Async<FUserCreature> RemasterCreature(string creatureId, bool mainSkill)
		{
			return new Async<FUserCreature>("UserCreatureService", "remasterCreature", new object[]
			{
				creatureId,
				mainSkill
			});
		}

		public Async<FUserCreature> SetCreatureAlias(string creatureId, string alias)
		{
			return new Async<FUserCreature>("UserCreatureService", "setCreatureAlias", new object[]
			{
				creatureId,
				alias
			});
		}

		public Async<object> StartHatchingEgg(string eggId, string incubatorId)
		{
			return new Async<object>("UserCreatureService", "startHatchingEgg", new object[]
			{
				eggId,
				incubatorId
			});
		}

		public Async<object> StartHatchingEggInRoost(string eggId, FBuildingRequest roost, int slotIndex)
		{
			return new Async<object>("UserCreatureService", "startHatchingEggInRoost", new object[]
			{
				eggId,
				roost,
				slotIndex
			});
		}

		public Async<float> UsePotion(ItemType type, string creatureId)
		{
			return new Async<float>("UserCreatureService", "usePotion", new object[]
			{
				type,
				creatureId
			});
		}
	}
}
