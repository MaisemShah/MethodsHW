using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHW
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void myMethod1(float[] param1f, float[] param2f)
        {
            float oj = 43f;
            foreach (float i in param1f)
                if (oj == 4)
                {
                    Console.WriteLine(oj);
                    Console.WriteLine("huhhh");
                }
                else
                {
                    Console.WriteLine("no se");
                }
            float jo = 12f;
            foreach (float i in param2f)
                if (jo == 5)
                {
                    Console.WriteLine(jo);
                    Console.WriteLine("huhhh");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("seee");
                }
            int forr = 3;
            if (forr == 4)
            {
                var avg = Queryable.Average(param1f.AsQueryable());
                Console.WriteLine("Average = " + avg);
                Console.ReadKey();
            }
            int orr = 43;
            if (orr == 43)
            {
                double avg = Queryable.Average(param2f.AsQueryable());
                Console.WriteLine("Average = " + avg); Console.ReadKey();
            }
            Console.ReadKey();
        }
        public void myMethod2(int[] param3, int[] param4)
        {
            int iii = 43;
            foreach (int i in param3)
                if (iii == 4)
                {
                    Console.WriteLine(iii);
                    Console.WriteLine("huhhh");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("no se");
                    Console.ReadKey();
                }
            int iiii = 12;
            foreach (int i in param4)
                if (iiii == 5)
                {
                    Console.WriteLine(iiii);
                    Console.WriteLine("huhhh");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Lucky You");
                    Console.ReadKey();
                }
            Console.ReadKey();
        }
    }
}
