using System.Drawing;
using System;
using System.Threading;
namespace mis321_pa2_hdwells
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorfulAnimation();
            WelcomeMessage();
        
        }

  public static void WelcomeMessage()
        {
            System.Console.WriteLine("Welcome to the Battle of Calypso's Maelstrom Game! ");
            System.Console.WriteLine("");
            Chooseplayer1();
        }

        static void ColorfulAnimation()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Clear();

                // steam
                
                Console.Write("       . . . . o o o o o o", Color.LightGray);
                for (int s = 0; s < j / 2; s++)
                {
                    Console.Write(" o", Color.LightGray);
                }
                Console.WriteLine();
                var margin = "".PadLeft(j);

                margin = "".PadLeft(j);
                Console.WriteLine(margin + "                    |~     ", Color.DarkGreen);
                Console.WriteLine(margin + "                    |/     |>   |>", Color.DarkGreen);
                Console.WriteLine(margin + "                    / (   (|    |" , Color.DarkGreen);
                Console.WriteLine(margin + "                  /( (/   |)    |>", Color.DarkGreen);
                Console.WriteLine(margin + "            ____  ( (/    (|    | )  ," , Color.DarkGreen);
                Console.WriteLine(margin + "           |----|  (/ |   /|    |'| /^;", Color.DarkGreen);
                Console.WriteLine(margin + "            \\---*---Y--+-----+---+--//(;", Color.Magenta);
                Console.WriteLine(margin + "             \\-------*---*--*---*--//;", Color.Magenta);
                Console.WriteLine("   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ", Color.DarkBlue);

                Thread.Sleep(200);
            }
        }
            WelcomeMessage();
    }

        //randomize character - extra???
        public static void Chooseplayer1()
        {
            Character player1 = new Character();

            System.Console.WriteLine("Player 1 please enter your name! ");
            player1.Name = System.Console.ReadLine();
            

            System.Console.WriteLine($"{player1.Name} please choose your character or exit the system");
            System.Console.WriteLine("\n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones \n4. Elizabeth Swann \n5. Captain Barbosa \n6. Choose Character at Random \n7. Exit the Game ");
            int chooseCharacter1 = int.Parse(Console.ReadLine());
            while(chooseCharacter1 > 7 && chooseCharacter1 < 1)
            {
                Console.WriteLine("Invalid input! Please choose a number between 1-6.");
                chooseCharacter1 = int.Parse(Console.ReadLine());
            }

            if(chooseCharacter1 == 1)
            {
                player1.characterType = 1;
                player1.Health = 100;
                player1.SetAttackBehavior(new Distract());
                player1.MaxPower = GetMaxPower();
            }
            else if(chooseCharacter1 == 2 )
            {
                player1.characterType = 2; 
                player1.Health = 100; 
                player1.SetAttackBehavior(new Sword());
                player1.MaxPower = GetMaxPower();
            }
            else if(chooseCharacter1 == 3)
            {
                player1.characterType = 3; 
                player1.Health = 100;  
                player1.SetAttackBehavior(new Cannon());
                player1.MaxPower = GetMaxPower();
            }
            else if (chooseCharacter1 == 4 )
            {
                player1.characterType = 4; 
                player1.SetAttackBehavior(new Stun());
                player1.Health = 100; 
                player1.MaxPower = GetMaxPower(); 
            }
            else if (chooseCharacter1 == 5 )
            {
                player1.characterType = 5; 
                player1.Health = 100;  
                player1.SetAttackBehavior(new MonkeyAttack());
                player1.MaxPower = GetMaxPower();
            }
            else if (chooseCharacter1 == 6 )
            {
                Random r = new Random();
                player1.characterType = r.Next(0,5);  
                player1.Health = 100; 
                player1.MaxPower = GetMaxPower();

                if (player1.characterType == 1)
                {
                    player1.SetAttackBehavior(new Distract());
                }
                else if (player1.characterType == 2)
                {
                    player1.SetAttackBehavior(new Sword());
                }
                else if (player1.characterType == 3)
                {
                    player1.SetAttackBehavior(new Cannon());
                }
                else if (player1.characterType == 4)
                {
                    player1.SetAttackBehavior(new Stun());
                }
                else
                {
                    player1.SetAttackBehavior(new MonkeyAttack());
                }
            }
            else if (chooseCharacter1 == 7)
            {
                System.Environment.Exit(0);
            }
            else{
                System.Console.WriteLine("Invalid input! Please start over.");
                Console.Clear();
                Chooseplayer1();
            }
            Chooseplayer2(player1);
            
        }

        public static void Chooseplayer2(Character player1)
        {
            Console.Clear();
            Character player2 = new Character(); 

            System.Console.WriteLine("Player 2 please enter your name! ");
            player2.Name = System.Console.ReadLine();
        
            System.Console.WriteLine($"{player2.Name} please choose your character or exit the system");
            System.Console.WriteLine("\n1. Jack Sparrow \n2. Will Turner \n3. Davy Jones \n4. Elizabeth Swann \n5. Captain Barbosa \n6. Choose Character at Random \n7. Exit the Game ");
            
            int chooseCharacter2 = int.Parse(Console.ReadLine());
            while(chooseCharacter2 > 6 && chooseCharacter2 < 1)
            {
                Console.WriteLine("Invalid input! Please choose a number between 1-6.");
                chooseCharacter2 = int.Parse(Console.ReadLine());
            }

            if(chooseCharacter2 == 1)
            {
                player2.characterType = 1;
                player2.Health = 100; 
                player2.SetAttackBehavior(new Distract()); 
                player2.MaxPower = GetMaxPower();
            }
            else if(chooseCharacter2 == 2 )
            {
                player2.characterType = 2;  
                player2.Health = 100; 
                player2.SetAttackBehavior(new Sword());
                player2.MaxPower = GetMaxPower();
            }
            else if(chooseCharacter2 == 3)
            {
                player2.characterType = 3;
                player2.Health = 100;  
                player2.SetAttackBehavior(new Cannon());
                player2.MaxPower = GetMaxPower(); 
            }
            else if (chooseCharacter2 == 4 )
            {
                player2.characterType = 4;  
                player2.Health = 100; 
                player2.SetAttackBehavior(new Stun());
                player2.MaxPower = GetMaxPower();
            }
            else if (chooseCharacter2 == 5 )
            {
                player2.characterType = 5;  
                player2.Health = 100; 
                player2.SetAttackBehavior(new MonkeyAttack());
                player2.MaxPower = GetMaxPower();
            }
            else if (chooseCharacter2 == 6 )
            {
                Random r = new Random();
                player2.characterType = r.Next(0,5);  
                player2.Health = 100; 
                player2.MaxPower = GetMaxPower();

                if (player2.characterType == 1)
                {
                    player2.SetAttackBehavior(new Distract());
                }
                else if (player2.characterType == 2)
                {
                    player2.SetAttackBehavior(new Sword());
                }
                else if (player2.characterType == 3)
                {
                    player2.SetAttackBehavior(new Cannon());
                }
                else if (player2.characterType == 4)
                {
                    player2.SetAttackBehavior(new Stun());
                }
                else
                {
                    player2.SetAttackBehavior(new MonkeyAttack());
                }
            }
            else if (chooseCharacter2 == 7)
            {
                System.Environment.Exit(0);
            }

            GameTime(player1, player2);
            
        }

       public static double GetMaxPower()
        {
            Random m = new Random();
            double MaxPower = m.Next(1,100);
            return MaxPower;
        }

        public static void GameTime(Character player1, Character player2)
        {
            System.Console.WriteLine("Let's play the Battle of Calypso's Maelstrom! \t.");
            System.Console.WriteLine("************************************************ \t.");

            Random r = new Random();
            int whosTurn = r.Next(0,2);

            if(whosTurn == 1)
            {

              while(player1.Health > 0 && player2.Health > 0  )  
              {
                
               System.Console.WriteLine($"{player1.Name} is attacking . . .");
               double DefensePower = player1.GetDefensePower();
               double AttackPower = player1.GetAttackPower(player1.MaxPower);
               double attack = player1.attackBehavior.Attack(player2, AttackPower, DefensePower);
               player2.Health = player2.Health - attack;
               System.Console.WriteLine($"Power done: {AttackPower} | Defense Power: {DefensePower} | Damage Dealt: {attack}");
               ShowPlayerStats(player2);
               ManageHealth(player2, player1);


               System.Console.WriteLine($"{player2.Name} is attacking . . .");
               DefensePower = player2.GetDefensePower();
               AttackPower = player2.GetAttackPower(player2.MaxPower);
               attack = player2.attackBehavior.Attack(player1, AttackPower, DefensePower);
               player1.Health = player1.Health - attack;
               System.Console.WriteLine($"Power done: {AttackPower} |  Defense Power: {DefensePower} | Damage Dealt: {attack}");
               ShowPlayerStats(player1);
               ManageHealth(player1, player2);
              }
            }
            else
            { 
            while(player1.Health > 0 && player2.Health > 0)  
              {
                
               System.Console.WriteLine($"{player2.Name} is attacking . . .");
               double DefensePower = player2.GetDefensePower();
               double AttackPower = player2.GetAttackPower(player2.MaxPower);
               double attack = player2.attackBehavior.Attack(player1, AttackPower, DefensePower);
               player1.Health = player1.Health - attack;
               System.Console.WriteLine($"Attack Power: {AttackPower} | Defense Power: {DefensePower} | Damage Dealt: {attack}");
               ShowPlayerStats(player1);
               ManageHealth(player1, player2);

                
                
               System.Console.WriteLine($"{player1.Name} is attacking . . .");
               DefensePower = player1.GetDefensePower();
               AttackPower = player1.GetAttackPower(player1.MaxPower);
               attack = player1.attackBehavior.Attack(player2, AttackPower, DefensePower);
               player2.Health = player2.Health - attack;
               System.Console.WriteLine($"Attack power: {AttackPower} | Defense Power: {DefensePower} | Damage Dealt: {attack}");
               ShowPlayerStats(player2);
               ManageHealth(player2, player1);
              }
            } 
        }

        public static void ShowPlayerStats(Character player)
        {
            System.Console.WriteLine($"{player.Name}'s stats: \n~ Health: {player.Health} ~ \n~ Max Power: {player.MaxPower} ~ ");
            System.Console.WriteLine("******************************************************** \t. ");
        }

        public static void ManageHealth(Character player, Character player1)
        {
            if(player.Health <= 0)
            {

                Console.WriteLine($" <<<<< {player1.Name} has won the game! >>>>>");
              
                System.Environment.Exit(0);
            }
        }
    }
}
