using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FContestRatingAwardBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.dust = stream.ReadInt32();
			this.month = stream.ReadInt32();
			this.place = stream.ReadInt32();
			this.runes = stream.ReadInt32();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteInt32(this.dust);
			stream.WriteInt32(this.month);
			stream.WriteInt32(this.place);
			stream.WriteInt32(this.runes);
		}

		public int place;

		public int month;

		public int dust;

		public int runes;
	}
}
