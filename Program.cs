using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repo
{
    class Program
    {
        static void Main(string[] args)
        {
            //module1
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            Draw(x1, y1, sym1);

            //module2
            int x2 = 7;
            int y2 = 7;
            char sym2 = '#';
            Draw(x2, y2, sym2);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
           
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}
