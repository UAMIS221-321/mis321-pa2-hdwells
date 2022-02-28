using mis321_pa2_hdwells.Interfaces;

namespace mis321_pa2_hdwells
{
    public class Cannon : IAttack
    {
         public double Attack(Character player, double AttackPower, double DefensePower)
        {

            System.Console.WriteLine("Davy Jones hit you with a cannon fire!");
            if(DefensePower > AttackPower)
            {
                return 1.0;
            }
            else if(player.characterType == 1) //beats jack sparrow then gets this boost
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