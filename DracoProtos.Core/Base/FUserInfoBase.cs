using System;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FUserInfoBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.alliance = (AllianceType?)stream.ReadDynamicObject();
			this.avatarAppearanceDetails = stream.ReadInt32();
			this.devMode = stream.ReadBoolean();
			this.internalUser = stream.ReadBoolean();
			this.newLicense = stream.ReadInt32();
			this.nickname = stream.ReadUtfString();
			this.sendClientLog = stream.ReadBoolean();
			this.serverTime = stream.ReadInt64();
			this.showAdvices = stream.ReadBoolean();
			this.userId = stream.ReadUtfString();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDynamicObject(this.alliance);
			stream.WriteInt32(this.avatarAppearanceDetails);
			stream.WriteBoolean(this.devMode);
			stream.WriteBoolean(this.internalUser);
			stream.WriteInt32(this.newLicense);
			stream.WriteUtfString(this.nickname);
			stream.WriteBoolean(this.sendClientLog);
			stream.WriteInt64(this.serverTime);
			stream.WriteBoolean(this.showAdvices);
			stream.WriteUtfString(this.userId);
		}

		public string userId;

		public bool devMode;

		public bool internalUser;

		public bool sendClientLog;

		public bool showAdvices;

		public string nickname;

		public int avatarAppearanceDetails;

		public AllianceType? alliance;

		public int newLicense;

		public long serverTime;
	}
}
