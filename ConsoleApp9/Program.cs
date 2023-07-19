using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public delegate bool WinnerCondition(int energyLevel, int winningProbability);

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("enter your lucky number");
            int luckyNumber = int.Parse(Console.ReadLine());
            int energyLevel = 1;
            int winningProbability = 100;
            int spinCount = 0;
            WinnerCondition condition = CheckWinnerCondition;
            while (spinCount < 10)
            {
                spinCount++;
                Console.WriteLine($"Spin {spinCount}:");
                if (spinCount == 1)
                {
                    energyLevel++;
                    winningProbability += 10;
                }
                else if (spinCount == 2)
                {
                    energyLevel += 2;
                    winningProbability += 20;
                }
                else if (spinCount == 3)
                {
                    energyLevel -= 3;
                    winningProbability -= 30;
                }
                else if (spinCount == 4)
                {
                    energyLevel += 4;
                    winningProbability += 40;
                }
                else if (spinCount == 5)
                {
                    energyLevel -= 5;
                    winningProbability -= 50;
                }
                else if (spinCount == 6)
                {
                    energyLevel -= 1;
                    winningProbability -= 60;
                }
                else if (spinCount == 7)
                {
                    energyLevel += 1;
                    winningProbability += 70;
                }
                else if (spinCount == 8)
                {
                    energyLevel -= 2;
                    winningProbability -= 20;
                }
                else if (spinCount == 9)
                {
                    energyLevel -= 3;
                    winningProbability -= 30;
                }
                else if (spinCount == 10)
                {
                    energyLevel += 10;
                    winningProbability += 100;
                }
                Console.WriteLine($"energy level ={energyLevel}");
                Console.WriteLine($"Winning Probability = {winningProbability}");
                if (condition(energyLevel, winningProbability))
                {
                    Console.WriteLine("Congratulations you won the game");
                    break;

                }
            }
            if (spinCount >= 10)
                Console.WriteLine("you lost the game");
            Console.ReadLine();
        }
        static bool CheckWinnerCondition(int energyLevel , int winningProbability)
        {
            return energyLevel >= 1 && winningProbability > 50 && winningProbability - energyLevel > 60;
        }
        }
    }

