using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        //Faction for (+)...
        public static int sum1(int x, int y) {



            return (x + y);
            }
        //Faction for (-)...
        public static float sum2(int x ,int y) {




            return (x - y);
        }
        static void Main(string[] args)
        {
            int k ,s;
         
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t\t\t");
            
            s = Convert.ToInt32(Console.ReadLine());
            float r = sum1(k, s);
            float d = sum2(s, k);
            Console.WriteLine(r);
            Console.Write(d);

          
            












            Console.ReadKey();






        }
    }
}
