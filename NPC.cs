using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCWorld
{
    internal class NPC
    {
        string dialog;
        int lebenspunkte;
        string name;

        public NPC(string dialog, int lebenspunkte, string name)
        {
            this.dialog = dialog;
            this.lebenspunkte = lebenspunkte;
            this.name = name;
        }

        public string Dialog { get => dialog; set => dialog = value; }
        public int Lebenspunkte { get => lebenspunkte; set => lebenspunkte = value; }
        public string Name { get => name; set => name = value; }

        public void VendorDialog(string userName)
        {
            Console.Clear();
            Console.WriteLine($"\tHallo {userName}!\nMein Name lautet {name}!\nIch habe verschiedene Waren im Angebot!");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nTaste drücken zum fortsetzten");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadKey();

        }

        public void EnemyDialog(string userName)
        {
            Console.Clear();
            Console.WriteLine($"Argh! Ich bin {name}! Ich will mit Dir kämpfen!");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nTaste drücken zum fortsetzten");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadKey();

        }

        public void VendorStats()
        {
            Console.Clear();
            Console.WriteLine($"\t\t-Stats-\n\n\tName:\t\t{name}\n\tLP:\t\t{lebenspunkte} Punkte");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nTaste drücken zum fortsetzten");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadKey();
        }

        public void EnemyStats()
        {
            Console.Clear();
            Console.WriteLine($"\t\t-Stats-\n\n\tName:\t\t{name}\n\tLP:\t\t{lebenspunkte} Punkte");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nTaste drücken zum fortsetzten");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadKey();
        }

        public void VendorMenu(string userName)
        {
            Console.Clear();
            Console.WriteLine("Wähle eine Aktion:\n\t\t-1-Gespräch\n\t\t-2-Inspitieren");
            string input = Console.ReadLine();
            if (input == "1") VendorDialog(userName);
            else if (input == "2") VendorStats();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Falsche Eingabe!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nTaste drücken zum fortsetzten");
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.ReadKey();
            }
        }

        public void EnemyMenu()
        {
            Console.Clear();
            Console.WriteLine("Wähle eine Aktion:\n\t\t-1-Gespräch\n\t\t-2-Inspitieren");
            string input = Console.ReadLine();
            if (input == "1") EnemyDialog(",");
            else if (input == "2") EnemyStats();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Falsche Eingabe!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nTaste drücken zum fortsetzten");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ReadKey();
            }
        }

    }
}
