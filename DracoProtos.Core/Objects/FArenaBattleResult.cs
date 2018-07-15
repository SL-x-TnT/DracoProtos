using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FArenaBattleResult : FArenaBattleResultBase
	{
		public override void Handle()
		{
			//EventBus.SHOW_ARENA_BATTLE_RESULT.Dispatch(this);
		}
	}
}
