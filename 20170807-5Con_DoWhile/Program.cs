using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170807_5Con_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sonsuz sayıyı toplayan uygulamayı yazınız. eğer sayı dışında birşey veya 0 girilirse toplamı gösteriniz.

            int girilen=0, toplam = 0;
            do
            {
                Console.Write("Bir sayi giriniz : ");
                if (int.TryParse(Console.ReadLine(),out girilen) == true) // console tarafından okunan sayı "girilen"den farklı birşey mi ?
                {
                    toplam += girilen; // madem evet. o zaman topla.
                }
                else
                {
                    break; // çıkgit.
                }
                 
            } while (girilen != 0);

            Console.Write("Girilen sayıların toplamı = {0}", toplam);
            Console.Read();

        }
    }
}
