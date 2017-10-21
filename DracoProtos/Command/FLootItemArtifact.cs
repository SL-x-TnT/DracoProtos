namespace DracoProtos.Command
{
    public class FLootItemArtifact : FLootItemArtifactBase
	{

		public override string GetLootGroup()
		{
			return base.GetLootGroup() + "/" + this.artifact;
		}
	}
}
