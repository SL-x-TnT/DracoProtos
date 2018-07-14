using System;
using DracoProtos.Core.Base;

namespace DracoProtos.Core.Objects
{
    public class FFightCreature : FFightCreatureBase
	{
		public bool IsEnoughEnergyForChargedAttack()
		{
			return this.Energy >= this.GetEnergyInSegment();
		}

		public float GetEnergyInSegment()
		{
			return this.maxEnergy / (float)this.energySegments;
		}

		public void AddEnergyForBaseAttack()
		{
			this.Energy = Math.Min(this.Energy + this.incomingEnergyOnAttack, this.maxEnergy);
		}

		public void SpendEnergyOnChargedAttack()
		{
			this.Energy -= this.GetEnergyInSegment();
		}

		public float GetEnergy()
		{
			return this.Energy;
		}

		public void SetEnergy(float value)
		{
			this.Energy = value;
		}

		public float TakeDamage(float amount)
		{
			float num = FFightCreature.roundHp(Math.Min(this.hp, amount));
			this.hp = Math.Max(0f, FFightCreature.roundHp(this.hp - num));
			return num;
		}

		public bool IsDead()
		{
			return this.hp < FUserCreature.HP_EPSILON;
		}

		public static float roundHp(float hp)
		{
			return (float)Math.Round((double)hp, 2);
		}

		public float Energy;
	}
}
