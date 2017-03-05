using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HU_M01_Exam_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Q1 - Print 5 numbers average

            //double arrayASum = 0;
            //double[] numbersArrayA = new double[5];
            //for (int i = 0; i < numbersArrayA.Length; i++)
            //{
            //    Console.WriteLine("Please enter a number");
            //    numbersArrayA[i] = double.Parse(Console.ReadLine());
            //    arrayASum += numbersArrayA[i];
            //}
            //Console.WriteLine("The average is " + arrayASum / numbersArrayA.Length);

            //// Q2 - Print the square number of a number

            //Console.WriteLine("Please enter a number");
            //int squareNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("The square number is " + squareNumber * squareNumber);

            //// Q3 - Numbers calculations

            //Console.WriteLine("Please enter 4 numbers");
            //int calcNumA = int.Parse(Console.ReadLine());
            //int calcNumB = int.Parse(Console.ReadLine());
            //int calcNumC = int.Parse(Console.ReadLine());
            //int calcNumD = int.Parse(Console.ReadLine());

            //Console.WriteLine("NumA + NumB = " + (calcNumA + calcNumB));
            //Console.WriteLine("NumB - NumD = " + (calcNumB - calcNumD));
            //Console.WriteLine("NumC / 8 = " + (calcNumC / 8));
            //Console.WriteLine("NumD * NumA = " + (calcNumD*calcNumA));

            // Q13 - *Square

            Console.WriteLine("Please enter a number");
            int asteriskNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < asteriskNum; i++)
            {
                for (int j = 0; j < asteriskNum; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // How to create rhombus

            Console.WriteLine("Please enter a number");
            int theNumber = int.Parse(Console.ReadLine());

            // The upper part:

            for (int i = 0; i <= theNumber; i++) // This "for" is for the number of lines
            {
                for (int j = 0; j < theNumber-i; j++) // This "for" is the number of spaces before i
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++) // This "for" is for printing the number
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }

            // The lower part:

            for (int i = theNumber-1; i > 0; i--)
            {
                for (int j = 0; j < theNumber-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }



        }
    }
}
