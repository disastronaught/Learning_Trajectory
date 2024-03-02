//this is fairly standard for entry level CS. These modules are kind of glazed over, so I'm 
//really glad I have had coding experience outside of this. 

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
            int[] a = new int[5] { 50, 60, 10, 30, 40 };

            //for array of index n, we get indexes 0 to n-1
            Console.WriteLine(a[0]);
            
            for(int i = 0; i< a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }


            byte[] b = new byte[2];

            Array.Clear(b, 0, b.Length);
            Console.WriteLine(b[0]);
          Console.ReadKey();
          
        }
    }
}
