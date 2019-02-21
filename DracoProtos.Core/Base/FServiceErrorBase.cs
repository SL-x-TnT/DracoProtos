using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FServiceErrorBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.args = stream.ReadStaticArray<object>(false);
			this.cause = stream.ReadUtfString();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticCollection(this.args, false);
			stream.WriteUtfString(this.cause);
		}

		public string cause;

		public object[] args;
	}
}
