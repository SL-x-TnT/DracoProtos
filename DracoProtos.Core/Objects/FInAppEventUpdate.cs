using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FInAppEventUpdate : FInAppEventUpdateBase
	{
		public override void Handle()
		{
			/*foreach (InAppEventInfo data in this.events)
			{
				EventBus.IN_APP_EVENT.Dispatch(data);
			}*/
		}
	}
}
