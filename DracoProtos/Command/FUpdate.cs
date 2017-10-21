using System;
using System.Linq;

namespace DracoProtos.Command
{
    public class FUpdate : FUpdateBase
	{
		public void OnServerUpdate()
		{
		}

		public FBaseItemUpdate FindFirst(Type type)
		{
			return this.items.FirstOrDefault((FBaseItemUpdate item) => item.GetType() == type);
		}
	}
}
