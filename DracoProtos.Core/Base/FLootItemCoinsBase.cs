using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FLootItemCoinsBase : FBaseLootItem
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
		}
	}
}
