using System;
using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FNewsArticleBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.activeNewsIds = stream.ReadStaticHashSet<string>(true);
			this.activeOfferCurrent = stream.ReadInt32();
			this.activeOfferTotal = stream.ReadInt32();
			this.body = stream.ReadUtfString();
			this.freshNewsDate = stream.ReadInt64();
			this.id = stream.ReadUtfString();
			this.title = stream.ReadUtfString();
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteStaticEnumerable(this.activeNewsIds, true);
			stream.WriteInt32(this.activeOfferCurrent);
			stream.WriteInt32(this.activeOfferTotal);
			stream.WriteUtfString(this.body);
			stream.WriteInt64(this.freshNewsDate);
			stream.WriteUtfString(this.id);
			stream.WriteUtfString(this.title);
		}

		public string id;

		public string title;

		public string body;

		public HashSet<string> activeNewsIds;

		public long freshNewsDate;

		public int activeOfferCurrent;

		public int activeOfferTotal;
	}
}
