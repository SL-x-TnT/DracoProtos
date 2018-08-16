using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FShopConfigRequestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.shopConfigHash = stream.ReadStaticArray<sbyte>(true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticCollection(this.shopConfigHash, true);
		}

		public sbyte[] shopConfigHash;
	}
}
