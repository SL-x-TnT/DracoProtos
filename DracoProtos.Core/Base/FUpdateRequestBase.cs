using System;
using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FUpdateRequestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.blackScreen = stream.ReadBoolean();
			this.clientPlatform = (ClientPlatform)stream.ReadEnum(typeof(ClientPlatform));
			this.clientRequest = (FClientRequest)stream.ReadStaticObject(typeof(FClientRequest));
			this.clientScreen = (ClientScreen?)stream.ReadDynamicObject();
			this.configCacheHash = stream.ReadStaticArray<sbyte>(true);
			this.language = (string)stream.ReadDynamicObject();
			this.tilesCache = stream.ReadStaticMap<FTile, long>(true, true);
			this.updateBuilding = (FBuildingRequest)stream.ReadDynamicObject();
			this.updateBuildingIfModifiedSince = stream.ReadInt64();
			this.updateBuildingType = (BuildingType?)stream.ReadDynamicObject();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.blackScreen);
			stream.WriteEnum(this.clientPlatform);
			stream.WriteStaticObject(this.clientRequest);
			stream.WriteDynamicObject(this.clientScreen);
			stream.WriteStaticCollection(this.configCacheHash, true);
			stream.WriteDynamicObject(this.language);
			stream.WriteStaticMap(this.tilesCache, true, true);
			stream.WriteDynamicObject(this.updateBuilding);
			stream.WriteInt64(this.updateBuildingIfModifiedSince);
			stream.WriteDynamicObject(this.updateBuildingType);
		}

		public FClientRequest clientRequest;

		public ClientPlatform clientPlatform;

		public bool blackScreen;

		public Dictionary<FTile, long> tilesCache;

		public string language;

		public sbyte[] configCacheHash;

		public FBuildingRequest updateBuilding;

		public BuildingType? updateBuildingType;

		public long updateBuildingIfModifiedSince;

		public ClientScreen? clientScreen;
	}
}
