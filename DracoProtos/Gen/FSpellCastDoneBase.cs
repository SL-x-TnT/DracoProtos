using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FSpellCastDoneBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.altarCoords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
			this.spellType = (SpellType)stream.ReadEnum(typeof(SpellType));
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticObject(this.altarCoords);
			stream.WriteEnum(this.spellType);
		}

		public GeoCoords altarCoords;

		public SpellType spellType;
	}
}
