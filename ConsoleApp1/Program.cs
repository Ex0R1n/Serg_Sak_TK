using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {

        public static int ResultCalc(int score_1, int score_2, int score_3)
        {
            int result = score_1 + score_2 + score_3;
            return result;
        }

        
        public static void Main(string[] args)
        {
            int score_1;
            int score_2;
            int score_3;

            Console.WriteLine("1 Score:");
            score_1 = Int32.Parse(Console.ReadLine());
            if (score_1 > 22)
            {
                Console.WriteLine("Больше диапазона. 22 max");
                return;
            }

            Console.WriteLine("2 Score:");
            score_2 = Int32.Parse(Console.ReadLine());
            if (score_2 > 38)
            {
                Console.WriteLine("Больше диапазона. 38 max");
                return;
            }

            Console.WriteLine("3 Score:");
            score_3 = Int32.Parse(Console.ReadLine());
            if (score_3 > 20)
            {
                Console.WriteLine("Больше диапазона. 20 max");
                return;
            }

            int result = ResultCalc(score_1, score_2, score_3);

            Console.WriteLine("Result Score:");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}