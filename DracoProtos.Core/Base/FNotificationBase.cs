using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FNotificationBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.message = stream.ReadUtfString();
			this.title = stream.ReadUtfString();
			this.type = stream.ReadUtfString();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteUtfString(this.message);
			stream.WriteUtfString(this.title);
			stream.WriteUtfString(this.type);
		}

		public string type;

		public string title;

		public string message;
	}
}
