using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventure journey = new Adventure();
            journey.RunGame();
            string nextDragon = journey.youngDragon();
            
        }
    }
}
