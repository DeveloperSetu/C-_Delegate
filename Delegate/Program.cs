using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================== Gelegate =================");
            AddDelegate addDelegate = new AddDelegate(AddNums);
            AddDelegate subDelegate = new AddDelegate(SubNums);
            Console.WriteLine(addDelegate(10, 20));
            Console.WriteLine(subDelegate(80, 20));


            Console.WriteLine("=================END===================");

            Console.ReadKey();
        }

        public static int AddNums(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int SubNums(int num1, int num2)
        {
            return num1 - num2;
        }
    }//internal class

    //Delegate..
    public delegate int AddDelegate(int x, int y);
}
