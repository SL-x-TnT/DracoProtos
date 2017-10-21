namespace DracoProtos.Command
{
    public class FBagUpdate : FBagUpdateBase
	{

		public override bool Equals(object obj)
		{
			return !object.ReferenceEquals(null, obj) && (object.ReferenceEquals(this, obj) || (obj.GetType() == base.GetType() && this.Equals((FBagUpdateBase)obj)));
		}

		public static bool operator ==(FBagUpdate left, FBagUpdate right)
		{
			return object.Equals(left, right);
		}

		public static bool operator !=(FBagUpdate left, FBagUpdate right)
		{
			return !object.Equals(left, right);
		}
	}
}
