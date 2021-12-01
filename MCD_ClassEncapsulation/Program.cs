using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ClassEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kisi ft = new Kisi();

                ft.Adi = "emre";
                ft.DenemeTelNo = "0123456789eefdfe98745+++++";
                ft.DogumTarihi = new DateTime(1993, 10, 22);
                ft.Soyadi = "gemici";
                ft.Yas = 28;

                 Console.WriteLine(ft.Adi );
                 Console.WriteLine(ft.DenemeTelNo  );
                 Console.WriteLine(ft.DogumTarihi  );
                 Console.WriteLine(ft.Soyadi  );
                 Console.WriteLine(ft.Yas  );
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA oluştu.");
                Console.WriteLine(ex.Message );
                
            }

            Console.ReadKey();
        }
    }
}
