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
            
            NPC enemy = new NPC(",", 300, "Kevin");
            NPC vendor = new NPC(",",150,"Axel");

            Console.WriteLine($"Hallo User! Gib bitte Deinen Namen ein: ");
            string userName = Console.ReadLine();

            //vendor.VendorDialog(userName);     // Test

            while (true)
            { 
                Console.Clear();
                Console.WriteLine($"Wähle eine Aktion:\n\t-1-{enemy.Name}\n\t-2-{vendor.Name}");
                string input = Console.ReadLine();
                if (input == "1") enemy.EnemyMenu();
                else if (input == "2") vendor.VendorMenu(userName);
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
}
