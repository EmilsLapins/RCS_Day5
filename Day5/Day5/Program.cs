using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;


            StartupSound sound = new StartupSound();
            sound.StartupSkana();



            pd1_1 pd1_1 = new pd1_1();
            pd1_2 pd1_2 = new pd1_2();
            
            Console.WriteLine("Ludzu izvelaties klasi! 1: pd1_1 2: pd1_2 (Talak sekos izveles iespejas) ");

            string izvele = Console.ReadLine();
            switch (izvele)
            {
                case "1":
                    Console.WriteLine("Ievade ir 1 ");
                    pd1_1.Publiska();
                    break;

                case "2":
                    Console.WriteLine("Ievade ir 2 ");
                    pd1_2.Publiska();

                    break;

                default:
                    Console.WriteLine("error!");
                    break;
                    
            }
           
            Console.ReadLine();
            
        }
    }
}
