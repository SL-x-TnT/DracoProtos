using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FUpdateRequestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.blackScreen = stream.ReadBoolean();
			this.clientPlatform = (ClientPlatform)stream.ReadEnum(typeof(ClientPlatform));
			this.clientRequest = (FClientRequest)stream.ReadStaticObject(typeof(FClientRequest));
			this.tilesCache = stream.ReadStaticMap<FTile, long>(true, true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.blackScreen);
			stream.WriteEnum(this.clientPlatform);
			stream.WriteStaticObject(this.clientRequest);
			stream.WriteStaticMap(this.tilesCache, true, true);
		}

		public FClientRequest clientRequest;

		public ClientPlatform clientPlatform;

		public bool blackScreen;

		public Dictionary<FTile, long> tilesCache;
	}
}
