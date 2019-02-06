using DracoProtos.Core.Base;
using DracoProtos.Core.Extensions;

namespace DracoProtos.Core.Objects
{
    public class FResistModifyDetails : FResistModifyDetailsBase
	{
		public int ResultResistMinPercent
		{
			get
			{
				return Utils.roundPercent(this.resultResistMin);
			}
		}

		public int ResultResistMaxPercent
		{
			get
			{
				return Utils.roundPercent(this.resultResistMax);
			}
		}
	}
}
