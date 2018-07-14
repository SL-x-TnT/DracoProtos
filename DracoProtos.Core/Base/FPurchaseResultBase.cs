using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FPurchaseResultBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.avaUpdate = (FAvaUpdate)stream.ReadStaticObject(typeof(FAvaUpdate));
			this.creadex = (FCreadex)stream.ReadDynamicObject();
			this.creature = stream.ReadStaticMap<FUserCreature, bool>(true, true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticObject(this.avaUpdate);
			stream.WriteDynamicObject(this.creadex);
			stream.WriteStaticMap(this.creature, true, true);
		}

		public FAvaUpdate avaUpdate;

		public Dictionary<FUserCreature, bool> creature;

		public FCreadex creadex;
	}
}
