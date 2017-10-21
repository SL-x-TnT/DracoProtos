using System;
using System.Collections.Generic;
using DracoProtos.Command;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FQuestUpdateBase : FBaseItemUpdate
	{
		public override void ReadExternal(FInputStream stream)
		{
			base.ReadExternal(stream);
			this.completed = (FQuestCompleted)stream.ReadDynamicObject();
			this.highlightBuilding = (IdAndCoords)stream.ReadDynamicObject();
			this.path = stream.ReadDynamicList<IdAndCoords>(true);
		}

		public override void WriteExternal(FOutputStream stream)
		{
			base.WriteExternal(stream);
			stream.WriteDynamicObject(this.completed);
			stream.WriteDynamicObject(this.highlightBuilding);
			stream.WriteDynamicCollection(this.path, true);
		}

		public FQuestCompleted completed;

		public List<IdAndCoords> path;

		public IdAndCoords highlightBuilding;
	}
}
