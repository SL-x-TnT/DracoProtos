namespace DracoProtos.Command
{
    public class FAvaUpdate : FAvaUpdateBase
	{
		public override void Handle()
		{
		}

		public bool InDungeon
		{
			get
			{
				return this.dungeonId != null;
			}
		}
	}
}
