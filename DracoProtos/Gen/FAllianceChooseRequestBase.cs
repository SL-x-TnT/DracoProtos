using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FAllianceChooseRequestBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.bonus = stream.ReadInt32();
			this.oneOption = stream.ReadBoolean();
			this.recommendedType = (AllianceType?)stream.ReadDynamicObject();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteInt32(this.bonus);
			stream.WriteBoolean(this.oneOption);
			stream.WriteDynamicObject(this.recommendedType);
		}

		public AllianceType? recommendedType;

		public int bonus;

		public bool oneOption;
	}
}
