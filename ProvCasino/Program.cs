using System;

namespace ProvCasino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen beim ProvCasino!");
            Console.WriteLine("Drücke Enter, um zu spielen.");
            Console.ReadLine();

            Random random = new Random();
            int[] symbols = { 0, 1, 2 }; 
            int[] result = new int[3];

         
            ISlotMachineFactory factory = new SlotMachineFactory();
            SlotMachine slotMachine = factory.CreateSlotMachine();

            while (true)
            {
                
                for (int i = 0; i < 3; i++)
                {
                    result[i] = symbols[random.Next(0, symbols.Length)];
                }

               
                Console.WriteLine($"[{result[0]}] [{result[1]}] [{result[2]}]");

               
                if (result[0] == result[1] && result[1] == result[2])
                {
                    Console.WriteLine("Wow! Du hast gewonnen:)!");
                }
                else
                {
                    Console.WriteLine("Schade Schokolade");
                }

                Console.WriteLine("Drücke Enter, um erneut zu spielen oder schreibe 'exit', um das Spiel zu beenden.");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;
            }

            Console.WriteLine("Vielen Dank fürs Spielen. Auf Wiedersehen!");
        }
    }
}
