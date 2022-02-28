using mis321_pa2_hdwells.Interfaces;
namespace mis321_pa2_hdwells
{
    public class Sword : IAttack
    {
        public double Attack(Character player, double AttackPower, double DefensePower)
        {
            System.Console.WriteLine("Will Turner attacked by using his sword!");
            if(DefensePower > AttackPower)
            {
                return 1.0;
            }
            else if(player.characterType == 3) //beats davy jones then gets this boost
            {
                return (AttackPower - DefensePower) * 1.2;
            }
            else
            {
                return AttackPower - DefensePower;
            }
        }
    }
    }
