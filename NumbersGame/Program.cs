namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
                               
            Random random = new Random(); // the secret number the user must guess.
            int number = random.Next(1, 21);//  produces a number  1-20 which becomes secret number.

            bool rätt = false;// It starts as false.

            for (int attempt = 1; attempt <= 5; attempt++)// Loop up to 5 times to give the player five guessing attempts.
            {
                Console.Write("Gissa ett tal mellan 1 och 20: ");

                int guess = int.Parse(Console.ReadLine()); // converts text into an integer.
              
                
                if (CheckGuess(guess, number))// If CheckGuess returns true the guess is correct.
                {
                    Console.WriteLine("Wohoo! Du gjorde det! :) talet är {0}", number);
                    rätt = true;
                  
                    break; // Stop the loop early 
                }
            }

            // After the loop, if the guess is still false the user has failed to guess with five attempts.
            if (rätt == false)
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                Console.WriteLine("Det hemliga talet var: {0}", number); // Print the secret number.
            }
        }

        static bool CheckGuess(int guess, int number)
        {
            // If the guess is less than the secret number print a hint and return false.
            if (guess < number)
            {
                Console.WriteLine("Tyvärr du gissade för lågt! :(");
                return false;
            }
            // If the guess is greater than the secret number print a hint and return false.
            else if (guess > number)
            {
                Console.WriteLine("Tyvärr du gissade för högt! :(");
                return false;
            }
            // Otherwise the guess is equal to the secret number so return true.
            else
            {
                return true;
            }
        }
    }
}
