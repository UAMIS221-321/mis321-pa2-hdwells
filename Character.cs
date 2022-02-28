using System;
using mis321_pa2_hdwells.Interfaces;

namespace mis321_pa2_hdwells
{
    public class Character
    {

    public string Name {get; set;}
        public double Health { get; set; } //start at 100 
        public  double MaxPower { get; set; } //random number between 1 and 100
        public  double AttackPower { get; set; } //random number between 1 and max power 
        public double DefensePower { get; set; } //random number between 1 and max power 
        public int characterType {get; set;}

         public IAttack attackBehavior{get;set;}

        public void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }

        public double GetDefensePower()
        {
            Random d = new Random();
            double defensePower = d.Next(1,100);
            return defensePower;
        }

        public double GetAttackPower(double MaxPower)
        {
            Random a = new Random();
            double attackPower = a.Next(1,100);
            while(attackPower > MaxPower)
            {
                attackPower = a.Next(1,100);
            }
            return attackPower;
        }
    }
}