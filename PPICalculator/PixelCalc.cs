using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPICalculator
{
    public static class PixelCalc
    {
        public static Dictionary<String, Double> Calculate(Double screenWidth, Double screenHeight, double diagonalSize)
        {
            double PPI = Math.Sqrt(Math.Pow(screenWidth, 2) + Math.Pow(screenHeight, 2)) / diagonalSize;
            double diagonalInPixels = Math.Sqrt(Math.Pow(screenWidth, 2) + Math.Pow(screenHeight, 2));
            double dotPitch = diagonalSize / diagonalInPixels;

            Dictionary<string, double> ppiDictionary = new Dictionary<string, double>();
            ppiDictionary.Add("PPI", Math.Round(PPI, 2));
            ppiDictionary.Add("diagonalinPixels", Math.Round(diagonalInPixels, 0));
            ppiDictionary.Add("dotPitch", Math.Round(dotPitch * 25.4, 4));
            return ppiDictionary;
        }
    }
}
