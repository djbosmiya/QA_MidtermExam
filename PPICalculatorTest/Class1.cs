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

            [Test]
            public void CalculatePPI_Input720and480and10point5_Output82point41and0point3082and865()
            {
                //Arrange 
                double width = 720;
                double height = 480;
                double diagonalSize = 10.5;

                string expected = "\n\nPPI: " + 82.41 + " \nDot Pitch: " + 0.3082 + " \nDiagonal Size in Pixels: " + 865;

                //Act
                Dictionary<string, double> ppiDictionary = new Dictionary<string, double>();
                ppiDictionary = PixelCalc.Calculate(width, height, diagonalSize);
                string actual = "\n\nPPI: " + ppiDictionary["PPI"] + " \nDot Pitch: " + ppiDictionary["dotPitch"] + " \nDiagonal Size in Pixels: " + ppiDictionary["diagonalinPixels"];

                //Assert 
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void CalculatePPI_Input2880and1080and15point0_Output205point06and0point1239and3076()
            {
                //Arrange 
                double width = 2880;
                double height = 1080;
                double diagonalSize = 15.0;

                string expected = "\n\nPPI: " + 205.06 + " \nDot Pitch: " + 0.1239 + " \nDiagonal Size in Pixels: " + 3076;

                //Act
                Dictionary<string, double> ppiDictionary = new Dictionary<string, double>();
                ppiDictionary = PixelCalc.Calculate(width, height, diagonalSize);
                string actual = "\n\nPPI: " + ppiDictionary["PPI"] + " \nDot Pitch: " + ppiDictionary["dotPitch"] + " \nDiagonal Size in Pixels: " + ppiDictionary["diagonalinPixels"];

                //Assert 
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void CalculatePPI_Input4000and2980and19point8_Output251point92and0point1008and4988()
            {
                //Arrange 
                double width = 4000;
                double height = 2980;
                double diagonalSize = 19.8;

                string expected = "\n\nPPI: " + 251.92 + " \nDot Pitch: " + 0.1008 + " \nDiagonal Size in Pixels: " + 4988;

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
