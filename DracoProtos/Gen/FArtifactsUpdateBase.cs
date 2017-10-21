using System;
using System.Collections.Generic;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FArtifactsUpdateBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.artifacts = stream.ReadStaticList<ArtifactName>(true);
			this.artifactsBagSize = stream.ReadInt32();
			this.artifactsSlots = stream.ReadInt32();
			this.hasDeposit = stream.ReadBoolean();
			this.putOn = stream.ReadStaticList<ArtifactName>(true);
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticCollection(this.artifacts, true);
			stream.WriteInt32(this.artifactsBagSize);
			stream.WriteInt32(this.artifactsSlots);
			stream.WriteBoolean(this.hasDeposit);
			stream.WriteStaticCollection(this.putOn, true);
		}

		public List<ArtifactName> artifacts;

		public List<ArtifactName> putOn;

		public int artifactsBagSize;

		public int artifactsSlots;

		public bool hasDeposit;
	}
}
