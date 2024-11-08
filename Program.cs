using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System;   
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using draw = _2dtest.PixelConsole;
namespace _2dtest
{
    internal class Program
    {



        static void Main(string[] args)
        {
            /*
             Итак, можно использовать символ квадрата: \u25a0
             Разрешение экрана 120x30
             Я предлагаю просто-напросто передавать буллевый массив
             И класс будет просто напросто построчно рисовать дисплей. 
             Иначе, класс PixelConsole будет ну типа планировщиком, а в основном коде будем уже писать пиксели

            

            */
            int width = 120;
            int height = 4;

            bool[] matrixB = { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            int[] matrixI = {1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            Console.Title = "It's 2DTest Console Graphics";

            while (true)
            {
                draw.PrintLine(matrixB);
                //MessageBox.Show("Hola");
                

                Console.ReadKey();
            }

        }
    }
}
