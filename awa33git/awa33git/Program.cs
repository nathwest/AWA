using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awa33git
{
    class Program
    {
        static void Main(string[] args)
        {
            Money();
            int insattning;
            int uttag;
            int saldo = 0;
            bool meny = true;

            while (meny)
            {
                Console.WriteLine("Bank of Martin Westfeldt");
                Console.WriteLine();
                Console.WriteLine("[I]nsättning");
                Console.WriteLine("[U]ttag");
                Console.WriteLine("[S]aldo");
                Console.WriteLine("[A]vsluta");

                char val = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();


                switch (val)
                {
                    

                    case 'I':
                        Console.WriteLine("Insättning");
                        Console.WriteLine("Hur mycket vill du sätta in? ");
                        insattning = Convert.ToInt32(Console.ReadLine());

                        if (insattning > 50)
                        {
                            Console.WriteLine("Insättning: " + insattning);
                            saldo = saldo + insattning;
                        }
                        else if (insattning == 0)
                        {
                            Console.WriteLine("ingen insättning");

                        }
                        else
                            Console.WriteLine("återgå till start");
                        break;


                    case 'U':
                        Console.WriteLine("Uttag");
                        Console.WriteLine("Hur mycket vill du ta ut? ");
                        uttag = Convert.ToInt32(Console.ReadLine());

                        if (uttag > 0 && uttag <= saldo)
                        {
                            Console.WriteLine("Uttag: " + uttag);
                            saldo = saldo - uttag;
                        }
                        else if (uttag > 0 && uttag > saldo)
                        {
                            Console.WriteLine("Insufficient funds, medges ej");

                        }
                        else if (uttag == 0)
                        {
                            Console.WriteLine("Inget uttag.");

                        }
                        else
                            Console.WriteLine("Negativt värde, inget uttag");
                        break;

                    case 'S':
                        Console.WriteLine("Saldo: " + saldo);
                        break;


                    case 'A':
                        Console.WriteLine("It will all be over soon");
                        meny = false;
                        break;


                    default:
                        Console.WriteLine("Felaktig inmatning");
                        break;
                }
            }

            
        }
        #region -
        private static void secretstuff()
        {
            //( . Y . )
        }

        private static void Money()
        {
            while (true)
            {
                Console.WriteLine("$$$\n");
            }
        }
        #endregion
    }
}
