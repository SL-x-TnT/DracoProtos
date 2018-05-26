﻿using DracoProtos.Core.Enums;
using DracoProtos.Core.Serializer;
using System.Collections.Generic;

namespace DracoProtos.Core.Base
{
    public abstract class FRecipeConfigBase : IFObject
    {
        public int duration;
        public int percent;
        public List<ItemType> runes;

        public void ReadExternal(FInputStream stream)
        {
            this.duration = stream.ReadInt32();
            this.percent = stream.ReadInt32();
            this.runes = stream.ReadStaticList<ItemType>(true);
        }

        public void WriteExternal(FOutputStream stream)
        {
            stream.WriteInt32(this.duration);
            stream.WriteInt32(this.percent);
            stream.WriteDynamicCollection(this.runes, true);
        }
    }
}
