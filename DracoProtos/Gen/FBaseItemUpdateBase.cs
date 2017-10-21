using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FBaseItemUpdateBase : FObject
	{
		public virtual void ReadExternal(FInputStream stream)
		{
		}

		public virtual void WriteExternal(FOutputStream stream)
		{
		}
	}
}
