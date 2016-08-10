using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame
{
    class Adventure
    {
            Player player;
            

        public string RunGame()
        {            
            player = new Player(Console.ReadLine());
            Console.WriteLine("Welcome to the Eastern Sea Region! \n Here we have people...among other things.");
            Console.WriteLine("Option 1: Dragon \n You begin your new life as a newborn dragon. \n You look badass and you are the last of your kind. \n");
            Console.WriteLine("Option 2: Human\n You wake up as a toddler with the knowledge of your past life. \n But, you are poor and live in the Slums. \n ");
            Console.WriteLine("Option 3: Elf\n You come from an ancient Elven race that protects the Ancient Tree. \n You are born with degenerative muscles so you can't do much to help out. \n Oh, and you are the only Prince. \n");
            Console.WriteLine("Please choose between Dragon, Human or Elf.");
            player.setOption(Console.ReadLine());

            switch (player.myOptions())
            {
                case "dragon":
                    Console.WriteLine("You have been born! \n ARIIIIIIISE YOUNG ONE!!!!");
                    break;
                case "human":
                    Console.WriteLine("Are you smart enough to get out of the situation that you're in?");
                    break;
                case "elf":
                    Console.WriteLine("Good Luck...You'll need it...Seriously");
                    break;
                default:
                    Console.WriteLine("That is not a valid Option, you fail at life");
                    player.setAlive(false);
                    break;
            }
            return player.myOptions();
        }
        public string youngDragon()
        {
            string decision;

            if(player.myOptions() == "dragon")
            {
                Console.ReadLine();
                Console.WriteLine("Welcome to the new world young dragon!\n You leave your cave and see two paths.\n On one path is a pig, the other is a road.\n What do you do? Fight or Walk away?");
                decision = Console.ReadLine();
                return decision;
            } else
            {
                Console.WriteLine("eh?");
                return Console.ReadLine();
            }
            
        }
        
    }

}

