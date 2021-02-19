using System;

namespace try2
{
    class Program
    {
        static void laba1()
        {
            string buf;

            Console.WriteLine("Input alpha: ");
            buf = Console.ReadLine();
            double a = Convert.ToDouble(buf);


            double z1 = Math.Sin((Math.PI / 2) + (3 * a)) / (1 - Math.Sin((3 * a) - Math.PI));
            double z2 = 1 / Math.Tan((5 / 4 * Math.PI) + (3 / 2 * a));

            Console.WriteLine("z1=" + z1);
            Console.WriteLine("z2=" + z2);
        }
        static void Main(string[] args)
        {
            laba1();
        }
    }
}
