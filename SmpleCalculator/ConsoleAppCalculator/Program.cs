using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/*Kreirati novi projekt tipa ConsoleApp(.NET Framework) . Napisati program koji će od korisnika
tražiti unos 2 broja.Nakon što korisnik unese brojeve na ekran se ispisuje izbornik sa sljedećim
opcijama:
1. Zbrajanje
2. Množenje
3. Oduzimanje
4. Dijeljenje
Nakon odabira na ekran se ispisuje jednakost(npr. 5 - 3 = 2).*/

namespace ConsoleAppCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite dva broja: ");
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Odaberite matematičku operaciju: ");
            Console.WriteLine("1. Zbrajanje");
            Console.WriteLine("2. Množenje");
            Console.WriteLine("3. Oduzimanje");
            Console.WriteLine("4. Dijeljenje");
            float rezultat;
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    rezultat = a + b;
                    Console.WriteLine(a + "+" + b + "=" + rezultat);
                    break;
                case 2:
                    rezultat = a * b;
                    Console.WriteLine(a + "*" + b + "=" + rezultat);
                    break;
                case 3:
                    rezultat = a - b;
                    Console.WriteLine(a + "-" + b + "=" + rezultat);
                    break;
                case 4:
                    rezultat = a / b;
                    Console.WriteLine(a + "/" + b + "=" + rezultat);
                    break;
                default:
                    Console.WriteLine("Odabrali ste operaciju koja ne postoji.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
