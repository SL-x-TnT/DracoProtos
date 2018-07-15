﻿using System;
using System.Collections.Generic;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FTipsBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.laterAvailable = stream.ReadBoolean();
			this.messages = stream.ReadStaticList<string>(true);
			this.nextAvailable = stream.ReadBoolean();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.laterAvailable);
			stream.WriteStaticCollection(this.messages, true);
			stream.WriteBoolean(this.nextAvailable);
		}

		public List<string> messages;

		public bool nextAvailable;

		public bool laterAvailable;
	}
}
