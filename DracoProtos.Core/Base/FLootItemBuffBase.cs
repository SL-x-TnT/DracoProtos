using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FLootItemBuffBase : FBaseLootItem
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.buff = (BuffConfig)stream.ReadStaticObject(typeof(BuffConfig));
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticObject(this.buff);
		}

		public BuffConfig buff;
	}
}
