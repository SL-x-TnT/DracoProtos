using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FLootItemArtifact : FLootItemArtifactBase
	{

		public override string GetLootGroup()
		{
			return base.GetLootGroup() + "/" + this.artifact;
		}

        public override void SetSprite(RawImage rawImage)
        {
        }
    }

    public class RawImage
    {
    }
}
