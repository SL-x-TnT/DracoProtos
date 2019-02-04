using System;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FMentorshipAwardUpdateBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.creadex = (FCreadex)stream.ReadDynamicObject();
			this.creatureType = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.gotCandiesCount = stream.ReadInt32();
			this.gotDragon = stream.ReadBoolean();
			this.userCreature = (FUserCreature)stream.ReadDynamicObject();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDynamicObject(this.creadex);
			stream.WriteEnum(this.creatureType);
			stream.WriteInt32(this.gotCandiesCount);
			stream.WriteBoolean(this.gotDragon);
			stream.WriteDynamicObject(this.userCreature);
		}

		public bool gotDragon;

		public CreatureType creatureType;

		public int gotCandiesCount;

		public FCreadex creadex;

		public FUserCreature userCreature;
	}
}
