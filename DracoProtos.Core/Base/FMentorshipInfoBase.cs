using System.Collections.Generic;
using DracoProtos.Core.Objects;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
    public abstract class FMentorshipInfoBase : IFObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.canBeMentor = stream.ReadBoolean();
			this.canChooseMentor = stream.ReadBoolean();
			this.hasParentMentor = stream.ReadBoolean();
			this.levelRequiredToBeMentor = stream.ReadInt32();
			this.ownMentorCode = stream.ReadUtfString();
			this.parentMentorId = stream.ReadUtfString();
			this.parentMentorNickname = stream.ReadUtfString();
			this.students = stream.ReadStaticList<FStudent>(true);
			this.wasKickedByParentMentor = stream.ReadBoolean();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteBoolean(this.canBeMentor);
			stream.WriteBoolean(this.canChooseMentor);
			stream.WriteBoolean(this.hasParentMentor);
			stream.WriteInt32(this.levelRequiredToBeMentor);
			stream.WriteUtfString(this.ownMentorCode);
			stream.WriteUtfString(this.parentMentorId);
			stream.WriteUtfString(this.parentMentorNickname);
			stream.WriteStaticCollection(this.students, true);
			stream.WriteBoolean(this.wasKickedByParentMentor);
		}

		public bool canBeMentor;

		public int levelRequiredToBeMentor;

		public string ownMentorCode;

		public bool canChooseMentor;

		public bool hasParentMentor;

		public bool wasKickedByParentMentor;

		public string parentMentorId;

		public string parentMentorNickname;

		public List<FStudent> students;
	}
}
