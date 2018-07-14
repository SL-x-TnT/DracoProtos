using System.Collections.Generic;
using DracoProtos.Core.Base;

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
			num = (num * 397 ^ (int)this.candyType);
			num = (num * 397 ^ this.group);
			return num * 397 ^ this.gotchaTime.GetHashCode();
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
