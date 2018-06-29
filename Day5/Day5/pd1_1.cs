using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class pd1_1
    {
        public void Publiska()
        {
            Console.WriteLine("Ludzu izvelaties funkciju! 1: Vards 2: SimboluVirknes 3: Konvertacija!");
            string izvele = Console.ReadLine();

            switch (izvele)
            {
                case "1":
                    Console.WriteLine("Ievade ir 1 ");
                    Vards();
                    break;
                case "2":
                    Console.WriteLine("Ievade ir 2 ");
                    SimboluVirknes();

                    break;
                case "3":
                    Console.WriteLine("Ievade ir 3 ");
                    int rezultats = Konvertacija();
                    Console.WriteLine("Jusu ievaditais skaitlis ir : " + rezultats);
                    break;



            }

            //        Vards();
            //SimboluVirknes();
            
            //int rezultats = Konvertacija();
            //Console.WriteLine("Jusu ievaditais skaitlis ir : " + rezultats);


        }

        

        private void Vards()
        {
            Console.WriteLine("Ludzu ievadiet savu lietotajvardu!");
            string Lietotajs1 = Console.ReadLine();

            Console.WriteLine("Ludzu ievadiet savu uzvardu!");
            string Uzvards = Console.ReadLine();

            Console.WriteLine("Jus lietotajvards: " + Lietotajs1 + ". Jusu uzvards: " + Uzvards);
            
        }

        private void SimboluVirknes()
        {
            Console.WriteLine("Ludzu ievadiet jebkadu virkni!");
            string Virkne1 = Console.ReadLine();

            Console.WriteLine("Ludzu atkal ievadiet jebkadu virkni!");
            string Virkne2 = Console.ReadLine();

            Console.WriteLine("Jus gala virkne: " + Virkne1 + Virkne2);

        }

        private int Konvertacija()
        {
            Console.WriteLine("Ludzu ievadiet skaitli!");
            string Skaitlis = Console.ReadLine();
            int Skaitlis2 = Convert.ToInt16(Skaitlis);
            return Skaitlis2;
        }


    }
}
