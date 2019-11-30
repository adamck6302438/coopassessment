//Reference: W3Schools C# syntax: https://www.w3schools.com/cs/cs_syntax.asp

using System;

namespace GuessTheFood
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. - 2. List 5 available food for user to guess
            string[] foodList = { "Pizza", "Pasta", "Salmon", "Steak", "Miso" };
            Console.WriteLine("Welcome to 'Guess The Food!'");
            Console.WriteLine("Here are a list of foods: ");
            for (int i = 0; i < foodList.Length; i++)
            {
                Console.WriteLine(" - " + foodList[i]);
            }

            //3. Pick one of the food randomly
            var random = new Random();
            int num = random.Next(foodList.Length+1);
            int life = 3;
            string correctGuess = foodList[num];

            //4. A while loop that exits when user's life is zero
            while (true) {
                Console.Write($"Please enter the name of the food you are guessing: ");
                string guess = Console.ReadLine();

                //6. Congratulate user when guess correctly and break the loops
                if (string.Compare(guess.Trim().ToLower(), correctGuess.ToLower()) == 0)
                {
                    Console.WriteLine($"Congrats! You made the right guess! It was {correctGuess}!");
                    break;
                }
                else
                {
                    //5. Show corresponding message when user make a wrong guess or has used up all 3 tries
                    life--;
                    if (life == 0)
                    {
                        Console.WriteLine($"Game Over. The correct answer is {correctGuess}");
                        break;
                    }
                    else {
                        Console.WriteLine($"Sorry try again. You have {life} life left.");
                    }

                }
            }

            
        }
    }
}
