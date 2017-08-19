using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicApp
{

    class Program
    {

        static void Main(string[] args)
        {
            #region - Dictionary ve Öncesi -
            #region - Veri Tipleri -
            //string adi = "fatih GÜRDAL";

            //Console.WriteLine(adi);

            //int Sicaklik = -50;

            //Console.WriteLine(Sicaklik);

            //long Uzaklik = 2147483648;

            //Console.WriteLine(Uzaklik);


            //double Yuzde = 0.25;
            //Console.WriteLine(Yuzde);

            //DateTime DogumGunu = new DateTime(1992, 8, 30);
            //Console.WriteLine(DogumGunu);

            //bool Varmi = true;
            //Console.WriteLine(Varmi);

            //char Karakter = 'F';
            //Console.WriteLine(Karakter);

            //Console.ReadKey();
            #endregion

            #region - Convert -
            //int yas = 25;
            //string yasStr = Convert.ToString(yas);

            //Console.WriteLine("String'e çevrilmş yaş" + yasStr);


            //string Tarih = "01.05.2017";
            //DateTime tarihDt = Convert.ToDateTime(Tarih);
            //Console.WriteLine("DateTime'a çevirilmiş String Tarih" + tarihDt);

            //DateTime bugun = DateTime.Now;
            //string bugunStr = Convert.ToString(bugun);
            //Console.WriteLine("String'e çevirilmiş DateTime değişkeni" + bugunStr);

            //string yuzde = "10.5";
            //double yuzdeDb = Convert.ToDouble(yuzde);
            //Console.WriteLine("Double'a çevirilmiş string değişken: " + yuzdeDb);

            //bool Varmi = true;
            //string VarmiStr = Convert.ToString(Varmi);
            //Console.WriteLine("String'e çevirilmiş bool değişken: " + VarmiStr); 
            #endregion

            #region - Cast -
            //char harf = '5';
            //int harfSayi = (int)harf;
            //Console.WriteLine(harfSayi);

            ////string harfStr = (string)harf;
            //double fiyat = 10.7;
            //int fiyatInt = (int)fiyat;
            //Console.WriteLine(fiyatInt); 
            #endregion

            #region - Enum -
            //Beden bedenim = Beden.M;
            //int bedenInt = (int)bedenim;
            //Console.WriteLine("Enum gösterim değeri"+bedenim);
            //Console.WriteLine("Enum int değeri"+ bedenInt); 
            #endregion

            #region - IF -
            //Console.Write("Kullanıcı adını giriniz: ");
            //string userName = Console.ReadLine();

            //Console.Write("Şifre giriniz: ");
            //string pass = Console.ReadLine();

            //if (userName == "fatihgurdal" && pass=="12345")
            //{
            //    Console.WriteLine("Giriş Başarılıdır.");
            //}
            //else if (userName == "fatihgurdal")
            //{
            //    Console.WriteLine("Sadece kullanıcı adı doğrudur.");
            //} else
            //{
            //    Console.WriteLine("Hiç bir bilgi doğru değildir.");
            //} 
            #endregion

            #region - Case -
            //Console.Write("Yetki Kodunuzu giriniz: ");
            //string bilgi = Console.ReadLine();

            //switch (bilgi)
            //{
            //    case "01":
            //        Console.WriteLine("Siz Kullanıcısınız");
            //        break;
            //    case "02":
            //        Console.WriteLine("Siz Müşterisiniz");
            //        break;
            //    case "03":
            //        Console.WriteLine("Siz Editör");
            //        break;
            //    case "04":
            //        Console.WriteLine("Yöneticisiniz");
            //        break;
            //    default:
            //        Console.WriteLine("Grubunuz Yok.");
            //        break;
            //} 
            #endregion

            #region - Aritmatik Operatorler -
            //int sayi = 10;

            ////Console.WriteLine("sayi / 2 => " + sayi / 2);
            ////Console.WriteLine("sayi * 2 => " + sayi * 2);
            ////Console.WriteLine("sayi - 2 => " + (sayi - 2));
            ////Console.WriteLine("sayi + 2 => " + (sayi + 2));

            //int deger1 = 5;
            //int deger2 = 5;

            ////deger1 = deger1 + 2;
            ////deger2 += 2;
            ////Console.WriteLine("deger1 = deger1 + 2; => " + deger1);
            ////Console.WriteLine("deger2 += 2;" + deger2);

            //int sira = 10;
            //sira++;
            //Console.WriteLine(sira);
            //sira--;
            //Console.WriteLine(sira);

            #endregion

            #region - İlişkisel Operatorler -
            //// == eşit midiR?
            //// != eşit değil midir?
            //// < ve <= küçük müdür ve küçük eşit midir?
            //// > ve >= büyük müdür ve büyük eşit midir

            //Console.Write("Doğum Tarihinizi Giriniz: ");
            //string tarih = Console.ReadLine();
            //DateTime tarihDt = Convert.ToDateTime(tarih);

            //if (tarihDt >= DateTime.Today)
            //{
            //    Console.WriteLine("Girdiğiniz Tarih Bugünden Büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Tarih Kaydı Başarılıdır.");
            //}

            //if (tarihDt != DateTime.Today)
            //{
            //    Console.WriteLine("Girdiğiniz Tarih bugüne eşit değildir.");
            //} 
            #endregion

            #region - Mantıksal Operatorler -
            //// && ve
            //// || veya
            //// ! tersine çevirme
            //// ^ 

            //Console.Write("1. Değer: ");
            //string deger1 = Console.ReadLine();

            //Console.Write("2. Değer: ");
            //string deger2 = Console.ReadLine();

            //if ((deger1 == deger2) && deger1 == "fatih")
            //{
            //    Console.WriteLine("değer1 ve değer2 birbirine eşittir ve değer1 fatih'dir");
            //}

            //if ((deger1 == deger2) || deger1 == "fatih")
            //{
            //    Console.WriteLine("değer1 ve değer2 birbirine eşittir veya değer1 fatih'dir");
            //}

            //if (!(deger1 == deger2))
            //{
            //    Console.WriteLine("Değer1 ve değer2 birbirine eşit değildir");
            //}

            //if ((deger1 == deger2) ^ deger1 == "fatih")
            //{
            //    Console.WriteLine("şart1 ve şart2 birbirinden farklıdır");
            //} 
            #endregion

            #region - For Döngüsü -
            //// 10! = 1*2*3...*10 =
            //Console.Write("Hangi sayının faktöriyelini alsın ?");
            //string sayi = Console.ReadLine();
            //int sayiInt = Convert.ToInt32(sayi);
            //int sonuc = 1;
            //for(int i = 1; i <= sayiInt; i++)
            //{
            //    Console.Write( "*" + i);
            //    sonuc *= i;
            //}

            //Console.WriteLine("Sonucumuz: " + sonuc); 
            #endregion

            #region - While ve Do While -
            //string pass;
            //do
            //{
            //    Console.Write("Şifreyi Giriniz: ");
            //    pass = Console.ReadLine();
            //} while (pass!="12345");


            //Console.WriteLine("Giriş Başarılıdır."); 
            #endregion

            #region - Diziler -
            //string[] listem = new string[5];
            //listem[0] = "fatih";
            //listem[1] = "gürdal";
            //listem[2] = "kadir";
            //listem[3] = "murat";
            //listem[4] = "başeren";
            ////Array.Resize()
            //for (int i = 0; i < 5; i++)
            //{
            //    //Console.WriteLine(listem[i]);
            //}
            ////Console.WriteLine("Dizinin listelemesi bitmiştir..."); 
            #endregion

            #region - Listler -
            //List<string> isimler = new List<string>();
            //Console.WriteLine("Listenin Count sayısı:" + isimler.Count);
            //Console.WriteLine("Listenin Capacity sayısı:" + isimler.Capacity);
            //isimler.Add("fatih");
            //isimler.Add("gürdal");
            //isimler.Add("kadir");
            //isimler.Add("murat");
            //isimler.Add("başeren");
            //isimler.Add("değer1");
            //isimler.Add("değer2");
            //isimler.Add("değer3");
            //isimler.Add("değer4");
            //Console.WriteLine("Hepsi Eklendi Listenin Count sayısı:" + isimler.Count);
            //Console.WriteLine("Hepsi Eklendi Listenin Capacity sayısı:" + isimler.Capacity);
            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            //Console.WriteLine("Listenin listelemesi bitmiştir..."); 
            #endregion

            #region - Foreach -
            //List<string> isimler = new List<string>();
            //isimler.Add("fatih");
            //isimler.Add("gürdal");
            //isimler.Add("kadir");
            //isimler.Add("murat");
            //isimler.Add("başeren");
            //isimler.Add("değer1");
            //isimler.Add("değer2");
            //isimler.Add("değer3");
            //isimler.Add("değer4");
            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region - string İşlemleri 1 -
            //string cizgi = new string('-', 50);
            //cizgi += " fatih";
            //Console.WriteLine(cizgi);

            //Console.WriteLine("cizgi değişkeninde toplam karakter sayısı: " + cizgi.Length);

            //cizgi = cizgi.Remove(0, 50);
            //Console.WriteLine("Remove ile silindikten sonra " + cizgi);// fatih

            //Console.WriteLine("3.karakteden toplam 2 tane  al: " + cizgi.Substring(3, 2));

            //cizgi = new string('-', 50);
            //cizgi += " fAT?h";
            //cizgi = cizgi.Replace('-', '?');
            //Console.WriteLine("- yerine ? yaptım" + cizgi);

            ////cizgi = cizgi.Trim('?');
            ////Console.WriteLine("trim ile ? silindi: "+cizgi);

            //cizgi = cizgi.TrimEnd('?');
            //Console.WriteLine("sondan trim ile ? silindi: " + cizgi);

            //if (cizgi.StartsWith("?"))
            //{
            //    Console.WriteLine("Değişken ? ile başladı");
            //}
            //if (cizgi.EndsWith("?"))
            //{
            //    Console.WriteLine("Değişken ? ile bitti");
            //}

            //if (cizgi.Contains("t?i"))
            //{
            //    Console.WriteLine("Değişkenin içersinde 't?i' vardır.");
            //}
            //else
            //{
            //    Console.WriteLine("Aranan metin bulunamadı.");
            //}
            //Console.WriteLine("Normal" + cizgi);
            //Console.WriteLine("Hepsi Büyük" + cizgi.ToUpper());
            //Console.WriteLine("Hepsi Küçük" + cizgi.ToLower()); 
            #endregion

            #region - String İşlemleri 2 -
            //string isimler = "fatih,gürdal,kadir,murat,başeren";
            //string[] isimlerArray = isimler.Split(',');

            //foreach (string item in isimlerArray)
            //{
            //    Console.WriteLine(item);
            //}

            //int sira = isimler.IndexOf("gürdal");
            //Console.WriteLine("gürdal keliemesinin başladığı sıra" + sira);

            //isimler = isimler.Insert(sira, "41");
            //Console.WriteLine("Araya ekledikten sonraki yeni metin: " + isimler); 
            #endregion

            #region - Dictionary -
            //Dictionary<int, string> iller = new Dictionary<int, string>();
            //iller.Add(1, "Adana");
            //iller.Add(2, "Adıyaman");
            //iller.Add(3, "Afyon");
            //iller.Add(23, "İstanbul");
            //iller.Add(6, "Ankara");
            //iller.Add(52, "Ordu");
            //iller.Add(61, "Trabzon");
            //iller.Add(41, "Kocaeli");
            //foreach (KeyValuePair<int, string> item in iller)
            //{
            //    Console.WriteLine(item.Key + " - " + item.Value);
            //}

            //Console.WriteLine("Key ile ekrana yazdırılan şehir: " + iller[60]); 
            #endregion

            #endregion
            List<Insan> insanlar = new List<Insan>();
            for (int i = 1; i < 5; i++)
            {
                Console.Write(i + ". Kişinin Adı: ");
                string _ad = Console.ReadLine();               

                Insan insan = new Insan(_ad);


                Console.Write(i + ". Kişinin Doğum Tarihi: ");
                DateTime _tarih = Convert.ToDateTime(Console.ReadLine());
                //Console.Write(i + ". Kişinin Boy: ");
                //int _boy = Convert.ToInt32(Console.ReadLine());
                //Console.Write(i + ". Kişinin Kilosu: ");
                //int _kilo = Convert.ToInt32(Console.ReadLine());

                insan.DogumTarihi = _tarih;
                //insan.Boy = _boy;
                //insan.Kilo = _kilo;

                insanlar.Add(insan);
            }
            Console.WriteLine("Veri okuma işlemi tamamlanmıştır.");
            Console.WriteLine(new String('-', 50));
            foreach (Insan item in insanlar)
            {
                string temp = string.Format("Adı: {0} Yas:{1}", item.Ad, item.YasiniGetir());
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }

    #region - Enum -
    //enum Beden
    //{
    //    XS = 10,
    //    S = 20,
    //    M = 30,
    //    L = 40,
    //    XL = 50,
    //    XXL = 60
    //} 
    #endregion
}
