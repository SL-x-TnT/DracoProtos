using System.Collections.Generic;
using DracoProtos.Core.Base;
using DracoProtos.Core.Extensions;

namespace DracoProtos.Core.Objects
{
    public class FUserCreature : FUserCreatureBase
	{
		public bool IsFavorite()
		{
			return this.group > 0;
		}

		public int GetCandyCount(FAvaUpdate avaUpdate)
		{
			int result;
			if (avaUpdate.candies.TryGetValue(this.candyType, out result))
			{
				return result;
			}
			return 0;
		}

		public bool IsDamaged()
		{
			return !this.IsDead() && !this.hasMaxHp();
		}

		public bool hasMaxHp()
		{
			return this.totalHp - this.hp < FUserCreature.HP_EPSILON;
		}

		public bool IsDead()
		{
			return this.hp < FUserCreature.HP_EPSILON;
		}

		public bool CanAttack()
		{
			return !this.isArenaDefender && !this.IsDead();
		}

		protected bool Equals(FUserCreature other)
		{
			return string.Equals(this.id, other.id) && this.name == other.name && string.Equals(this.alias, other.alias) && this.baseCp == other.baseCp && this.cp == other.cp && this.level == other.level && this.dps.Equals(other.dps) && this.hp.Equals(other.hp) && this.totalHp.Equals(other.totalHp) && this.isArenaDefender == other.isArenaDefender && this.isLibraryDefender == other.isLibraryDefender && this.elementType == other.elementType && this.tier == other.tier && string.Equals(this.mainSkill, other.mainSkill) && this.mainSkillDps.Equals(other.mainSkillDps) && this.mainSkillEps.Equals(other.mainSkillEps) && string.Equals(this.chargedSkill, other.chargedSkill) && this.chargedSkillDps.Equals(other.chargedSkillDps) && this.chargedSegments == other.chargedSegments && this.attackValue == other.attackValue && this.staminaValue == other.staminaValue && this.isAttacker == other.isAttacker && this.improvable == other.improvable && this.improveDustCost == other.improveDustCost && this.improveCandiesCost == other.improveCandiesCost && Utils.EnumerableEquals<KeyValuePair<CreatureType, int>>(this.possibleEvolutions, other.possibleEvolutions) && this.candyType == other.candyType && this.group == other.group && this.gotchaTime == other.gotchaTime && this.hasMaxResist == other.hasMaxResist;
		}

		public override bool Equals(object obj)
		{
			return !object.ReferenceEquals(null, obj) && (object.ReferenceEquals(this, obj) || (obj.GetType() == base.GetType() && this.Equals((FUserCreature)obj)));
		}

		public override int GetHashCode()
		{
			int num = (this.id == null) ? 0 : this.id.GetHashCode();
			num = (num * 397 ^ (int)this.name);
			num = (num * 397 ^ ((this.alias == null) ? 0 : this.alias.GetHashCode()));
			num = (num * 397 ^ this.baseCp);
			num = (num * 397 ^ this.cp);
			num = (num * 397 ^ this.level);
			num = (num * 397 ^ this.dps.GetHashCode());
			num = (num * 397 ^ this.hp.GetHashCode());
			num = (num * 397 ^ this.totalHp.GetHashCode());
			num = (num * 397 ^ this.isArenaDefender.GetHashCode());
			num = (num * 397 ^ this.isLibraryDefender.GetHashCode());
			num = (num * 397 ^ (int)this.elementType);
			num = (num * 397 ^ this.tier);
			num = (num * 397 ^ ((this.mainSkill == null) ? 0 : this.mainSkill.GetHashCode()));
			num = (num * 397 ^ this.mainSkillDps.GetHashCode());
			num = (num * 397 ^ this.mainSkillEps.GetHashCode());
			num = (num * 397 ^ ((this.chargedSkill == null) ? 0 : this.chargedSkill.GetHashCode()));
			num = (num * 397 ^ this.chargedSkillDps.GetHashCode());
			num = (num * 397 ^ this.chargedSegments);
			num = (num * 397 ^ this.attackValue);
			num = (num * 397 ^ this.staminaValue);
			num = (num * 397 ^ this.isAttacker.GetHashCode());
			num = (num * 397 ^ this.improvable.GetHashCode());
			num = (num * 397 ^ this.improveDustCost);
			num = (num * 397 ^ this.improveCandiesCost);
			num = (num * 397 ^ Utils.EnumerableHashCode<KeyValuePair<CreatureType, int>>(this.possibleEvolutions, num));
			num = (num * 397 ^ (int)this.candyType);
			num = (num * 397 ^ this.group);
			num = (num * 397 ^ this.gotchaTime.GetHashCode());
			return num * 397 ^ this.hasMaxResist.GetHashCode();
		}

		public static bool operator ==(FUserCreature left, FUserCreature right)
		{
			return object.Equals(left, right);
		}

		public static bool operator !=(FUserCreature left, FUserCreature right)
		{
			return !object.Equals(left, right);
		}

		public static float HP_EPSILON = 0.01f;
	}
}
