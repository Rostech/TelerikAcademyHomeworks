namespace FlyweightPattern.Models
{
    using FlyweightPattern.Utils;

    internal class Terrorist : Soldier
    {
        internal Terrorist()
        {
            this.Name = "unknown terrorist";
            this.Rank = Rank.Private;
            this.Weapon = Weapon.AK_47;
            this.NumberOfBuletts = 30;
        }
    }
}
