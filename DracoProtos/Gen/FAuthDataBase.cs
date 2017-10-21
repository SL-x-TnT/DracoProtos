using System;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FAuthDataBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.config = (FConfig)stream.ReadStaticObject(typeof(FConfig));
			this.info = (FUserInfo)stream.ReadStaticObject(typeof(FUserInfo));
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticObject(this.config);
			stream.WriteStaticObject(this.info);
		}

		public FUserInfo info;

		public FConfig config;
	}
}
