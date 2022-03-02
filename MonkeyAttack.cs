using mis321_pa2_hdwells.Interfaces;
namespace mis321_pa2_hdwells
{
    public class MonkeyAttack : IAttack
    {
        public double Attack(Character player,double AttackPower, double DefensePower)
        {
            System.Console.WriteLine("Captain Barbosa unleashed his pet monkey to attack!");
            if(player.DefensePower > player.AttackPower)
            {
                return 1.0;
            }
            else
            {
                return player.AttackPower - player.DefensePower;
            }
        }
    }
}