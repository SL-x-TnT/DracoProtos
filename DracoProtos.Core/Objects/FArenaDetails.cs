using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FArenaDetails : FArenaDetailsBase
	{
		public bool HasRemoteBuildingControlCharges
		{
			get
			{
				return this.remoteBuildingControlChargesUsed < this.remoteBuildingControlChargesMaxCount;
			}
		}

        public override void Handle()
        {
        }
	}
}
