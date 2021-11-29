using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ClassEncapsulation
{
    class Kisi
    {
        public int Id { get; set; }
        private string _adi;
        public string Adi
        {
            get 
            { 
                string ilkHarf = _adi.Substring(0, 1).ToUpper();
                string geriKAlan = _adi.Substring(1).ToLower();
                _adi = ilkHarf + geriKAlan;
                return _adi;
            }
            set
            {
                _adi = value;
            }
        }

        private string _soyadi;
        public string Soyadi
        {
            get
            {
                return _soyadi.ToUpper();
            }
            set
            {
                _soyadi = value;
            }
        }

        private int _yas;
        public int Yas
        {
            get
            {
                return _yas;
            }
            //Kapsülleme aracılığıyla kontrol edelim.Kurala uymayan bir durum var ise ;
            //throw ile hata fırlatabiliriz.
            set
            {
                _yas = value;
                if (_yas <0)
                {
                    _yas = 0;
                    throw new FormatException("Yaş özelliği sıfırdan küçük olamaz.");
                }
            }
        }
        public DateTime DogumTarihi { get; set; }

    }
}
