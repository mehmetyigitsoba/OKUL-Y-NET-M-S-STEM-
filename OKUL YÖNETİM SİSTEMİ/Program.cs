using System.ComponentModel.Design;

namespace OKUL_YÖNETİM_SİSTEMİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adminsifre = 123456;
            int hak = 3;
            while (hak>0)
            {
                try
                {
                    hak--;
                    Console.WriteLine("şifreyi girin");
                    int sifre1 = Convert.ToInt32(Console.ReadLine());
                    if (sifre1 == adminsifre || ogrenci.ogrrencilerinsifreleri.Contains(sifre1))
                    {
                        try
                        {

                            Console.WriteLine("ÖĞRENCİ YÖNETİMİ İÇİN -1\nÖĞRETMEN YÖNETİMİ İÇİN-2\nSINIF VE DERS YÖNETİMİ İÇİN-3\nÇIKMAK İÇİN-0\nhangi işlemi yapmak istiyorsunuz");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 1)
                            {
                                Console.WriteLine("ÖĞRENCİ EKLEMEK İÇİN -1\nÖĞRENCİ GÜNCELLEMEK İÇİN-2\nÖĞRENCİ SİLMEK İÇİN-3\nÖĞRENCİ LİSTELEMEK İÇİN-4\nÇIKMAK İÇİN-0\nhangi işlemi yapmak istiyorsunuz");
                                int t = Convert.ToInt32(Console.ReadLine());
                                while (true)
                                {
                                    try
                                    {
                                        if (t == 1)
                                        {
                                            ogrenci.OGRENCIEKLE();
                                        }
                                        else if (t == 2)
                                        {
                                            ogrenci.OGRENCIEKLE();
                                        }
                                        else if (t == 3)
                                        {
                                            ogrenci.OGRENCISIL();
                                        }
                                        else if (t == 4)
                                        {
                                            ogrenci.OGRENCILISTELEME();
                                        }
                                        else if (t == 0)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("HATALI İŞLEM");
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("rakam girin");
                                    }
                                }

                            }
                            else if (secim == 2)
                            {
                                Console.WriteLine("ÖĞRETMEN EKLEMEK İÇİN -1\nÖĞRETMEN GÜNCELLEMEK İÇİN-2\nÖĞRETMEN SİLMEK İÇİN-3\nÖĞRETMEN LİSTELEMEK İÇİN-4\nÇIKMAK İÇİN-0\nhangi işlemi yapmak istiyorsunuz");
                                int t = Convert.ToInt32(Console.ReadLine());
                                while (true)
                                {
                                    try
                                    {
                                        if (t == 1) { ogretmen.OGRETMENEKLE(); }
                                        else if (t == 2) { ogretmen.OGRETMENGUNCELLEME(); }
                                        else if (t == 3) { ogretmen.OGRETMENSIL(); }
                                        else if (t == 4) { ogretmen.OGRETMENLISTELEME(); }
                                        else if (t == 0) { break; }
                                        else { Console.WriteLine("hatalı işlem"); }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("rakam girin");
                                    }
                                }

                            }
                            else if (secim == 3)
                            {
                                while (true)
                                {
                                    try
                                    {

                                        Console.WriteLine("SINIF VE DERS EKLEMEK İÇİN -1\nSINIF VE DERS LİSTELEMEK İÇİN-2\nÇIKMAK İÇİN-0\nhangi işlemi yapmak istiyorsunuz");
                                        int t = Convert.ToInt32(Console.ReadLine());
                                        if (t == 1) { sınıfveders.SINIFVEDERSEKLE(); }
                                        else if (t == 2) { sınıfveders.SINIFVEDERSLISTELEME(); }
                                        else if (t == 0) { break; }
                                        else { Console.WriteLine("HATALI İŞLEM"); }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("rakam girin");
                                    }



                                }

                            }
                            else if (secim == 0) { break; }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("rakam girin");
                        }
                    }
                    else if (hak == 0)
                    {
                        Console.WriteLine("hakkınız bitti");
                    }
                    else
                    {
                        Console.WriteLine("hatalı şifre");
                        Console.WriteLine("kalan hakkınız" + hak);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("rakam girin");
                }
                

               









            }   
                
        }
    }
}
