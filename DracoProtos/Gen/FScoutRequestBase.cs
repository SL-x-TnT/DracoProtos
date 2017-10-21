using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FScoutRequestBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.clientRequest = (FClientRequest)stream.ReadStaticObject(typeof(FClientRequest));
			this.scoutCoords = (GeoCoords)stream.ReadStaticObject(typeof(GeoCoords));
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticObject(this.clientRequest);
			stream.WriteStaticObject(this.scoutCoords);
		}

		public GeoCoords scoutCoords;

		public FClientRequest clientRequest;
	}
}
