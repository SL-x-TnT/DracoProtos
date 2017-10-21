using System;

namespace DracoProtos.Serializer
{
	public interface FObject
	{
		void ReadExternal(FInputStream stream);

		void WriteExternal(FOutputStream stream);
	}
}
