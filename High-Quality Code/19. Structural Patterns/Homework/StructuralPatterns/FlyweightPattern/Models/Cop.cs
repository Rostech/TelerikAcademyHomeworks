namespace FlyweightPattern.Models
{
    using FlyweightPattern.Utils;

    internal class Cop : Soldier
    {
        internal Cop()
        {
            this.Name = "unknown cop";
            this.Rank = Rank.Private;
            this.Weapon = Weapon.M16;
            this.NumberOfBuletts = 30;
        }
    }
}
