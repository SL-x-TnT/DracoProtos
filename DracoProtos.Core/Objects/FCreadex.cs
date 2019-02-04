using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
	public class FCreadex : FCreadexBase
	{
		public override bool Equals(object obj)
		{
			return !object.ReferenceEquals(null, obj) && (object.ReferenceEquals(this, obj) || (obj.GetType() == base.GetType() && this.Equals((FCreadexBase)obj)));
		}
	}
}
