using System;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class TileBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.x = stream.ReadInt32();
			this.y = stream.ReadInt32();
			this.zoom = stream.ReadInt32();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteInt32(this.x);
			stream.WriteInt32(this.y);
			stream.WriteInt32(this.zoom);
		}

		public int zoom;

		public int x;

		public int y;
	}
}
