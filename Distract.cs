using mis321_pa2_hdwells.Interfaces;

namespace mis321_pa2_hdwells
{
    public class Distract : IAttack
    {
         public double Attack(Character player, double AttackPower, double DefensePower)
        {
            System.Console.WriteLine("Jack Sparrow distracted you!");
            if(DefensePower > AttackPower)
            {
                return 1.0;
            }
            else if(player.characterType == 2) //beats will turner then gets this boost
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