using mis321_pa2_hdwells.Interfaces;
namespace mis321_pa2_hdwells
{
    public class Sword : IAttack
    {
        public double Attack(Character player,double AttackPower, double DefensePower)
        {
            System.Console.WriteLine("Will Turner attacked by using his sword!");
            if(player.DefensePower > player.AttackPower)
            {
                return 1.0;
            }
            else if(player.characterType == 3) //beats davy jones then gets this boost
            {
                return (player.AttackPower - player.DefensePower) * 1.2;
            }
            else
            {
                return player.AttackPower - player.DefensePower;
            }
        }
    }
    }
