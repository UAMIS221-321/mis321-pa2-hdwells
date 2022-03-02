using System;
using mis321_pa2_hdwells.Interfaces;

namespace mis321_pa2_hdwells
{
    public class Character
    {

    public string Name {get; set;}
        public double Health { get; set; } //start at 100 
        public int MaxPower { get; set; } //random number between 1 and 100
        public int AttackPower { get; set; } //random number between 1 and max power 
        public int DefensePower { get; set; } //random number between 1 and max power 
        public int characterType {get; set;}

         public IAttack attackBehavior{get;set;}

        public Character()
        {
            Random c = new Random();
            MaxPower = c.Next(1,100);
            Health = 100; 
            AttackPower = c.Next(1, MaxPower);
            DefensePower = c.Next(1, MaxPower);
        }
        public void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }

    }
}