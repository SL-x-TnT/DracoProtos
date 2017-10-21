using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FUserInfoBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.alliance = (AllianceType?)stream.ReadDynamicObject();
			this.avatarAppearanceDetails = stream.ReadInt32();
			this.devMode = stream.ReadBoolean();
			this.nickname = stream.ReadUtfString();
			this.userId = stream.ReadUtfString();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDynamicObject(this.alliance);
			stream.WriteInt32(this.avatarAppearanceDetails);
			stream.WriteBoolean(this.devMode);
			stream.WriteUtfString(this.nickname);
			stream.WriteUtfString(this.userId);
		}

		public string userId;

		public bool devMode;

		public string nickname;

		public int avatarAppearanceDetails;

		public AllianceType? alliance;
	}
}
