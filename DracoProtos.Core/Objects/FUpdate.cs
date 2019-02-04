using System.Linq;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
    public class FUpdate : FUpdateBase
	{
		public T FindFirst<T>() where T : FBaseItemUpdate
		{
			return (T)((object)this.items.FirstOrDefault((FBaseItemUpdate item) => item.GetType() == typeof(T)));
		}
	}
}
