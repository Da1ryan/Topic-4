using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Topic_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random Integers
            Random generator = new Random();
            int minVal;
            int maxVal;
            
            
            Console.WriteLine("Please Enter a Minimum Value");
            minVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter a Maximum Value");
            maxVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int num1;
            num1 = generator.Next(minVal, maxVal + 1);
            int num2;
            num2 = generator.Next(minVal, maxVal + 1);
            int num3;
            num3 = generator.Next(minVal, maxVal + 1);
            int num4;
            num4 = generator.Next(minVal, maxVal + 1);
            int num5;
            num5 = generator.Next(minVal, maxVal + 1);
            Console.Write(num1 );
            Console.Write(", ");
            Console.Write(num2 );
            Console.Write(", ");
            Console.Write(num3 );
            Console.Write(", ");
            Console.Write(num4 );
            Console.Write(", ");
            Console.Write(num5 );
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
            // Dice Roller
            Die die1 = new Die();
            Die die2 = new Die();
            die1.RollDie();
            
            Console.WriteLine("Press enter to roll a die.");
            Console.ReadLine();
            Console.WriteLine($"You rolled a {die1}");
            Console.WriteLine("Press enter to roll again.");
            Console.ReadLine();
            Console.WriteLine($"You rolled a {die2}");
            Console.WriteLine($"Your sum is {die1.Roll + die2.Roll}");
            Console.ReadLine();
            Console.WriteLine();
            //Random decimal numbers
            int num01;
            int num02;
            int num03;

            Console.WriteLine("Please Generate 3 numbers from the beginning by pressing enter");
            Console.ReadLine();
            num01 = generator.Next(minVal, maxVal + 1);
            num02 = generator.Next(minVal, maxVal + 1);
            num03 = generator.Next(minVal, maxVal + 1);

            Console.WriteLine($"You generated {num01}, {num02}, {num03}.");














        }
    }
}
