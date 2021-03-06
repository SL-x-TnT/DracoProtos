using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FClientInfoBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.deviceModel = stream.ReadUtfString();
			this.googleAdvertisingId = (string)stream.ReadDynamicObject();
			this.googleTrackingEnabled = stream.ReadBoolean();
			this.iOsAdvertisingIdentifier = (string)stream.ReadDynamicObject();
			this.iOsAdvertisingTrackingEnabled = stream.ReadBoolean();
			this.iOsVendorIdentifier = (string)stream.ReadDynamicObject();
			this.language = stream.ReadUtfString();
			this.platform = stream.ReadUtfString();
			this.platformVersion = stream.ReadUtfString();
			this.revision = stream.ReadUtfString();
			this.screenHeight = stream.ReadInt32();
			this.screenWidth = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteUtfString(this.deviceModel);
			stream.WriteDynamicObject(this.googleAdvertisingId);
			stream.WriteBoolean(this.googleTrackingEnabled);
			stream.WriteDynamicObject(this.iOsAdvertisingIdentifier);
			stream.WriteBoolean(this.iOsAdvertisingTrackingEnabled);
			stream.WriteDynamicObject(this.iOsVendorIdentifier);
			stream.WriteUtfString(this.language);
			stream.WriteUtfString(this.platform);
			stream.WriteUtfString(this.platformVersion);
			stream.WriteUtfString(this.revision);
			stream.WriteInt32(this.screenHeight);

			stream.WriteInt32(this.screenWidth);
		}

		public string platform;

		public string platformVersion;

		public string revision;

		public string deviceModel;

		public int screenWidth;

		public int screenHeight;

		public string language;

		public string iOsAdvertisingIdentifier;

		public bool iOsAdvertisingTrackingEnabled;

		public string iOsVendorIdentifier;

		public string googleAdvertisingId;

		public bool googleTrackingEnabled;
	}
}
