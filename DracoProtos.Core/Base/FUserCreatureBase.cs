using System;
using System.Collections.Generic;
using DracoProtos.Core.Serializer;

namespace DracoProtos.Core.Base
{
	public abstract class FUserCreatureBase : FObject
	{
		public void ReadExternal(FInputStream stream)
		{
			this.alias = (string)stream.ReadDynamicObject();
			this.ancient = stream.ReadBoolean();
			this.attackValue = stream.ReadInt32();
			this.baseCp = stream.ReadInt32();
			this.candyType = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.chargedSegments = stream.ReadInt32();
			this.chargedSkill = stream.ReadUtfString();
			this.chargedSkillDps = stream.ReadFloat();
			this.cp = stream.ReadInt32();
			this.creadexIndex = stream.ReadInt32();
			this.dps = stream.ReadFloat();
			this.elementType = (ElementType)stream.ReadEnum(typeof(ElementType));
			this.gotchaTime = stream.ReadInt64();
			this.group = stream.ReadInt32();
			this.hasMaxResist = stream.ReadBoolean();
			this.hp = stream.ReadFloat();
			this.id = stream.ReadUtfString();
			this.improvable = stream.ReadBoolean();
			this.improveCandiesCost = stream.ReadInt32();
			this.improveDustCost = stream.ReadInt32();
			this.isArenaDefender = stream.ReadBoolean();
			this.isAttacker = stream.ReadBoolean();
			this.isLibraryDefender = stream.ReadBoolean();
			this.level = stream.ReadInt32();
			this.mainSkill = stream.ReadUtfString();
			this.mainSkillDps = stream.ReadFloat();
			this.mainSkillEps = stream.ReadFloat();
			this.name = (CreatureType)stream.ReadEnum(typeof(CreatureType));
			this.permanent = stream.ReadBoolean();
			this.possibleEvolutions = stream.ReadStaticMap<CreatureType, int>(true, true);
			this.resist = stream.ReadFloat();
			this.resistFor = (ElementType)stream.ReadEnum(typeof(ElementType));
			this.staminaValue = stream.ReadInt32();
			this.tier = stream.ReadInt32();
			this.totalHp = stream.ReadFloat();
		}

		public void WriteExternal(FOutputStream stream)
		{
			stream.WriteDynamicObject(this.alias);
			stream.WriteBoolean(this.ancient);
			stream.WriteInt32(this.attackValue);
			stream.WriteInt32(this.baseCp);
			stream.WriteEnum(this.candyType);
			stream.WriteInt32(this.chargedSegments);
			stream.WriteUtfString(this.chargedSkill);
			stream.WriteFloat(this.chargedSkillDps);
			stream.WriteInt32(this.cp);
			stream.WriteInt32(this.creadexIndex);
			stream.WriteFloat(this.dps);
			stream.WriteEnum(this.elementType);
			stream.WriteInt64(this.gotchaTime);
			stream.WriteInt32(this.group);
			stream.WriteBoolean(this.hasMaxResist);
			stream.WriteFloat(this.hp);
			stream.WriteUtfString(this.id);
			stream.WriteBoolean(this.improvable);
			stream.WriteInt32(this.improveCandiesCost);
			stream.WriteInt32(this.improveDustCost);
			stream.WriteBoolean(this.isArenaDefender);
			stream.WriteBoolean(this.isAttacker);
			stream.WriteBoolean(this.isLibraryDefender);
			stream.WriteInt32(this.level);
			stream.WriteUtfString(this.mainSkill);
			stream.WriteFloat(this.mainSkillDps);
			stream.WriteFloat(this.mainSkillEps);
			stream.WriteEnum(this.name);
			stream.WriteBoolean(this.permanent);
			stream.WriteStaticMap(this.possibleEvolutions, true, true);
			stream.WriteFloat(this.resist);
			stream.WriteEnum(this.resistFor);
			stream.WriteInt32(this.staminaValue);
			stream.WriteInt32(this.tier);
			stream.WriteFloat(this.totalHp);
		}

		public string id;

		public CreatureType name;

		public string alias;

		public int baseCp;

		public int cp;

		public int level;

		public float dps;

		public float hp;

		public float totalHp;

		public bool isArenaDefender;

		public bool isLibraryDefender;

		public ElementType elementType;

		public int tier;

		public string mainSkill;

		public float mainSkillDps;

		public float mainSkillEps;

		public string chargedSkill;

		public float chargedSkillDps;

		public int chargedSegments;

		public ElementType resistFor;

		public float resist;

		public bool hasMaxResist;

		public int attackValue;

		public int staminaValue;

		public bool isAttacker;

		public bool ancient;

		public bool improvable;

		public int improveDustCost;

		public int improveCandiesCost;

		public Dictionary<CreatureType, int> possibleEvolutions;

		public CreatureType candyType;

		public int group;

		public long gotchaTime;

		public int creadexIndex;

		public bool permanent;
	}
}
