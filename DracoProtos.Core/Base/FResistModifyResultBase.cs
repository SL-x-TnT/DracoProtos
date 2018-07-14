using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FResistModifyResultBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.creature = (FUserCreature)stream.ReadStaticObject(typeof(FUserCreature));
			this.modifyDetails = (FResistModifyDetails)stream.ReadStaticObject(typeof(FResistModifyDetails));
			this.newResistValue = stream.ReadBoolean();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticObject(this.creature);
			stream.WriteStaticObject(this.modifyDetails);
			stream.WriteBoolean(this.newResistValue);
		}

		public bool newResistValue;

		public FUserCreature creature;

		public FResistModifyDetails modifyDetails;
	}
}
