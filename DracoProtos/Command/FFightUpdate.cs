namespace DracoProtos.Command
{
    public class FFightUpdate : FFightUpdateBase
	{
		public override void Handle()
		{
		}

		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"FFightUpdate(attackers = ",
				this.attackers,
				"\ndefenders=",
				this.defenders,
				")"
			});
		}
	}
}
