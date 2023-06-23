using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            double screenWidth, screenHeight, diagonalSize;

            while (!exit)
            {
                Console.WriteLine("Menu for Screen Dimension");
                Console.WriteLine("1. Enter Screen dimensions");
                Console.WriteLine("2. Exit");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        try
                        {
                            Console.Write("Width (in pixels): ");
                            screenWidth = double.Parse(Console.ReadLine());

                            Console.Write("Height (in pixels): ");
                            screenHeight = double.Parse(Console.ReadLine());

                            Console.Write("Diagonal size (in inches): ");
                            diagonalSize = double.Parse(Console.ReadLine());

                            Dictionary<string, double> ppiDictionary = new Dictionary<string, double>();
                            ppiDictionary = PixelCalc.Calculate(screenWidth, screenHeight, diagonalSize);
                            Console.WriteLine("\n\nPPI: " + ppiDictionary["PPI"] + " \nDot Pitch: " + ppiDictionary["dotPitch"] + " \nDiagonal Size in Pixels: " + ppiDictionary["diagonalinPixels"]);
                        }
                        catch (Exception e)
                        {
                            Console.Write("\n" + e.ToString() + "\n");
                        }
                        break;
                    case "2":
                        exit = true;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please select correct option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
