﻿using DracoProtos.Core.Enums;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FStudentBase : IFObject 
    {
        public AllianceType? allianceType;
        public int level;
        public string nickname;
        public string userId;

        public void ReadExternal(FInputStream stream)
        {
            this.allianceType = (AllianceType)stream.ReadDynamicObject();
            this.level = stream.ReadInt32();
            this.nickname = stream.ReadUtfString();
            this.userId = stream.ReadUtfString();
        }

        public void WriteExternal(FOutputStream stream)
        {
            stream.WriteDynamicObject(this.allianceType);
            stream.WriteInt32(this.level);
            stream.WriteUtfString(this.nickname);
            stream.WriteUtfString(this.userId);
        }
    }
}
