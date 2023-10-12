using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10._2023__Strukture_
{
    internal class Program
    {
        struct Vektor
        {
            public double x, y, z;
            public override string ToString()
            {
                return "("+x+", "+y+", "+z+")";
            }
        }
        static void Main(string[] args)
        {
            Vektor v;
            v.x =  1;
            v.y = -1;
            v.z =  1;
            Console.WriteLine(v.ToString());

            Vektor z=new Vektor();
            z.x =  2; 
            z.y = -1; 
            z.z =  1;
            Console.WriteLine(z.ToString());

            Console.ReadLine();
        }
    }
}
