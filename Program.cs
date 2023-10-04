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
            int number = random.Next(1, 21);
            int Try = 0;
            bool checkGuess = false;


            while (Try < 5)
            {
                Console.Write("Gissa på ett nummer mellan 1 och 20: ");
                if (int.TryParse(Console.ReadLine(), out int userGuess))
                {
                    Try++;

                    if (number == userGuess)
                    {
                        Console.WriteLine("Wohoo! Du klarade det!");
                        checkGuess = true;
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

                else
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }
                if (!checkGuess)
                {
                    Console.WriteLine("du kan bara skriva ett nummer");
                }
            }








        

         

        }
    
        
    }
}
