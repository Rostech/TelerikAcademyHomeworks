namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;
    
    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;

    public class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {
            if (rounds < 1)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
            }
            if (rounds >= 10)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be less or eual than 10");
            }

            this.rounds = rounds;
        }

        public override decimal ChangeDamageWhenAttacking(
            ICreaturesInBattle attackerWithSpecialty,
            ICreaturesInBattle defender,
            decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }
            //if (this.rounds <= 0)
            //{
            //    // Effect expires after fixed number of rounds
            //    return 0; /// ------------ should i return 0
            //}

            this.rounds--;
            return currentDamage *= 2;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
