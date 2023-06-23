using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPICalculator;
using NUnit.Framework;

namespace PPICalculatorTest
{
    public class PPICalculatorTest
    {
        [TestFixture]
        public class PPICalulatorTestCase1
        {
            [Test]
            public void CalculatePPI_Input1920and720and15point4_Output133point15and0point1908and2051()
            {
                //Arrange 
                double width = 1920;
                double height = 720;
                double diagonalSize = 15.4;

                string expected = "\n\nPPI: " + 133.15 + " \nDot Pitch: " + 0.1908 + " \nDiagonal Size in Pixels: " + 2051;

                //Act
                Dictionary<string, double> ppiDictionary = new Dictionary<string, double>();
                ppiDictionary = PixelCalc.Calculate(width, height, diagonalSize);
                string actual = "\n\nPPI: " + ppiDictionary["PPI"] + " \nDot Pitch: " + ppiDictionary["dotPitch"] + " \nDiagonal Size in Pixels: " + ppiDictionary["diagonalinPixels"];

                //Assert 
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void CalculatePPI_Input1880and1080and13point0_Output166point78and0point1523and2168()
            {
                //Arrange 
                double width = 1880;
                double height = 1080;
                double diagonalSize = 13.0;

                string expected = "\n\nPPI: " + 166.78 + " \nDot Pitch: " + 0.1523 + " \nDiagonal Size in Pixels: " + 2168;

                //Act
                Dictionary<string, double> ppiDictionary = new Dictionary<string, double>();
                ppiDictionary = PixelCalc.Calculate(width, height, diagonalSize);
                string actual = "\n\nPPI: " + ppiDictionary["PPI"] + " \nDot Pitch: " + ppiDictionary["dotPitch"] + " \nDiagonal Size in Pixels: " + ppiDictionary["diagonalinPixels"];

                //Assert 
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
