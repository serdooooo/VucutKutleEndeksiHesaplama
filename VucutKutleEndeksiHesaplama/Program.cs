using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucutKutleEndeksiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double boy;
            double kg;
            double indeks=0;
            string devam;
            string cinsiyet;
            double idealKg = 0;

            devamEt: Console.Write("Lütfen cinsiyetinizi giriniz: ");
            cinsiyet = Console.ReadLine();

            Console.Write("Lütfen boyunuzu giriniz: ");
            
            boy = Convert.ToDouble(Console.ReadLine());
            if (boy <= 3.0)
            {
                boy *= 100;
            }

            Console.Write("Lütfen kilonuzu giriniz: ");
            kg = Convert.ToDouble(Console.ReadLine());

            if (boy <= 0 || kg<=0)
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Geçerli bir değer girmeniz için yönlendiriliyorsunuz...");
                System.Threading.Thread.Sleep(2000);
                goto devamEt;
            }

            indeks = kg*10000 / (boy * boy);
            indeks = Math.Round(indeks, 2);

            Console.WriteLine("Vücut kitle indeksiniz hesaplanıyor. Lütfen bekleyiniz...");
            System.Threading.Thread.Sleep(3000);


            if (indeks < 18.5)
            {
                Console.BackgroundColor=ConsoleColor.Red;
                Console.WriteLine("Vücut kitle indeksiniz: {0} dir. Düşük kilolusunuz, en yakın sağlık kuruluşundan destek alınız. -Alo 182",indeks);
                Console.Beep(2000, 2000);
            }
            else if (indeks >= 18.5 && indeks < 25)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Vücut kitle indeksiniz: {0} dir. Normal kilodasınız.", indeks);
            }
            else if (indeks >= 25 && indeks < 30)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Vücut kitle indeksiniz: {0} dir. Fazla kilolusunuz", indeks);
            }
            else if (indeks >= 30 && indeks < 40)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Vücut kitle indeksiniz: {0} dir. Obezsiniz, en yakın sağlık kuruluşundan destek alınız. -Alo 182", indeks);
                Console.Beep(2000, 2000);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Vücut kitle indeksiniz: {0} dir. Aşırı obezsiniz, en yakın sağlık kuruluşundan destek alınız. -Alo 182", indeks);
                Console.Beep(2000, 2000);
            }
            

            Console.ResetColor();
            //https ://aysetugbasengel.com/ideal-kilo-hesaplama/

            if (cinsiyet == "erkek")
            {
                 idealKg = 50 + 2.3 * ((boy / 2.54) - 60);
            }
            else
            { 
                 idealKg = 45.5 + 2.3 * ((boy / 2.54) - 60);
            }
            idealKg = Math.Round(idealKg, 2);
            Console.WriteLine("İdeal kilonuz hesaplanıyor...");
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("İdeal kilonuz: {0}", idealKg);

            if (kg > idealKg)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("İdeal kilonuzdan fazlasınız. Sağlığınız açısından {0} kilo vermelisiniz. ",kg-idealKg);
            }
            else if (kg < idealKg)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("İdeal kilonuzdan eksiksiniz. Sağlığınız açısından {0} kilo almalısınız. ",idealKg-kg);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("İdeal kilodasınız.");
            }
            Console.ResetColor()
                ;

            Console.WriteLine("\nYeni vücut kitle indeksi hesaplamak için lütfen 1'e basınız. Çıkmak için herhangi bir tuşa basınız.");
            devam = Console.ReadLine();
            if (devam == "1")
            {
                goto devamEt;
            }
            Console.ReadKey();

        }
    }
}