using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
     class MyMath
    {
        public const double PI = 3.14;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with constant");
            Console.WriteLine("the value of  PI is: {0}", MyMath.PI);
            //Error! can't change a constant
            //myMath.PI=3.45995;

            Console.ReadLine();
        }
    }
}
