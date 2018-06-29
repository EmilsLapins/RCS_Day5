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
            Matematika();
            Gpa();
            
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

    }
}
