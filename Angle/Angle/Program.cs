using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angle
{
    internal class Program
    {
        static void Main(string[] args)

        {   const int angleCount = 3;
            int[] angles = new int[angleCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.WriteLine($"Enter angle [i]");
                 angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;
            foreach(int angle in angles)
            {
                angleSum += angle;
            }
            if (angleSum == 180)
            {
                Console.WriteLine("The angles form a triangle.");
            }
            else
            {
                Console.WriteLine("The angles do not form a triangle.");
            }



        }
    }
}
