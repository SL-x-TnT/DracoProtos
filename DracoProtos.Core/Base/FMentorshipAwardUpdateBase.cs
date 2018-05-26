﻿using DracoProtos.Core.Enums;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FMentorshipAwardUpdateBase : IFObject
    {
        public FCreadex cReadex;
        public CreatureType creatureType;
        public int gotCandiesCount;
        public bool gotDragon;
        public FUserCreature userCreature;

        public void ReadExternal(FInputStream stream)
        {
            this.cReadex = (FCreadex)stream.ReadDynamicObject();
            this.creatureType = (CreatureType)stream.ReadDynamicObject();
            this.gotCandiesCount = stream.ReadInt32();
            this.gotDragon = stream.ReadBoolean();
            this.userCreature = (FUserCreature)stream.ReadDynamicObject();
        }

        public void WriteExternal(FOutputStream stream)
        {
            stream.WriteDynamicObject(this.cReadex);
            stream.WriteDynamicObject(this.creatureType);
            stream.WriteInt32(this.gotCandiesCount);
            stream.WriteBoolean(this.gotDragon);
            stream.WriteDynamicObject(this.userCreature);
        }
    }
}
