using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //library.
using System.ComponentModel.Design;

namespace c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Stopwatch sw = new Stopwatch();


            sw.Start();

            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine("Hello");
            }



            Console.WriteLine("waktu yang ditempu adalah :  " + sw.ElapsedMilliseconds);

            sw.Stop();

            sw.Reset();

            */
            menu:
            try
            {
                Console.Write("input number : ");
                int n = int.Parse(Console.In.ReadLine());
            }
            catch (FormatException)
            {

                Console.WriteLine("inputan harus angka");
                goto menu;
            }

            finally
            {
                Console.WriteLine("hello");
            }

            Console.WriteLine("fdfdf");




        }
    }
}
