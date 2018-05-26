﻿using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;
using System.Collections.Generic;

namespace DracoProtos.Core.Base
{
    public abstract class FIngameNotificationsBase : IFObject
    {
        public List<FNotification> notifications;

        public void ReadExternal(FInputStream stream)
        {
            this.notifications = stream.ReadStaticList<FNotification>(true);
        }

        public void WriteExternal(FOutputStream stream)
        {
            stream.WriteStaticCollection(this.notifications, true);
        }
    }
}
