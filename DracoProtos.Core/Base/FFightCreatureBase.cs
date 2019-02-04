using System;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FFightCreatureBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.alias = (string)stream.ReadDynamicObject();
			this.ancient = stream.ReadBoolean();
			this.attacker = stream.ReadBoolean();
			this.baseCp = stream.ReadInt32();
			this.chargedSkill = stream.ReadUtfString();
			this.chargedSkillAim = stream.ReadBoolean();
			this.chargedSkillAngle = stream.ReadInt32();
			this.chargedSkillDps = stream.ReadFloat();
			this.chargedSkillQuality = (SkillQuality)stream.ReadEnum(typeof(SkillQuality));
			this.chargedSkillSpeed = stream.ReadFloat();
			this.chargedSkillTtl = stream.ReadFloat();
			this.cp = stream.ReadInt32();
			this.decreasedDmgTo = (ElementType)stream.ReadEnum(typeof(ElementType));
			this.distance = stream.ReadFloat();
			this.dodgeAngle = stream.ReadFloat();
			this.dodgeDamageRatio = stream.ReadFloat();
			this.dodgeMoveTime = stream.ReadFloat();
			this.energySegments = stream.ReadInt32();
			this.height = stream.ReadFloat();
			this.holdTimeForChargedSkill = stream.ReadFloat();
			this.hp = stream.ReadFloat();
			this.id = stream.ReadUtfString();
			this.incomingEnergyOnAttack = stream.ReadFloat();
			this.increasedCpByArtifact = stream.ReadBoolean();
			this.increasedDmgTo = (ElementType)stream.ReadEnum(typeof(ElementType));
			this.mainSkill = stream.ReadUtfString();
			this.mainSkillAim = stream.ReadBoolean();
			this.mainSkillAngle = stream.ReadInt32();
			this.mainSkillDps = stream.ReadFloat();
			this.mainSkillQuality = (SkillQuality)stream.ReadEnum(typeof(SkillQuality));
			this.mainSkillSpeed = stream.ReadFloat();
			this.mainSkillTtl = stream.ReadFloat();
			this.maxEnergy = stream.ReadFloat();
			this.name = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.resistCoef = stream.ReadFloat();
			this.resistFor = (ElementType)stream.ReadEnum(typeof(ElementType));
			this.rightElementAttackCoef = stream.ReadFloat();
			this.scale = stream.ReadFloat();
			this.specAttackCoef = stream.ReadFloat();
			this.startCamPosDistance = stream.ReadFloat();
			this.startCamPosHeight = stream.ReadFloat();
			this.totalHp = stream.ReadFloat();
			this.type = (ElementType)stream.ReadEnum(typeof(ElementType));
			this.wrongElementAttackCoef = stream.ReadFloat();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.alias);
			stream.WriteBoolean(this.ancient);
			stream.WriteBoolean(this.attacker);
			stream.WriteInt32(this.baseCp);
			stream.WriteUtfString(this.chargedSkill);
			stream.WriteBoolean(this.chargedSkillAim);
			stream.WriteInt32(this.chargedSkillAngle);
			stream.WriteFloat(this.chargedSkillDps);
			stream.WriteEnum(this.chargedSkillQuality);
			stream.WriteFloat(this.chargedSkillSpeed);
			stream.WriteFloat(this.chargedSkillTtl);
			stream.WriteInt32(this.cp);
			stream.WriteEnum(this.decreasedDmgTo);
			stream.WriteFloat(this.distance);
			stream.WriteFloat(this.dodgeAngle);
			stream.WriteFloat(this.dodgeDamageRatio);
			stream.WriteFloat(this.dodgeMoveTime);
			stream.WriteInt32(this.energySegments);
			stream.WriteFloat(this.height);
			stream.WriteFloat(this.holdTimeForChargedSkill);
			stream.WriteFloat(this.hp);
			stream.WriteUtfString(this.id);
			stream.WriteFloat(this.incomingEnergyOnAttack);
			stream.WriteBoolean(this.increasedCpByArtifact);
			stream.WriteEnum(this.increasedDmgTo);
			stream.WriteUtfString(this.mainSkill);
			stream.WriteBoolean(this.mainSkillAim);
			stream.WriteInt32(this.mainSkillAngle);
			stream.WriteFloat(this.mainSkillDps);
			stream.WriteEnum(this.mainSkillQuality);
			stream.WriteFloat(this.mainSkillSpeed);
			stream.WriteFloat(this.mainSkillTtl);
			stream.WriteFloat(this.maxEnergy);
			stream.WriteEnum(this.name);
			stream.WriteFloat(this.resistCoef);
			stream.WriteEnum(this.resistFor);
			stream.WriteFloat(this.rightElementAttackCoef);
			stream.WriteFloat(this.scale);
			stream.WriteFloat(this.specAttackCoef);
			stream.WriteFloat(this.startCamPosDistance);
			stream.WriteFloat(this.startCamPosHeight);
			stream.WriteFloat(this.totalHp);
			stream.WriteEnum(this.type);
			stream.WriteFloat(this.wrongElementAttackCoef);
		}

		public string id;

		public CreatureType name;

		public string alias;

		public int baseCp;

		public int cp;

		public float hp;

		public float totalHp;

		public ElementType type;

		public ElementType increasedDmgTo;

		public ElementType decreasedDmgTo;

		public ElementType resistFor;

		public float resistCoef;

		public string mainSkill;

		public SkillQuality mainSkillQuality;

		public float mainSkillDps;

		public float mainSkillSpeed;

		public int mainSkillAngle;

		public float mainSkillTtl;

		public bool mainSkillAim;

		public float incomingEnergyOnAttack;

		public string chargedSkill;

		public float chargedSkillDps;

		public float chargedSkillSpeed;

		public SkillQuality chargedSkillQuality;

		public int chargedSkillAngle;

		public float chargedSkillTtl;

		public bool chargedSkillAim;

		public float maxEnergy;

		public int energySegments;

		public float holdTimeForChargedSkill;

		public float dodgeDamageRatio;

		public float dodgeMoveTime;

		public float dodgeAngle;

		public float specAttackCoef;

		public float rightElementAttackCoef;

		public float wrongElementAttackCoef;

		public float distance;

		public float height;

		public float scale;

		public float startCamPosDistance;

		public float startCamPosHeight;

		public bool attacker;

		public bool ancient;

		public bool increasedCpByArtifact;
	}
}
