using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FUpdateBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.items = stream.ReadStaticList<FBaseItemUpdate>(false);
			this.speed = (float?)stream.ReadDynamicObject();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticCollection(this.items, false);
			stream.WriteDynamicObject(this.speed);
		}

		public List<FBaseItemUpdate> items;

		public float? speed;
	}
}
