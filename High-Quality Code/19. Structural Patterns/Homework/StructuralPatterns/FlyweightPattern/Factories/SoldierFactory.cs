namespace FlyweightPattern.Factories
{
    using FlyweightPattern.Models;
    using System;
    using System.Collections.Generic;
    
    internal class SoldierFactory
    {
        private readonly Dictionary<string, Soldier> soldiers = new Dictionary<string, Soldier>();

        internal int NumberOfObjects
        {
            get
            {
                return this.soldiers.Count;
            }
        }

        internal Soldier GetSoldier(string typeOfSoldier)
        {
            Soldier soldier = null;

            if (this.soldiers.ContainsKey(typeOfSoldier))
            {
                soldier = soldiers[typeOfSoldier];
            }
            else
            {
                switch(typeOfSoldier)
                {
                    case "terrorist":
                        soldier = new Terrorist();
                        break;
                    case "cop":
                        soldier = new Cop();
                        break;
                    default:
                        throw new ArgumentException(String.Format("There is no such type ({0} of soldier!", typeOfSoldier));
                }

                this.soldiers.Add(typeOfSoldier, soldier);
            }

            return soldier;
        }
    }
}
