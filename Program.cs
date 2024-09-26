using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("how many times? ");
            int loopTime = Convert.ToInt32(Console.ReadLine());

            while (loopTime < 0) 
            {
            Console.WriteLine("enter value > 0 ");
            Console.Write("how many times? ");
            loopTime = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < loopTime; i++)
            {
                Console.WriteLine(i);
            }









            Console.ReadLine();
            

        }
    }
}
