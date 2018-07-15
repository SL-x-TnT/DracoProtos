using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FLootItemArtifact : FLootItemArtifactBase
	{
		public override void SetSprite(RawImage rawImage)
		{
			/*Prefabs.textures.LoadArtifactByName(this.artifact, delegate(Texture2D img)
			{
				rawImage.texture = img;
			});*/
		}

		public override string GetLootGroup()
		{
			return base.GetLootGroup() + "/" + this.artifact;
		}
	}
}
