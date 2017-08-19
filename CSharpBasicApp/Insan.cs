using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicApp
{
    public class Insan
    {
        //Public Herkese Açık
        //Private Sadece sınıf içersinde
        //Internal SAdece Proje İçersinde
        public DateTime DogumTarihi { get; set; }
        public string Ad { get; }
        public int Boy { get; set; }
        public int Kilo { get; set; }
        public Renk SacRengi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public Insan(string _ad)
        {
            Ad = _ad;
        }
        public int YasiniGetir()
        {
            int yas = DateTime.Now.Year - DogumTarihi.Year;

            return yas;
        }
    }
    public enum Renk
    {
        Sari,
        Siyah,
        Kahverengi
    }
    public enum Cinsiyet
    {
        Belirtilmeli,
        Kadin,
        Erkek
    }
}
