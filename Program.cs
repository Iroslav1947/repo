using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repo
{
    class Program
    {
        class Point
        {
            public int x
            public int y 
            public char sym
        }

        static void Main(string[] args)
        {
            Point p1 = new Point()
            Draw(p1..x, p1..y, p1..sym);
            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
           
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        class Point 
        {
            int x;
            int y;
            char sym;
        }

    }
}
