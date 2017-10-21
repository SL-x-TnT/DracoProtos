using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
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
