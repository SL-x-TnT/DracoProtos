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

		public static float HP_EPSILON = 0.01f;
	}
}
