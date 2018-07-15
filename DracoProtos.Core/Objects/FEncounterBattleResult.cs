using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FEncounterBattleResult : FEncounterBattleResultBase
	{
		public override void Handle()
		{
			//EventBus.SHOW_ENCOUNTER_BATTLE_RESULT.Dispatch(this);
		}
	}
}
