using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
    public class FContestUpdate : FContestUpdateBase
	{
		public bool IsPreparingStage
		{
			get
			{
				return this.stage == ContestStage.PREPARING;
			}
		}

		public bool IsProgressStage
		{
			get
			{
				return this.stage == ContestStage.PROGRESS;
			}
		}

		public bool IsCompletedStage
		{
			get
			{
				return this.stage == ContestStage.COMPLETED;
			}
		}

		public override void Handle()
		{
		}
    }
}
