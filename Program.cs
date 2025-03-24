using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace QuizProject
{
    internal class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Welcome to the Quiz App");
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            while (true)
            {
                showMenu();
                int choice = getANumber();
                switch (choice)
                {
                    case 1: askQuestion(); break;
                    case 2: Environment.Exit(0); break;
                    default: Console.WriteLine("You Entered the wrong option!"); break;
                }
            }
        }
        static void showMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Start Quiz");
            Console.WriteLine("2. Exit");
            Console.WriteLine();
        }

        static int getANumber()
        {
            int n;
            Console.WriteLine();
            Console.WriteLine("Please Enter Your Choice: ");
            n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        static void askQuestion()
        {
            score = 0;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PLEASE ANSWER FOLLOWING QUESTIONS:");
            Console.WriteLine();
            string[,] questions = new string[3, 4]
            {
                { "1. What is the binary version of 3?", "A. 10","B. 11","C. 100"},
                { "2. What is called Computer Componenets that we can touch?", "A. Hardware","B. Algorithm","C. Software"},
                { "3. What is called human readable form of code?", "A. Pseudo-Code","B. Machine Language","C. Flow chart"}
            };
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(questions[i, 0]);
                Console.WriteLine(questions[i, 1]);
                Console.WriteLine(questions[i, 2]);
                Console.WriteLine(questions[i, 3]);
                Console.WriteLine("Please choose your answer: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                string answer = Console.ReadLine().Trim().ToUpper(); ;
                Console.ForegroundColor = ConsoleColor.Green;
                if (i == 0 && answer == "B")
                {
                    Console.WriteLine("Correct");
                    Console.WriteLine();
                    score+=5;
                }
                else if (i == 1 && answer == "A")
                {
                    Console.WriteLine("Correct");
                    Console.WriteLine();
                    score+=5;
                }
                else if (i == 2 && answer == "A")
                {
                    Console.WriteLine("Correct");
                    Console.WriteLine();
                    score+=5;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong!");
                    Console.WriteLine();
                }
            }

            textQuestions();

            DisplayScore();
        }

        static void textQuestions()
        {

            string[,] textQuestions = new string[2, 2]
            {
                { "4. What datatype stores a natural number?", "INT"},
                { "5.  120 % 10 == 12? True | False", "FALSE"}
            };
            for (int i = 0; i < 2; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(textQuestions[i, 0]);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine();
                string answer = Console.ReadLine().Trim().ToUpper();
                if (answer == textQuestions[i, 1])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct");
                    Console.WriteLine();
                    score += 5;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong");
                    Console.WriteLine();
                }
            }
        }
        static void DisplayScore()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The questions are over!");
            int total = score * 4;
            Console.ForegroundColor = ConsoleColor.Green;
            if (total >= 80) Console.WriteLine($"Excellent! Your Score is {total}%");
            else if (total >= 60) Console.WriteLine($"Good! Your Score is {total}%");
            else if (total >= 40) Console.WriteLine($"Satisfactory! Your Score is {total}%");
            else if (total >= 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Poor! Your Score is {total}%");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Failed! Your Score is {total}%");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
