using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_two_number
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 5, b = 6;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=30 (5*6)      
            b = a / b; //b=6 (30/5)      
            a = a / b; //a=5 (30/6)    
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}

