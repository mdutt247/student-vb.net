using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        
        public void disp()
        {
            Console.WriteLine("I am disp");
        }

    
    }

    class abc : Program
    {
        int i;

        abc()
        {
            i = 0;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            
            p1.disp();
            
            Console.ReadKey();
        }
    }
}
