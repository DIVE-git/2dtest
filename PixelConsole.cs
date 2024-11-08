using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dtest
{
    internal class PixelConsole
    {
        const bool DEBUG = true;

        // ==============================================


        public static void PrintPixel(int w, int h)
        {

            if (w > 120 || h > 30) throw new ArgumentException("Height or Width out of bounds");
           // bool[] matrix = new bool[10];
            
            
            
            

            Console.SetCursorPosition(0, h-1);

            for (int i = 0; i < w - 1; i++)
            {
                if (DEBUG) Console.Write('.');
                else Console.Write((Char)32);
            }
            Console.Write("\u25a0");

        }

        public static void PrintLine(bool[] massiv)
        {
            if (massiv.Length > 120) throw new ArgumentException("Height or Width out of bounds");
            foreach (bool i in massiv)
            {
                if (i == true) Console.Write("\u25a0");
                else if (DEBUG) Console.Write('.');
                else Console.Write((Char)32);
            }

        }
        public static void PrintLine(int[] massiv)
        {
            if (massiv.Length > 120) throw new ArgumentException("Height or Width out of bounds");
            foreach (int i in massiv)
            {
                if (i == 1) Console.Write("\u25a0");
                else if (DEBUG) Console.Write('.');
                else Console.Write((Char)32);
            }

        }
    }
}
