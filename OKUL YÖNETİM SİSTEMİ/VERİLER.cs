using OKUL_YÖNETİM_SİSTEMİ.nesne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using static OKUL_YÖNETİM_SİSTEMİ.nesne.dersler;

namespace OKUL_YÖNETİM_SİSTEMİ
{


    internal class VERİLER
    {
        internal static ArrayList ogrenciler = new ArrayList() ;
        internal static ArrayList ogretmenler = new ArrayList();
        internal static ArrayList sınıflar = new ArrayList();
        internal static ArrayList dersler = new ArrayList();


        internal static void EKLE()
        {
            
            while (true)
            {
                Console.WriteLine("öğrenciler için-1\nöğretmenler için-2\nsınıflar için-3\ndersler için-4\nçıkmak için-0\nhangi birimde ekleme işlemi yapmak istiyorsunuz");
                int cevap = Convert.ToInt32(Console.ReadLine());

                if (cevap == 1)
                {

                    int i = 0;
                    while (true)
                    {
                        Console.WriteLine("öğrenci eklemeye devam etmek için-1\nçıkmak için-2\nhangi işlemi yapmak istiyorsunuz");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {
                            Console.WriteLine("öğrenci adı girin");
                            string ad = Console.ReadLine();
                            Console.WriteLine("öğrenci soyadı girin");
                            string soyad = Console.ReadLine();
                            Console.WriteLine("öğrenci yaşı girin");
                            int yas = Convert.ToInt32(Console.ReadLine());
                            ogrenciler.Add(new ogrenciler() { ogrenciadi = ad, ogrencisoyadi = soyad, ogrenciyasi = yas });

                        }
                        else if (secim == 2)
                        {
                            break;
                        }
                    }






                }
                else if (cevap == 2)
                {
                    int i = 0;
                    while (true)
                    {
                        Console.WriteLine("öğretmen eklemeye devam etmek için-1\nçıkmak için-2\nhangi işlemi yapmak istiyorsunuz");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {
                            Console.WriteLine("öğretmen adı girin");
                            string ad = Console.ReadLine();
                            Console.WriteLine("öğretmen soyadı girin");
                            string soyad = Console.ReadLine();
                            Console.WriteLine("öğretmen yaşı girin");
                            int yas = Convert.ToInt32(Console.ReadLine());
                            ogretmenler.Add(new ogretmenler() { ogretmenadi = ad, ogretmensoyadi = soyad, ogretmenyasi = yas });

                        }
                        else if (secim == 2)
                        {
                            break;
                        }
                    }
                }
                else if (cevap == 3)
                {
                    Console.WriteLine("sınıf ekle");
                    sınıflar.Add(new sınıflar() { sınıf = Convert.ToInt32(Console.ReadLine()) });
                }
                else if (cevap == 4)
                {
                    int m = 0;
                    Console.WriteLine("ders eklemeye devam etmek için-1\nçıkmak için-2\nhangi işlemi yapmak istiyorsunuz");
                    while (true)
                    {
                        
                        int i = 0;
                        while (i < sınıflar.Count)
                        {
                            sınıflar a = (sınıflar)sınıflar[i];
                            Console.WriteLine($"indexno:{i},sınıf{a.sınıf}");
                            i++;
                        }
                        Console.WriteLine("hazırlayacağınız dersin sınıfınının indexno:");
                        int sınıf = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("ders ekle");
                        string ders = Console.ReadLine();
                        i = 0;
                        while (i < ogretmenler.Count)
                        {
                            ogretmenler a = (ogretmenler)ogretmenler[i];
                            Console.WriteLine($"indexno:{i},öğretmen adı:{a.ogretmenadi},öğretmen soyadı:{a.ogretmensoyadi},öğretmen yaşı:{a.ogretmenyasi}");
                            i++;
                        }

                        Console.WriteLine("bu derse eklemek istediğiniz hocanın indexno:");
                        int dersHoacası = Convert.ToInt32(Console.ReadLine());



                        i = 0;
                        while (i < ogrenciler.Count)
                        {
                            ogrenciler a = (ogrenciler)ogrenciler[i];
                            Console.WriteLine($"indexno:{i},öğrenci adı:{a.ogrenciadi},öğrenci soyadı:{a.ogrencisoyadi},öğrenci yaşı:{a.ogrenciyasi},öğrenci notu:{a.ogrencinotu}");
                            i++;
                        }
                        i = 0;
                        
                        while (true)
                        {
                            string [] ogrenciler1 = { };
                            Console.WriteLine("bu derse  öğrenci eklemeye devam etmek için-1\nçıkmak için-2");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 1)
                            {
                                Array.Resize(ref ogrenciler1, ogrenciler1.Length + 1);
                                Console.WriteLine("bu derse   eklemek istediğiniz öğrencilerin indexno:");
                                int ogrenci = Convert.ToInt32(Console.ReadLine());
                                ogrenciler c = (ogrenciler)ogrenciler[i];
                                ogrenciler1[i] = c.ogrenciadi + c.ogrencisoyadi;
                                i++;
                                



                            }
                            else if (secim == 2)
                            {
                                break;
                            }
                            



                    }
                        ogretmenler a = (ogretmenler)ogretmenler[m];
                        ogrenciler b = (ogrenciler)ogrenciler[m];
                        dersler.Add(new dersler() { ders = ders, dersinHocası = a.ogretmenadi + a.ogretmensoyadi, dersinOgrencileri = ogrenciler1 });





                    }
                else if (cevap == 0)
                {
                    break;
                }
            }
           

        }
        internal static void SIL()
        {
            Console.WriteLine("öğrenciler için-1\nöğretmenler için-2\nsınıflar için-3\ndersler için-4\nhangi birimde silme işlemi yapmak istiyorsunuz");
            int cevap = Convert.ToInt32(Console.ReadLine());
            if (cevap == 1)
            {
                for (int i = 0; i < ogrenciler.Capacity; i++)
                {
                    Console.WriteLine($"indexno:{i}:öğrenci{ogrenciler[i]}");
                }
                Console.WriteLine("silmek istediğiniz öğrenci indexno:");
                ogrenciler.RemoveAt(Convert.ToInt32(Console.ReadLine()));
            }
            else if (cevap == 2)
            {
                for (int i = 0; i < ogretmenler.Capacity; i++)
                {
                    Console.WriteLine($"indexno:{i}:öğretmen{ogretmenler[i]}");
                }
                Console.WriteLine("silmek istediğiniz ogretmen indexno:");
                ogretmenler.RemoveAt(Convert.ToInt32(Console.ReadLine()));
            }
            else if (cevap == 3)
            {
                for (int i = 0; i < sınıflar.Capacity; i++)
                {
                    Console.WriteLine($"indexno:{i}:sınıf{sınıflar[i]}");
                }
                Console.WriteLine("silmek istediğiniz sınıf indexno:");
                sınıflar.RemoveAt(Convert.ToInt32(Console.ReadLine()));
            }
            else if (cevap == 4)
            {
                for (int i = 0; i < dersler.Capacity; i++)
                {
                    Console.WriteLine($"indexno:{i}:ders{dersler[i]}");
                }
                Console.WriteLine("silmek istediğiniz ders indexno:");
                dersler.RemoveAt(Convert.ToInt32(Console.ReadLine()));
            }
        }
        internal static void GUNCELLEME()
        {
            Console.WriteLine("öğrenciler için-1\nöğretmenler için-2\nsınıflar için-3\ndersler için-4\nhangi birimde güncelleme işlemi yapmak istiyorsunuz");
            int cevap = Convert.ToInt32(Console.ReadLine());
            if (cevap == 1)
            {

                for (int i = 0; i < ogrenciler.Capacity; i++)
                {
                    Console.WriteLine($"indexno:{i}:öğrenci{ogrenciler[i]}");
                }
                Console.WriteLine("güncellemek istediğiniz öğrenci indexno:");
                int indexno = Convert.ToInt32(Console.ReadLine());
                ogrenciler.RemoveAt(indexno);
                Console.Write("güncellemek istediğiniz adı girin");
                ogrenciler.Insert(indexno, new ogrenciler { ogrenciadi = Console.ReadLine() });
                Console.Write("güncellemek istediğiniz soyadı girin");
                ogrenciler.Insert(indexno, new ogrenciler { ogrencisoyadi = Console.ReadLine() });
                Console.Write("güncellemek istediğiniz yaşı girin");
                ogrenciler.Insert(indexno, new ogrenciler { ogrenciyasi = Convert.ToInt32(Console.ReadLine() )});
            }
            else if (cevap == 2)
            {

                for (int i = 0; i < ogretmenler.Capacity; i++)
                {
                    Console.WriteLine($"indexno:{i}:öğretmen{ogretmenler[i]}");
                }
                Console.WriteLine("güncellemek istediğiniz öğretmen indexno:");
                int indexno = Convert.ToInt32(Console.ReadLine());
                ogretmenler.RemoveAt(indexno);
                Console.Write("güncellemek istediğiniz adı girin");
                ogretmenler.Insert(indexno, new ogretmenler { ogretmenadi = Console.ReadLine() });
                Console.Write("güncellemek istediğiniz soyadı girin");
                ogretmenler.Insert(indexno, new ogretmenler { ogretmensoyadi = Console.ReadLine() });
                Console.Write("güncellemek istediğiniz yaşı girin");
                ogretmenler.Insert(indexno, new ogretmenler { ogretmenyasi = Convert.ToInt32(Console.ReadLine()) });
            }
            else if (cevap == 3)
            {

                for (int i = 0; i < sınıflar.Capacity; i++)
                {
                    Console.WriteLine($"indexno:{i}:sınıf{ogrenciler[i]}");
                }
                Console.WriteLine("güncellemek istediğiniz sınıf indexno:");
                int indexno = Convert.ToInt32(Console.ReadLine());
                sınıflar.RemoveAt(indexno);
                Console.Write("güncellemek istediğiniz sınıfı girin");
                sınıflar.Insert(indexno, new sınıflar { sınıf = Convert.ToInt32(Console.ReadLine()) });
                
            }
            else if (cevap == 4)
            {

                for (int i = 0; i < dersler.Capacity; i++)
                {
                    Console.WriteLine($"indexno:{i}:ders{dersler[i]}");
                }
                Console.WriteLine("güncellemek istediğiniz ders indexno:");
                int indexno = Convert.ToInt32(Console.ReadLine());
                dersler.RemoveAt(indexno);
                Console.Write("güncellemek istediğiniz dersi girin");
                dersler.Insert(indexno, new dersler { ders = Console.ReadLine() });

            }
        }
        internal static void LISTELEME()
        {
            Console.WriteLine("öğrenciler için-1\nöğretmenler için-2\nsınıflar için-3\ndersler için-4\nhangi birimde LİSTELEME işlemi yapmak istiyorsunuz");
            int cevap = Convert.ToInt32(Console.ReadLine());
            if (cevap == 1)
            {
                int i = 0;
                while (i < ogrenciler.Count)
                {
                   ogrenciler a = (ogrenciler)ogrenciler[i];
                    Console.WriteLine($"öğrenci adı:{a.ogrenciadi},öğrenci soyadı:{a.ogrencisoyadi},öğrenci yaşı:{a.ogrenciyasi},öğrenci notu:{a.ogrencinotu}");
                    i++;
                }
            }
            else if (cevap == 2)
            {
                int i = 0;
                while (i < ogretmenler.Count)
                {
                    ogretmenler a = (ogretmenler)ogretmenler[i];
                    Console.WriteLine($"indexno:{i},öğretmen adı:{a.ogretmenadi},öğretmen soyadı:{a.ogretmensoyadi},öğretmen yaşı:{a.ogretmenyasi}");
                    i++;
                }
            }
            else if (cevap == 3)
            {
                for (int i = 0; i < sınıflar.Capacity; i++)
                {
                    Console.WriteLine($"indexno:{i}:sınıf{ogrenciler[i]}");
                }
            }
            else if (cevap == 4)
            {
                for (int i = 0; i < dersler.Capacity; i++)
                {
                    Console.WriteLine($"indexno:{i}:ders{dersler[i]}");
                }
            }
        }
        internal static void NOTLAR()
        {

            int i = 0;
            while (i < ogrenciler.Count)
            {
                ogrenciler a = (ogrenciler)ogrenciler[i];
                Console.WriteLine($"indexno:{i}öğrenci adı:{a.ogrenciadi},öğrenci soyadı:{a.ogrencisoyadi},öğrenci yaşı:{a.ogrenciyasi},öğrenci notu:{a.ogrencinotu}");
                i++;
            }
            Console.WriteLine("not eklemek istediğiniz öğrencinin indexno:");
            int indexno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girmek istediğiniz notu girin");
            ogrenciler.Add(new ogrenciler { ogrencinotu = Convert.ToInt32(Console.ReadLine()) });
        }



    }
   
}
