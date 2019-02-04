using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FCreadexEntry : FCreadexEntryBase
	{
		public override bool Equals(object obj)
		{
			return !object.ReferenceEquals(null, obj) && (object.ReferenceEquals(this, obj) || (obj.GetType() == base.GetType() && this.Equals((FCreadexEntryBase)obj)));
		}

		public static bool operator ==(FCreadexEntry left, FCreadexEntry right)
		{
			return object.Equals(left, right);
		}

		public static bool operator !=(FCreadexEntry left, FCreadexEntry right)
		{
			return !object.Equals(left, right);
		}
	}
}
