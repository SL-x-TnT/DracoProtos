using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FEncounterUpdateBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.attacker = (FFightCreature)stream.ReadStaticObject(typeof(FFightCreature));
			this.defender = (FFightCreature)stream.ReadStaticObject(typeof(FFightCreature));
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticObject(this.attacker);
			stream.WriteStaticObject(this.defender);
		}

		public FFightCreature attacker;

		public FFightCreature defender;
	}
}
