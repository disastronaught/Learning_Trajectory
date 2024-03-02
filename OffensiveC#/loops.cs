//the loops section was fairly succinct. There's honestly not much too it until you have you're own conditions to
//add and purposes for building them.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffensiveCIntroduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i=0; i<=100; i++)
            {
                Console.WriteLine("Success");
            }
            
            int j = 0;
            while (j < 100)
            {
                Console.WriteLine("j increases");
                j++;
            }
            */

            Console.Write("Enter your ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (id == 0)
            {
                Console.WriteLine("You are root.");
            } else
            {
                Console.WriteLine("You're a standard user.");
            }


          Console.ReadKey();
          
        }
    }
}
