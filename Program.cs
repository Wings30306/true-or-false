using System;
using System.Net;

namespace trueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False? Space Edition!'\nPress Enter to begin:");
            string entry = Console.ReadLine();

            // Type your code below
            string[] questions = new string[] {"The Earth is flat", "The Earth goes around the sun", "The Earth rotates around the sun in 24 hours", "An Earth year is the same length of time as a year on Jupiter"}; 
            bool[] answers = new bool[] {false, true, false, false};
            bool[] responses = new bool[questions.Length];
            if (questions.Length == answers.Length) 
            {
                Quiz();
            }
            else 
            {
                Console.WriteLine("Oops, something went wrong. We don't have the same number of questions and answers!");
            }

            void Quiz() 
            {
                int askingIndex = 0;
                foreach (string question in questions) {
                    Console.WriteLine(question);
                    Console.WriteLine("True or false?");
                    string input = Console.ReadLine();
                    bool isBool = Boolean.TryParse(input, out bool inputBool);
                    while (!isBool)
                    {
                        Console.WriteLine("Please respond with 'true' or 'false'.");
                        input = Console.ReadLine();
                        isBool = Boolean.TryParse(input, out inputBool);
                    }
                    responses[askingIndex] = inputBool;
                    askingIndex++;
                }
                int score = 0;
                for (int scoringIndex = 0; scoringIndex < questions.Length; scoringIndex++)
                {
                    if (answers[scoringIndex] == responses[scoringIndex]) 
                    {
                        score++;
                    }
                    Console.WriteLine($"{scoringIndex + 1}. Input: {responses[scoringIndex]} | Correct answer: {answers[scoringIndex]}");
                }
                Console.WriteLine($"Your score: {score}/{questions.Length}");
            }
        }
    }
}
