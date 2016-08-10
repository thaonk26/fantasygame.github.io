using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame
{
    class Player
    {
        string name;
        bool alive = true;
        string option;
        string fight;

        public Player(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setAlive(bool alive)
        {
            this.alive = alive;
        }
        public bool IsAlive()
        {
            return alive;
        }
        public string myOptions()
        {
            return option;
        }
        public void setOption(string option)
        {
            this.option = option;
        }
        public string firstFight()
        {
            return this.fight;
        }
        public void startFight(string fight)
        {
            this.fight = fight;
        }
    }
}
