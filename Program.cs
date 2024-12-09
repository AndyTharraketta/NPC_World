using System.Diagnostics.SymbolStore;

namespace NPCWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstelle eine Klasse NPC mit den Feldern Dialog Lebenspunkte und Name.
            //Erstelle eine Methode um mit dem NPC zu interagieren bzw um ausgaben aus dem Feld Dialog zu generieren
            //Es sollen auf Basis dieser Klasse zwei Kind-Klassen erzeugt werden und zwar NPCFeind und NPCFreund
            //Bei einem freundlichen NPC soll es eine möglichkeit geben zu handeln (Trading muss nicht implementiert werden) lediglich Ausgabe
            //Bei einem feindlichen NPC soll es zu einem Kampf kommen (Daselbe wie beim Trading)
            //Erstellt aus den Kindklassen 4 Objekte also 2 freundliche NPCs und zwei feindliche.
            //Erstelle in der Program.cs eine Methode um auf die verschiedenen NPCs zuzugreifen bzw. mit diesen zu Interagieren.

            //Für Fortgeschrittene implemtiert Handeln und Kämpfen passt dafür die Felder ggf. an 

            //Tipp: Für das Inventory recherchieren zum Thema Listen bzw dynamische Listen

            Console.ForegroundColor = ConsoleColor.Yellow;

            //NPC enemy = new NPC(",", 300, "Kevin");
            //NPC vendor = new NPC(",",150,"Axel");

            //Console.WriteLine($"Hallo User! Gib bitte Deinen Namen ein: ");
            //string userName = Console.ReadLine();

            ////vendor.VendorDialog(userName);     // Test

            //while (true)
            //{ 
            //    Console.Clear();
            //    Console.WriteLine($"Wähle eine Aktion:\n\t-1-{enemy.Name}\n\t-2-{vendor.Name}");
            //    string input = Console.ReadLine();
            //    if (input == "1") enemy.EnemyMenu();
            //    else if (input == "2") vendor.VendorMenu(userName);
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Falsche Eingabe!");
            //        Console.ForegroundColor = ConsoleColor.DarkYellow;
            //        Console.WriteLine("\nTaste drücken zum fortsetzten");
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.ReadKey();
            //    }

            // Korrektur

            //NPC testNPC = new NPC(60, "Karsten",["Hallo ich bin Karsten!","Freut mich Dich kennenzulernen!","Wie geht es Dir?"]);

            //testNPC.Interact();

            Menu();
            

            Console.ResetColor();
        }

        public static void Menu()
        {
            NPCFriend npc1 = new NPCFriend(50, "Maria", ["Hallo ich bin Maria aus Flußwald.","Warst Du schon mal in Flußwald?","Ich habe einige Waren von dort die ich zu Handeln anbiete."]);
            NPCFriend npc2 = new NPCFriend(200, "Alfred", ["Ich verkaufe Dir die besten Waren","Ich weiß nicht wem sie vorher gehört haben.","Was sagst Du dazu?"]);
            NPCEnemy npc3 = new NPCEnemy(300,"Böser Bör", ["Grrrrr"]);
            NPCEnemy npc4 = new NPCEnemy(120,"Fitz den Argonier", ["Dein Gold ...","UND DEIN LEBEN"]);

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Mit welchem NPC möchtest Du interagieren? (1 - 4)\n\n1. {npc1.Name}\n\n2. {npc2.Name}\n\n3. {npc3.Name}\n\n4. {npc4.Name}\n");
                string input = Console.ReadLine();

                if (input == "1") npc1.Interact(npc1);
                else if (input == "2") npc2.Interact(npc2);
                else if (input == "3") npc3.Interact(npc3);
                else if (input == "4") npc4.Interact(npc4);
                else
                {
                    Console.WriteLine("Eingabe ist ungültig!");
                }
            }

        }

    }
}

