using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCWorld
{
    internal class NPCEnemy : NPC
    {
        public NPCEnemy(int lp, string name, string[] dialogue)
        {
            lp = lp;
            this.name = name;
            this.dialogue = dialogue;
        }
        public void Fight()
        {
            Console.WriteLine($"{Name} greift an!");
            Console.ReadKey();  
        }
    }
}
