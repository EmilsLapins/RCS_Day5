using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class pd1_2
    {
        public void Publiska()
        {


            Console.WriteLine("Ludzu izvelaties funkciju! 1: Matematika 2: GPA 3: KapinamFunkija 4: Lielakais skaitlis!");
            string izvele = Console.ReadLine();

            switch (izvele)
            {
                case "1":
                    Console.WriteLine("Ievade ir 1 ");
                    Matematika();
                    break;
                case "2":
                    Console.WriteLine("Ievade ir 2 ");
                    Gpa();

                    break;
                case "3":
                    Console.WriteLine("Ievade ir 3 ");
                    int Rezultats = KapinamFunkija();
                    break;
                case "4":
                    Console.WriteLine("Ievade ir 4 ");
                    int Lielakais = LielakaisSk();
                    break;
            }

            
            //Matematika();
            //Gpa();

            //int Rezultats = KapinamFunkija();
            //int Lielakais = LielakaisSk();
            
        }

        private void Matematika()
        {
            
            Console.WriteLine("Ludzu ievadiet 1. skaitli!");
            string pirmais1  = Console.ReadLine();
            double pirmais2 = Convert.ToDouble(pirmais1);


            Console.WriteLine("Ludzu ievadiet 2. skaitli!");
            string otrais1 = Console.ReadLine();
            double otrais2 = Convert.ToDouble(otrais1);

            Console.WriteLine("Ko Jus velaties darit ar siem skaitliem: 1: Saskaitis 2: Atnemt 3: Reizinat 4: Dalit");
            string izvele = Console.ReadLine();

            switch (izvele)
            {
                case "1":
                    Console.WriteLine("Izvele ir saskaitisana!");
                    Console.WriteLine(pirmais2 + otrais2);
                    
                    break;
                case "2":
                    Console.WriteLine("Izvele ir Atnemsana!");
                    Console.WriteLine(pirmais2 - otrais2);

                    break;
                case "3":
                    Console.WriteLine("Izvele ir Reizinasana!");
                    Console.WriteLine(pirmais2 * otrais2);
                    break;
                case "4":
                    Console.WriteLine("Izvele ir Dalisana!");
                    Console.WriteLine(pirmais2 / otrais2);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

                    
            }
        
        }
        private void Gpa()
        {
            Console.WriteLine("Ludzu ievadiet savu GPA skaitli! (var izmantot komatu)");
            string GpaGrade = Console.ReadLine();
            double Gpa = Convert.ToDouble(GpaGrade);

            switch (Gpa)
            {
                case 0:
                    Console.WriteLine("Jusu GPA ir F");
                    break;
                case 1:
                    Console.WriteLine("Jusu GPA ir D");
                    break;
                case 2:
                    Console.WriteLine("Jusu GPA ir C");
                    break;
                case 2.5:
                    Console.WriteLine("Jusu GPA ir C+");
                    break;
                case 3:
                    Console.WriteLine("Jusu GPA ir B");
                    break;
                case 3.5:
                    Console.WriteLine("Jusu GPA ir B+");
                    break;
                case 4:
                    Console.WriteLine("Jusu GPA ir A");
                    break;
                case 4.5:
                    Console.WriteLine("Jusu GPA ir A+");
                    break;
                
                default:
                    Console.WriteLine("Kura valsti tu ieguvi savu gradu?");
                    break;
                    

            }
            
        }

        private int KapinamFunkija()
        {
            Console.WriteLine("Ievadiet kapinamo skaitli: ");
            string Kapinam = Console.ReadLine();
            int Kapinam2 = Convert.ToInt16(Kapinam);

            Console.WriteLine("1: Kvadrata 2: Kuba");
            string izvele = Console.ReadLine();

            int Kapinam3 = 0;

            switch (izvele)
            {
                case "1":
                    Kapinam3 = Kapinam2 * Kapinam2;
                    Console.WriteLine(izvele + " Kvadrata ir " + Kapinam3);
                    return Kapinam3;
                    
                case "2":
                    
                    Kapinam3= Kapinam2 * Kapinam2 * Kapinam2;
                    Console.WriteLine(izvele + " Kuba ir " + Kapinam3);
                    return Kapinam3;
                   
                default:
                    Console.WriteLine("error");
                    return Kapinam3;
                     
            }
           
        }
        private int LielakaisSk()
        {
            Console.WriteLine("Ludzu ievadiet 1. skaitli!");
            string Skaitlis1 = Console.ReadLine();
            int SkaitlisInt = Convert.ToInt16(Skaitlis1);

            Console.WriteLine("Ludzu ievadiet 2. skaitli!");
            string Skaitlis2 = Console.ReadLine();
            int SkaitlisInt2 = Convert.ToInt16(Skaitlis2);

            if (SkaitlisInt > SkaitlisInt2)
            {
                Console.WriteLine(" Skaitlis 1 ir lielaks! ");
                return SkaitlisInt;
            }
            else {
                if (SkaitlisInt == SkaitlisInt2)
                {
                    Console.WriteLine("Vienadi! ");
                    return SkaitlisInt;
                }
                else
                {
                    if (SkaitlisInt < SkaitlisInt2)
                    {

                        Console.WriteLine("Skaitlis 2 ir lielaks ");
                        return SkaitlisInt2;
                    }
                    
                }
                Console.WriteLine("Error! ");
                return SkaitlisInt2;
            }

                
                

            


        }

    }
}
