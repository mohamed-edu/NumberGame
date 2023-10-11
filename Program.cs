// namn : mohamed mohamud
// klass: NET23
namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök");
            Random random = new Random();
            checkguess(0,(random.Next(1, 21)));
            bool correctGuess = false;
        }



        public static void checkguess(int Try, int number)
        {
            bool correctguess = false;
            while (Try < 5)
            {
                Console.Write("Gissa på ett nummer mellan 1 och 20: ");
                if (int.TryParse(Console.ReadLine(), out int userGuess))
                {
                    Try++;

                    if (number == userGuess)
                    {
                        Console.WriteLine("Wohoo! Du klarade det!");
                        correctguess = true;
                        break;
                    }

                    else if (number > userGuess)
                    {
                        Console.WriteLine("Tyvärr, du gissade för lågt!");
                    }

                    else if (number < userGuess)
                    {
                        Console.WriteLine("Tyvärr, du gissade för högt!");
                    }

                    
                }

                if (!correctguess)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }
            }




        }


    }
}
