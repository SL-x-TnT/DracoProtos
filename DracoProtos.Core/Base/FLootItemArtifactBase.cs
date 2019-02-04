using System;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FLootItemArtifactBase : FBaseLootItem
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.artifact = (ArtifactName)stream.ReadEnum(typeof(ArtifactName));
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteEnum(this.artifact);
		}

		public ArtifactName artifact;
	}
}
