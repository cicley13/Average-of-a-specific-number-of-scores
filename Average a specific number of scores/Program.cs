using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_a_specific_number_of_scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            int math = 0;
            double ave;

            Console.WriteLine($"Number of test scores being inputed: ");
            int s = int.Parse(Console.ReadLine());
            //for statement allows you to loop an X amount of times
            for (int a = 0; a < s; a++)
            {
                Console.WriteLine($"Entry {a + 1} ");
                t = int.Parse(Console.ReadLine());

                while (t < 0 || t > 100)
                {
                    Console.WriteLine("Invalid number. Choose a number between 0 to 100");
                    t = int.Parse(Console.ReadLine());
                }
                math += t;
            }
                ave = math / s;

            Grade(ave);
        }

        public static void Grade(double x)
        {
            Console.WriteLine($"Your grade is : {x}");
            if (x > 90 || x > 100)
            {
                Console.WriteLine("That's a A!");
            }
            else if (x > 80 || x > 90)
            {
                Console.WriteLine("That's a B!");
            }
            else if (x > 70 || x > 80)
            {
                Console.WriteLine("THat's a C!");
            }
            else if (x > 60 || x > 70)
            {
                Console.WriteLine("That's a D!");
            }
            else if (x > 0 || x > 60)
            {
                Console.WriteLine("That's a F!");
            }
            Console.ReadLine();
        }

    }
}




