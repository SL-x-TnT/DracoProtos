using System;
using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
	public class EncounterService
	{
		public Async<object> GiveUpEncounter()
		{
			return new Async<object>("EncounterService", "giveUpEncounter", new object[0]);
		}

		public Async<FEncounterUpdate> StartEncounter(FStartEncounterRequest attackRequest)
		{
			return new Async<FEncounterUpdate>("EncounterService", "startEncounter", new object[]
			{
				attackRequest
			});
		}

		public Async<FEncounterBattleResult> UpdateEncounterDetails(FFightRequest fightRequest)
		{
			return new Async<FEncounterBattleResult>("EncounterService", "updateEncounterDetails", new object[]
			{
				fightRequest
			});
		}
	}
}
