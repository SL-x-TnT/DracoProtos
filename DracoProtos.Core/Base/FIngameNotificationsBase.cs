using System;
using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FIngameNotificationsBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.notifications = stream.ReadStaticList<FNotification>(true);
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticCollection(this.notifications, true);
		}

		public List<FNotification> notifications;
	}
}
