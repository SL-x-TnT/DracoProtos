using System;
using System.Collections.Generic;
using DracoProtos.Serializer;

namespace DracoProtos
{
	public abstract class FCatchingConfigBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.catchChances = stream.ReadStaticMap<ItemType, float>(true, true);
			this.chanceToAttack = stream.ReadFloat();
			this.chanceToJump = stream.ReadFloat();
			this.distance = stream.ReadFloat();
			this.endCamPosDistance = stream.ReadFloat();
			this.endCamPosHeight = stream.ReadFloat();
			this.flyTime = stream.ReadFloat();
			this.height = stream.ReadFloat();
			this.lookAtHeight = stream.ReadFloat();
			this.maxDistance = stream.ReadFloat();
			this.maxHeight = stream.ReadFloat();
			this.moveCheckCooldownSeconds = stream.ReadFloat();
			this.offsetDistance = stream.ReadFloat();
			this.offsetHeight = stream.ReadFloat();
			this.scale = stream.ReadFloat();
			this.scaleCollider = stream.ReadFloat();
			this.sightRadiusDecreaseTimeSeconds = stream.ReadFloat();
			this.sightRadiusMax = stream.ReadFloat();
			this.sightRadiusMin = stream.ReadFloat();
			this.startCamPosDistance = stream.ReadFloat();
			this.startCamPosHeight = stream.ReadFloat();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteStaticMap(this.catchChances, true, true);
			stream.WriteFloat(this.chanceToAttack);
			stream.WriteFloat(this.chanceToJump);
			stream.WriteFloat(this.distance);
			stream.WriteFloat(this.endCamPosDistance);
			stream.WriteFloat(this.endCamPosHeight);
			stream.WriteFloat(this.flyTime);
			stream.WriteFloat(this.height);
			stream.WriteFloat(this.lookAtHeight);
			stream.WriteFloat(this.maxDistance);
			stream.WriteFloat(this.maxHeight);
			stream.WriteFloat(this.moveCheckCooldownSeconds);
			stream.WriteFloat(this.offsetDistance);
			stream.WriteFloat(this.offsetHeight);
			stream.WriteFloat(this.scale);
			stream.WriteFloat(this.scaleCollider);
			stream.WriteFloat(this.sightRadiusDecreaseTimeSeconds);
			stream.WriteFloat(this.sightRadiusMax);
			stream.WriteFloat(this.sightRadiusMin);
			stream.WriteFloat(this.startCamPosDistance);
			stream.WriteFloat(this.startCamPosHeight);
		}

		public float distance;

		public float height;

		public float lookAtHeight;

		public float scale;

		public float maxDistance;

		public float startCamPosDistance;

		public float startCamPosHeight;

		public float endCamPosDistance;

		public float endCamPosHeight;

		public float moveCheckCooldownSeconds;

		public float chanceToAttack;

		public float chanceToJump;

		public float flyTime;

		public float offsetDistance;

		public float offsetHeight;

		public float sightRadiusMax;

		public float sightRadiusMin;

		public float sightRadiusDecreaseTimeSeconds;

		public float maxHeight;

		public float scaleCollider;

		public Dictionary<ItemType, float> catchChances;
	}
}
