using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCWorld
{
    internal class NPCFriend : NPC 
    {
        public NPCFriend(int lp, string name, string[] dialogue) 
        { 
            Lp = lp;
            this.name = name;
            this.dialogue = dialogue;
        }
        public void Trade()
        {
            Console.WriteLine($"{Name} handelt mit Dir.");
            Console.ReadKey();
        }
    }
}
